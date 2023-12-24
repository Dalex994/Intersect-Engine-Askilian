using System.ComponentModel;
using System.Windows.Forms;
using DarkUI.Controls;
using Timer = System.Windows.Forms.Timer;

namespace Intersect.Editor.Forms
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            var resources = new ComponentResourceManager(typeof(FrmLogin));
            lblStatus = new Label();
            tmrSocket = new Timer(components);
            txtUsername = new DarkTextBox();
            txtPassword = new DarkTextBox();
            btnLogin = new DarkButton();
            picLogo = new PictureBox();
            lblVersion = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblGettingStarted = new Label();
            chkRemember = new DarkCheckBox();
            ((ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = System.Drawing.Color.White;
            lblStatus.Location = new System.Drawing.Point(16, 482);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(668, 35);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Connecting to server, please wait...";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tmrSocket
            // 
            tmrSocket.Enabled = true;
            tmrSocket.Tick += tmrSocket_Tick;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txtUsername.Location = new System.Drawing.Point(643, 323);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(169, 27);
            txtUsername.TabIndex = 1;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txtPassword.Location = new System.Drawing.Point(643, 363);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(169, 27);
            txtPassword.TabIndex = 2;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(712, 435);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(7, 8, 7, 8);
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // picLogo
            // 
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Location = new System.Drawing.Point(71, 27);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(701, 282);
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            // 
            // lblVersion
            // 
            lblVersion.BackColor = System.Drawing.Color.Transparent;
            lblVersion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblVersion.ForeColor = System.Drawing.Color.Gainsboro;
            lblVersion.Location = new System.Drawing.Point(496, 491);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(343, 31);
            lblVersion.TabIndex = 5;
            lblVersion.Text = "Editor v1.0.0.0";
            lblVersion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = System.Drawing.Color.White;
            lblUsername.Location = new System.Drawing.Point(560, 328);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = System.Drawing.Color.White;
            lblPassword.Location = new System.Drawing.Point(560, 368);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            // 
            // lblGettingStarted
            // 
            lblGettingStarted.BackColor = System.Drawing.Color.Transparent;
            lblGettingStarted.ForeColor = System.Drawing.Color.White;
            lblGettingStarted.Location = new System.Drawing.Point(16, 314);
            lblGettingStarted.Margin = new Padding(4, 0, 4, 0);
            lblGettingStarted.Name = "lblGettingStarted";
            lblGettingStarted.Size = new Size(484, 89);
            lblGettingStarted.TabIndex = 8;
            lblGettingStarted.Text = "Getting Started?\r\n1. Start the Intersect Server\r\n2. Open the Intersect Client & Create an Account\r\n3. Login to that account here to start designing your game!";
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.ForeColor = System.Drawing.Color.White;
            chkRemember.Location = new System.Drawing.Point(643, 402);
            chkRemember.Margin = new Padding(4, 5, 4, 5);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(129, 24);
            chkRemember.TabIndex = 3;
            chkRemember.Text = "Remember Me";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            ClientSize = new Size(837, 520);
            Controls.Add(chkRemember);
            Controls.Add(lblGettingStarted);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblVersion);
            Controls.Add(picLogo);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Intersect Editor Login";
            Load += frmLogin_Load;
            KeyDown += FrmLogin_KeyDown;
            ((ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Timer tmrSocket;
        private DarkTextBox txtUsername;
        private DarkTextBox txtPassword;
        private DarkButton btnLogin;
        private PictureBox picLogo;
        private Label lblVersion;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblGettingStarted;
        private DarkCheckBox chkRemember;
        public Label lblStatus;
    }
}