using System;
using System.Drawing;
using System.Windows.Forms;

namespace BizCalc
{
    public partial class LoginForm : Form
    {
        private const string CorrectPassword = "C#Sharp";
        private const int MaxAttempts = 3;
        private int attempts;
        private int loadingDotCount;

        public LoginForm()
        {
            InitializeComponent();
            UpdateFeedback("Please enter your password.", Color.DimGray);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (panelLoading.Visible)
            {
                return;
            }

            attempts++;
            if (string.Equals(textPassword.Text, CorrectPassword, StringComparison.Ordinal))
            {
                UpdateFeedback("Loading...", Color.ForestGreen);
                StartLoadingAnimation();
                return;
            }

            var remaining = MaxAttempts - attempts;
            if (remaining > 0)
            {
                UpdateFeedback($"Incorrect password. {remaining} attempt(s) remaining.", Color.Firebrick);
                textPassword.SelectAll();
                textPassword.Focus();
                return;
            }

            UpdateFeedback("Access denied. Maximum attempts reached.", Color.Firebrick);
            MessageBox.Show("Maximum login attempts reached. The program will now terminate.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonTogglePassword_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '*')
            {
                textPassword.PasswordChar = '\0';
                buttonTogglePassword.Text = "🙈";
            }
            else
            {
                textPassword.PasswordChar = '*';
                buttonTogglePassword.Text = "👁";
            }
        }

        private void StartLoadingAnimation()
        {
            ToggleInputs(false);
            panelLoading.Visible = true;
            progressLoading.Style = ProgressBarStyle.Marquee;
            progressLoading.MarqueeAnimationSpeed = 30;
            loadingDotCount = 0;
            timerLoading.Start();
            timerClose.Start();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            loadingDotCount = (loadingDotCount + 1) % 4;
            labelLoading.Text = "Loading" + new string('.', loadingDotCount);
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            timerLoading.Stop();
            timerClose.Stop();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateFeedback(string message, Color color)
        {
            labelFeedback.Text = message;
            labelFeedback.ForeColor = color;
        }

        private void ToggleInputs(bool enabled)
        {
            textPassword.Enabled = enabled;
            buttonLogin.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }
    }
}
