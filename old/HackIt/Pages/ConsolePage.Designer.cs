namespace HackIt.Pages
{
    partial class ConsolePage
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.shellControl1 = new UILibrary.ShellControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.downloadFileButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shellControl1
            // 
            this.shellControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellControl1.Location = new System.Drawing.Point(0, 41);
            this.shellControl1.Name = "shellControl1";
            this.shellControl1.Prompt = "> ";
            this.shellControl1.ShellTextBackColor = System.Drawing.Color.Black;
            this.shellControl1.ShellTextFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shellControl1.ShellTextForeColor = System.Drawing.Color.LimeGreen;
            this.shellControl1.Size = new System.Drawing.Size(621, 250);
            this.shellControl1.TabIndex = 0;
            this.shellControl1.CommandEntered += new UILibrary.EventCommandEntered(this.shellControl1_CommandEntered);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.downloadFileButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 41);
            this.panel1.TabIndex = 1;
            // 
            // downloadFileButton
            // 
            this.downloadFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.downloadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadFileButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadFileButton.ForeColor = System.Drawing.Color.Black;
            this.downloadFileButton.Location = new System.Drawing.Point(344, 3);
            this.downloadFileButton.Name = "downloadFileButton";
            this.downloadFileButton.Size = new System.Drawing.Size(134, 32);
            this.downloadFileButton.TabIndex = 1;
            this.downloadFileButton.Text = "Download File";
            this.downloadFileButton.UseVisualStyleBackColor = false;
            this.downloadFileButton.Click += new System.EventHandler(this.downloadFileButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.Black;
            this.logoutButton.Location = new System.Drawing.Point(484, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(134, 32);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(275, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ping";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsolePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shellControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ConsolePage";
            this.Size = new System.Drawing.Size(621, 291);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UILibrary.ShellControl shellControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button downloadFileButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button button1;
    }
}
