using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SavingsCal
{
    public partial class Form1 : Form
    {
        private static readonly CultureInfo PhilippineCulture = new CultureInfo("en-PH");

        public Form1()
        {
            InitializeComponent();
            InitializeScheduleGrid();
            comboLoanRateType.SelectedIndex = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textCurrentSavings.Clear();
            textTargetGoal.Clear();
            textMonthlyDeposit.Clear();
            textLoanPrincipal.Clear();
            textLoanRate.Clear();
            textLoanTerm.Clear();
            labelResult.Text = "Result";
            BindSchedule(new List<SavingsScheduleEntry>());
        }

        private void textBox_LeaveFormatCurrency(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && decimal.TryParse(textBox.Text, out var value))
            {
                textBox.Text = value.ToString("N2", CultureInfo.InvariantCulture);
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            labelResult.Text = "";
            BindSchedule(new List<SavingsScheduleEntry>());
            bool hasErrors = false;

            if (!decimal.TryParse(textCurrentSavings.Text, out var currentSavings) || currentSavings < 0)
            {
                errorProvider.SetError(textCurrentSavings, "Enter a valid non-negative current savings amount.");
                hasErrors = true;
            }

            if (!decimal.TryParse(textTargetGoal.Text, out var targetGoal) || targetGoal <= 0)
            {
                errorProvider.SetError(textTargetGoal, "Enter a valid target goal greater than zero.");
                hasErrors = true;
            }

            if (!decimal.TryParse(textMonthlyDeposit.Text, out var monthlyDeposit) || monthlyDeposit < 0)
            {
                errorProvider.SetError(textMonthlyDeposit, "Enter a valid non-negative monthly deposit.");
                hasErrors = true;
            }
            
            if (hasErrors) return;

            if (currentSavings >= targetGoal)
            {
                labelResult.Text = "Goal already achieved.";
                BindSchedule(new List<SavingsScheduleEntry>());
                return;
            }

            if (monthlyDeposit == 0)
            {
                labelResult.Text = "Monthly deposit must be greater than zero.";
                BindSchedule(new List<SavingsScheduleEntry>());
                return;
            }

            var schedule = BuildSchedule(currentSavings, targetGoal, monthlyDeposit);
            if (schedule.Count == 0)
            {
                labelResult.Text = "Goal cannot be reached with the current inputs.";
                BindSchedule(new List<SavingsScheduleEntry>());
                return;
            }

            labelResult.Text = $"It will take {schedule.Count} month(s) to reach your goal.";
            BindSchedule(schedule);
        }

        private void buttonCalculateLoan_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            const int maxTermMonths = 600;
            bool hasErrors = false;

            if (!decimal.TryParse(textLoanPrincipal.Text, out var loanPrincipal) || loanPrincipal <= 0)
            {
                errorProvider.SetError(textLoanPrincipal, "Enter a valid loan principal greater than zero.");
                hasErrors = true;
            }

            if (!decimal.TryParse(textLoanRate.Text, out var loanRate) || loanRate < 0)
            {
                errorProvider.SetError(textLoanRate, "Enter a valid non-negative interest rate.");
                hasErrors = true;
            }

            if (!int.TryParse(textLoanTerm.Text, out var termMonths) || termMonths <= 0)
            {
                errorProvider.SetError(textLoanTerm, "Enter a valid loan term in months greater than zero.");
                hasErrors = true;
            }

            if (termMonths > maxTermMonths)
            {
                errorProvider.SetError(textLoanTerm, $"Loan term must be {maxTermMonths} months or less.");
                hasErrors = true;
            }

            if (hasErrors) return;

            var rateType = comboLoanRateType.SelectedItem as string ?? "Annual";
            if (rateType == "Annual" && termMonths < 12)
            {
                MessageBox.Show(this, "Annual interest rates are typically paired with terms of 12 months or more.", "Loan Term Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var monthlyRate = GetMonthlyLoanRate(loanRate);
            var monthlyPayment = CalculateLoanPayment(loanPrincipal, monthlyRate, termMonths);
            var totalPayment = monthlyPayment * termMonths;
            var totalInterest = totalPayment - loanPrincipal;

            labelResult.Text = $"Loan payment: {FormatCurrency(monthlyPayment)} per month. Total interest: {FormatCurrency(totalInterest)}.";
        }

        private void InitializeScheduleGrid()
        {
            gridSchedule.AutoGenerateColumns = false;
            gridSchedule.Columns.Clear();
            gridSchedule.Columns.Add(CreateTextColumn("Month", "Month", DataGridViewContentAlignment.MiddleRight));
            gridSchedule.Columns.Add(CreateTextColumn("StartingBalance", "Starting Balance", DataGridViewContentAlignment.MiddleRight));
            gridSchedule.Columns.Add(CreateTextColumn("Deposit", "Deposit", DataGridViewContentAlignment.MiddleRight));
            gridSchedule.Columns.Add(CreateTextColumn("Interest", "Interest", DataGridViewContentAlignment.MiddleRight));
            gridSchedule.Columns.Add(CreateTextColumn("EndingBalance", "Ending Balance", DataGridViewContentAlignment.MiddleRight));
        }

        private static DataGridViewTextBoxColumn CreateTextColumn(string dataPropertyName, string headerText, DataGridViewContentAlignment alignment)
        {
            return new DataGridViewTextBoxColumn
            {
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = alignment }
            };
        }

        private static List<SavingsScheduleEntry> BuildSchedule(decimal currentSavings, decimal targetGoal, decimal monthlyDeposit)
        {
            var balance = currentSavings;
            var schedule = new List<SavingsScheduleEntry>();

            while (balance < targetGoal && schedule.Count < 1200)
            {
                var startingBalance = balance;
                balance += monthlyDeposit;
                var interest = 0m;

                schedule.Add(new SavingsScheduleEntry
                {
                    Month = schedule.Count + 1,
                    StartingBalance = FormatCurrency(startingBalance),
                    Deposit = FormatCurrency(monthlyDeposit),
                    Interest = FormatCurrency(interest),
                    EndingBalance = FormatCurrency(balance)
                });
            }

            return balance >= targetGoal ? schedule : new List<SavingsScheduleEntry>();
        }

        private void BindSchedule(List<SavingsScheduleEntry> schedule)
        {
            gridSchedule.DataSource = schedule;
        }

        private static string FormatCurrency(decimal amount)
        {
            return string.Format(PhilippineCulture, "{0:C}", amount);
        }

        private static decimal CalculateLoanPayment(decimal principal, decimal monthlyRate, int termMonths)
        {
            if (monthlyRate == 0)
            {
                return principal / termMonths;
            }

            var rateFactor = (decimal)Math.Pow(1 + (double)monthlyRate, termMonths);
            return principal * monthlyRate * rateFactor / (rateFactor - 1);
        }

        private decimal GetMonthlyLoanRate(decimal inputRate)
        {
            var rateType = comboLoanRateType.SelectedItem as string ?? "Annual";
            return rateType == "Monthly" ? inputRate / 100m : inputRate / 1200m;
        }

        private class SavingsScheduleEntry
        {
            public int Month { get; set; }
            public string StartingBalance { get; set; }
            public string Deposit { get; set; }
            public string Interest { get; set; }
            public string EndingBalance { get; set; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
