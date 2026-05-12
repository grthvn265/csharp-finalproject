namespace BizCalc
{
    partial class LoginForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.progressLoading = new System.Windows.Forms.ProgressBar();
            this.labelLoading = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.buttonTogglePassword = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(420, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(16, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(208, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Secure Sign-In";
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrompt.Location = new System.Drawing.Point(24, 86);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(167, 23);
            this.labelPrompt.TabIndex = 1;
            this.labelPrompt.Text = "Enter your password";
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(28, 114);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(320, 32);
            this.textPassword.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Location = new System.Drawing.Point(28, 164);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(170, 38);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Silver;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Location = new System.Drawing.Point(218, 164);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(170, 38);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Exit";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelFeedback
            // 
            this.labelFeedback.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeedback.Location = new System.Drawing.Point(24, 214);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(364, 45);
            this.labelFeedback.TabIndex = 5;
            this.labelFeedback.Text = "";
            this.labelFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLoading
            // 
            this.panelLoading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLoading.Controls.Add(this.progressLoading);
            this.panelLoading.Controls.Add(this.labelLoading);
            this.panelLoading.Location = new System.Drawing.Point(28, 268);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(360, 70);
            this.panelLoading.TabIndex = 6;
            this.panelLoading.Visible = false;
            // 
            // progressLoading
            // 
            this.progressLoading.Location = new System.Drawing.Point(12, 32);
            this.progressLoading.Name = "progressLoading";
            this.progressLoading.Size = new System.Drawing.Size(336, 18);
            this.progressLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressLoading.TabIndex = 1;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.DimGray;
            this.labelLoading.Location = new System.Drawing.Point(8, 8);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(70, 21);
            this.labelLoading.TabIndex = 0;
            this.labelLoading.Text = "Loading";
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 350;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // timerClose
            // 
            this.timerClose.Interval = 1400;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // buttonTogglePassword
            // 
            this.buttonTogglePassword.BackColor = System.Drawing.Color.Transparent;
            this.buttonTogglePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTogglePassword.FlatAppearance.BorderSize = 0;
            this.buttonTogglePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTogglePassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTogglePassword.ForeColor = System.Drawing.Color.Black;
            this.buttonTogglePassword.Location = new System.Drawing.Point(348, 114);
            this.buttonTogglePassword.Name = "buttonTogglePassword";
            this.buttonTogglePassword.Size = new System.Drawing.Size(40, 32);
            this.buttonTogglePassword.TabIndex = 7;
            this.buttonTogglePassword.Text = "👁";
            this.buttonTogglePassword.UseVisualStyleBackColor = false;
            this.buttonTogglePassword.Click += new System.EventHandler(this.buttonTogglePassword_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 360);
            this.Controls.Add(this.panelLoading);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonTogglePassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.ProgressBar progressLoading;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Timer timerClose;
        private System.Windows.Forms.Button buttonTogglePassword;
    }
}
