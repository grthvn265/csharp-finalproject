namespace SavingsCal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.groupBoxSavings = new System.Windows.Forms.GroupBox();
            this.labelCurrentSavings = new System.Windows.Forms.Label();
            this.textCurrentSavings = new System.Windows.Forms.TextBox();
            this.labelTargetGoal = new System.Windows.Forms.Label();
            this.textTargetGoal = new System.Windows.Forms.TextBox();
            this.labelMonthlyDeposit = new System.Windows.Forms.Label();
            this.textMonthlyDeposit = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxLoan = new System.Windows.Forms.GroupBox();
            this.labelLoanPrincipal = new System.Windows.Forms.Label();
            this.textLoanPrincipal = new System.Windows.Forms.TextBox();
            this.labelLoanRate = new System.Windows.Forms.Label();
            this.textLoanRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboLoanRateType = new System.Windows.Forms.ComboBox();
            this.labelLoanTerm = new System.Windows.Forms.Label();
            this.textLoanTerm = new System.Windows.Forms.TextBox();
            this.buttonCalculateLoan = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.gridSchedule = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelHeader.SuspendLayout();
            this.groupBoxSavings.SuspendLayout();
            this.groupBoxLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(283, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Financial Dashboard";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(835, 60);
            this.panelHeader.TabIndex = 21;
            // 
            // groupBoxSavings
            // 
            this.groupBoxSavings.Controls.Add(this.labelCurrentSavings);
            this.groupBoxSavings.Controls.Add(this.textCurrentSavings);
            this.groupBoxSavings.Controls.Add(this.labelTargetGoal);
            this.groupBoxSavings.Controls.Add(this.textTargetGoal);
            this.groupBoxSavings.Controls.Add(this.labelMonthlyDeposit);
            this.groupBoxSavings.Controls.Add(this.textMonthlyDeposit);
            this.groupBoxSavings.Controls.Add(this.buttonCalculate);
            this.groupBoxSavings.Location = new System.Drawing.Point(24, 75);
            this.groupBoxSavings.Name = "groupBoxSavings";
            this.groupBoxSavings.Size = new System.Drawing.Size(390, 240);
            this.groupBoxSavings.TabIndex = 22;
            this.groupBoxSavings.TabStop = false;
            this.groupBoxSavings.Text = "Savings Goal Calculator";
            // 
            // labelCurrentSavings
            // 
            this.labelCurrentSavings.AutoSize = true;
            this.labelCurrentSavings.Location = new System.Drawing.Point(15, 40);
            this.labelCurrentSavings.Name = "labelCurrentSavings";
            this.labelCurrentSavings.Size = new System.Drawing.Size(155, 23);
            this.labelCurrentSavings.TabIndex = 0;
            this.labelCurrentSavings.Text = "Current Savings (₱)";
            // 
            // textCurrentSavings
            // 
            this.textCurrentSavings.Location = new System.Drawing.Point(210, 37);
            this.textCurrentSavings.Name = "textCurrentSavings";
            this.textCurrentSavings.Size = new System.Drawing.Size(150, 30);
            this.textCurrentSavings.TabIndex = 1;
            this.textCurrentSavings.Leave += new System.EventHandler(this.textBox_LeaveFormatCurrency);
            // 
            // labelTargetGoal
            // 
            this.labelTargetGoal.AutoSize = true;
            this.labelTargetGoal.Location = new System.Drawing.Point(15, 80);
            this.labelTargetGoal.Name = "labelTargetGoal";
            this.labelTargetGoal.Size = new System.Drawing.Size(122, 23);
            this.labelTargetGoal.TabIndex = 2;
            this.labelTargetGoal.Text = "Target Goal (₱)";
            // 
            // textTargetGoal
            // 
            this.textTargetGoal.Location = new System.Drawing.Point(210, 77);
            this.textTargetGoal.Name = "textTargetGoal";
            this.textTargetGoal.Size = new System.Drawing.Size(150, 30);
            this.textTargetGoal.TabIndex = 3;
            this.textTargetGoal.Leave += new System.EventHandler(this.textBox_LeaveFormatCurrency);
            // 
            // labelMonthlyDeposit
            // 
            this.labelMonthlyDeposit.AutoSize = true;
            this.labelMonthlyDeposit.Location = new System.Drawing.Point(15, 120);
            this.labelMonthlyDeposit.Name = "labelMonthlyDeposit";
            this.labelMonthlyDeposit.Size = new System.Drawing.Size(161, 23);
            this.labelMonthlyDeposit.TabIndex = 4;
            this.labelMonthlyDeposit.Text = "Monthly Deposit (₱)";
            // 
            // textMonthlyDeposit
            // 
            this.textMonthlyDeposit.Location = new System.Drawing.Point(210, 117);
            this.textMonthlyDeposit.Name = "textMonthlyDeposit";
            this.textMonthlyDeposit.Size = new System.Drawing.Size(150, 30);
            this.textMonthlyDeposit.TabIndex = 5;
            this.textMonthlyDeposit.Leave += new System.EventHandler(this.textBox_LeaveFormatCurrency);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculate.FlatAppearance.BorderSize = 0;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(19, 175);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(341, 40);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate Savings Goals";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // groupBoxLoan
            // 
            this.groupBoxLoan.Controls.Add(this.labelLoanPrincipal);
            this.groupBoxLoan.Controls.Add(this.textLoanPrincipal);
            this.groupBoxLoan.Controls.Add(this.labelLoanRate);
            this.groupBoxLoan.Controls.Add(this.textLoanRate);
            this.groupBoxLoan.Controls.Add(this.label1);
            this.groupBoxLoan.Controls.Add(this.comboLoanRateType);
            this.groupBoxLoan.Controls.Add(this.labelLoanTerm);
            this.groupBoxLoan.Controls.Add(this.textLoanTerm);
            this.groupBoxLoan.Controls.Add(this.buttonCalculateLoan);
            this.groupBoxLoan.Location = new System.Drawing.Point(420, 75);
            this.groupBoxLoan.Name = "groupBoxLoan";
            this.groupBoxLoan.Size = new System.Drawing.Size(390, 240);
            this.groupBoxLoan.TabIndex = 23;
            this.groupBoxLoan.TabStop = false;
            this.groupBoxLoan.Text = "Loan Estimator";
            // 
            // labelLoanPrincipal
            // 
            this.labelLoanPrincipal.AutoSize = true;
            this.labelLoanPrincipal.Location = new System.Drawing.Point(15, 40);
            this.labelLoanPrincipal.Name = "labelLoanPrincipal";
            this.labelLoanPrincipal.Size = new System.Drawing.Size(142, 23);
            this.labelLoanPrincipal.TabIndex = 12;
            this.labelLoanPrincipal.Text = "Loan Principal (₱)";
            // 
            // textLoanPrincipal
            // 
            this.textLoanPrincipal.Location = new System.Drawing.Point(210, 37);
            this.textLoanPrincipal.Name = "textLoanPrincipal";
            this.textLoanPrincipal.Size = new System.Drawing.Size(150, 30);
            this.textLoanPrincipal.TabIndex = 13;
            this.textLoanPrincipal.Leave += new System.EventHandler(this.textBox_LeaveFormatCurrency);
            // 
            // labelLoanRate
            // 
            this.labelLoanRate.AutoSize = true;
            this.labelLoanRate.Location = new System.Drawing.Point(15, 80);
            this.labelLoanRate.Name = "labelLoanRate";
            this.labelLoanRate.Size = new System.Drawing.Size(136, 23);
            this.labelLoanRate.TabIndex = 14;
            this.labelLoanRate.Text = "Interest Rate (%)";
            // 
            // textLoanRate
            // 
            this.textLoanRate.Location = new System.Drawing.Point(210, 77);
            this.textLoanRate.Name = "textLoanRate";
            this.textLoanRate.Size = new System.Drawing.Size(150, 30);
            this.textLoanRate.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Type of Interest";
            // 
            // comboLoanRateType
            // 
            this.comboLoanRateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLoanRateType.FormattingEnabled = true;
            this.comboLoanRateType.Items.AddRange(new object[] {
            "Monthly",
            "Annual"});
            this.comboLoanRateType.Location = new System.Drawing.Point(210, 117);
            this.comboLoanRateType.Name = "comboLoanRateType";
            this.comboLoanRateType.Size = new System.Drawing.Size(150, 31);
            this.comboLoanRateType.TabIndex = 16;
            // 
            // labelLoanTerm
            // 
            this.labelLoanTerm.AutoSize = true;
            this.labelLoanTerm.Location = new System.Drawing.Point(135, 155);
            this.labelLoanTerm.Name = "labelLoanTerm";
            this.labelLoanTerm.Size = new System.Drawing.Size(120, 23);
            this.labelLoanTerm.TabIndex = 17;
            this.labelLoanTerm.Text = "Term (Months)";
            // 
            // textLoanTerm
            // 
            this.textLoanTerm.Location = new System.Drawing.Point(280, 152);
            this.textLoanTerm.Name = "textLoanTerm";
            this.textLoanTerm.Size = new System.Drawing.Size(80, 30);
            this.textLoanTerm.TabIndex = 18;
            // 
            // buttonCalculateLoan
            // 
            this.buttonCalculateLoan.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCalculateLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculateLoan.FlatAppearance.BorderSize = 0;
            this.buttonCalculateLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculateLoan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculateLoan.ForeColor = System.Drawing.Color.White;
            this.buttonCalculateLoan.Location = new System.Drawing.Point(19, 187);
            this.buttonCalculateLoan.Name = "buttonCalculateLoan";
            this.buttonCalculateLoan.Size = new System.Drawing.Size(341, 40);
            this.buttonCalculateLoan.TabIndex = 19;
            this.buttonCalculateLoan.Text = "Calculate Loan Payment";
            this.buttonCalculateLoan.UseVisualStyleBackColor = false;
            this.buttonCalculateLoan.Click += new System.EventHandler(this.buttonCalculateLoan_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelResult.Location = new System.Drawing.Point(24, 335);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(65, 25);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Result";
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Location = new System.Drawing.Point(24, 370);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(79, 23);
            this.labelSchedule.TabIndex = 8;
            this.labelSchedule.Text = "Schedule";
            // 
            // gridSchedule
            // 
            this.gridSchedule.AllowUserToAddRows = false;
            this.gridSchedule.AllowUserToDeleteRows = false;
            this.gridSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSchedule.BackgroundColor = System.Drawing.Color.White;
            this.gridSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSchedule.EnableHeadersVisualStyles = false;
            this.gridSchedule.GridColor = System.Drawing.Color.Gainsboro;
            this.gridSchedule.Location = new System.Drawing.Point(24, 400);
            this.gridSchedule.Name = "gridSchedule";
            this.gridSchedule.ReadOnly = true;
            this.gridSchedule.RowHeadersVisible = false;
            this.gridSchedule.RowHeadersWidth = 62;
            this.gridSchedule.RowTemplate.Height = 30;
            this.gridSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSchedule.Size = new System.Drawing.Size(783, 290);
            this.gridSchedule.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(717, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(835, 710);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.groupBoxSavings);
            this.Controls.Add(this.groupBoxLoan);
            this.Controls.Add(this.gridSchedule);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.labelResult);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings and Loan Calculator";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupBoxSavings.ResumeLayout(false);
            this.groupBoxSavings.PerformLayout();
            this.groupBoxLoan.ResumeLayout(false);
            this.groupBoxLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCurrentSavings;
        private System.Windows.Forms.TextBox textCurrentSavings;
        private System.Windows.Forms.Label labelTargetGoal;
        private System.Windows.Forms.TextBox textTargetGoal;
        private System.Windows.Forms.Label labelMonthlyDeposit;
        private System.Windows.Forms.TextBox textMonthlyDeposit;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelSchedule;
        private System.Windows.Forms.DataGridView gridSchedule;
        private System.Windows.Forms.Label labelLoanPrincipal;
        private System.Windows.Forms.TextBox textLoanPrincipal;
        private System.Windows.Forms.Label labelLoanRate;
        private System.Windows.Forms.TextBox textLoanRate;
        private System.Windows.Forms.ComboBox comboLoanRateType;
        private System.Windows.Forms.Label labelLoanTerm;
        private System.Windows.Forms.TextBox textLoanTerm;
        private System.Windows.Forms.Button buttonCalculateLoan;
        private System.Windows.Forms.Label label1;
        
        // newly added containers/controls
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxSavings;
        private System.Windows.Forms.GroupBox groupBoxLoan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

