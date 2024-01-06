using System.ComponentModel;
using System.Windows.Forms;
using DarkUI.Controls;
using Timer = System.Windows.Forms.Timer;

namespace Intersect.Editor.Forms
{
    partial class FrmUpdate
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
            var resources = new ComponentResourceManager(typeof(FrmUpdate));
            lblStatus = new Label();
            picLogo = new PictureBox();
            lblVersion = new Label();
            progressBar = new ProgressBar();
            lblFiles = new Label();
            lblSize = new Label();
            tmrUpdate = new Timer(components);
            ((ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = System.Drawing.Color.White;
            lblStatus.Location = new System.Drawing.Point(41, 338);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(759, 35);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Checking for updates, please wait!";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Location = new System.Drawing.Point(43, 34);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(773, 287);
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
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(43, 378);
            progressBar.Margin = new Padding(4, 5, 4, 5);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(757, 40);
            progressBar.TabIndex = 6;
            progressBar.Value = 20;
            // 
            // lblFiles
            // 
            lblFiles.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFiles.ForeColor = System.Drawing.Color.White;
            lblFiles.Location = new System.Drawing.Point(37, 423);
            lblFiles.Margin = new Padding(4, 0, 4, 0);
            lblFiles.Name = "lblFiles";
            lblFiles.Size = new Size(379, 35);
            lblFiles.TabIndex = 7;
            lblFiles.Text = "20 Files Remaining";
            lblFiles.TextAlign = ContentAlignment.MiddleLeft;
            lblFiles.Visible = false;
            // 
            // lblSize
            // 
            lblSize.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSize.ForeColor = System.Drawing.Color.White;
            lblSize.Location = new System.Drawing.Point(484, 423);
            lblSize.Margin = new Padding(4, 0, 4, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(316, 35);
            lblSize.TabIndex = 8;
            lblSize.Text = "100 MB Left";
            lblSize.TextAlign = ContentAlignment.MiddleRight;
            lblSize.Visible = false;
            // 
            // tmrUpdate
            // 
            tmrUpdate.Enabled = true;
            tmrUpdate.Interval = 10;
            tmrUpdate.Tick += tmrUpdate_Tick;
            // 
            // FrmUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            ClientSize = new Size(837, 520);
            Controls.Add(lblSize);
            Controls.Add(lblFiles);
            Controls.Add(progressBar);
            Controls.Add(lblVersion);
            Controls.Add(picLogo);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ereda Editor - Updating";
            Load += frmUpdate_Load;
            ((ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblStatus;
        private PictureBox picLogo;
        private Label lblVersion;
        private ProgressBar progressBar;
        private Label lblFiles;
        private Label lblSize;
        private Timer tmrUpdate;
    }
}