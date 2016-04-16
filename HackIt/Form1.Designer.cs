namespace HackIt
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuContainer = new System.Windows.Forms.Panel();
            this.consoleLink = new System.Windows.Forms.LinkLabel();
            this.toolsLink = new System.Windows.Forms.LinkLabel();
            this.networkLink = new System.Windows.Forms.LinkLabel();
            this.messagesLink = new System.Windows.Forms.LinkLabel();
            this.pageContainer = new System.Windows.Forms.Panel();
            this.policeTimer = new System.Windows.Forms.Timer(this.components);
            this.statusbarContainer = new System.Windows.Forms.Panel();
            this.ipLabel = new System.Windows.Forms.Label();
            this.messagesButton = new System.Windows.Forms.Button();
            this.menuContainer.SuspendLayout();
            this.statusbarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuContainer
            // 
            this.menuContainer.Controls.Add(this.messagesButton);
            this.menuContainer.Controls.Add(this.consoleLink);
            this.menuContainer.Controls.Add(this.toolsLink);
            this.menuContainer.Controls.Add(this.networkLink);
            this.menuContainer.Controls.Add(this.messagesLink);
            this.menuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuContainer.Location = new System.Drawing.Point(0, 0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(119, 428);
            this.menuContainer.TabIndex = 0;
            // 
            // consoleLink
            // 
            this.consoleLink.ActiveLinkColor = System.Drawing.Color.LimeGreen;
            this.consoleLink.AutoSize = true;
            this.consoleLink.LinkColor = System.Drawing.Color.Lime;
            this.consoleLink.Location = new System.Drawing.Point(33, 85);
            this.consoleLink.Name = "consoleLink";
            this.consoleLink.Size = new System.Drawing.Size(45, 13);
            this.consoleLink.TabIndex = 3;
            this.consoleLink.TabStop = true;
            this.consoleLink.Text = "Konsole";
            this.consoleLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.consoleLink_LinkClicked);
            // 
            // toolsLink
            // 
            this.toolsLink.ActiveLinkColor = System.Drawing.Color.LimeGreen;
            this.toolsLink.AutoSize = true;
            this.toolsLink.LinkColor = System.Drawing.Color.Lime;
            this.toolsLink.Location = new System.Drawing.Point(26, 59);
            this.toolsLink.Name = "toolsLink";
            this.toolsLink.Size = new System.Drawing.Size(62, 13);
            this.toolsLink.TabIndex = 2;
            this.toolsLink.TabStop = true;
            this.toolsLink.Text = "Werkzeuge";
            // 
            // networkLink
            // 
            this.networkLink.ActiveLinkColor = System.Drawing.Color.LimeGreen;
            this.networkLink.AutoSize = true;
            this.networkLink.LinkColor = System.Drawing.Color.Lime;
            this.networkLink.Location = new System.Drawing.Point(30, 34);
            this.networkLink.Name = "networkLink";
            this.networkLink.Size = new System.Drawing.Size(52, 13);
            this.networkLink.TabIndex = 1;
            this.networkLink.TabStop = true;
            this.networkLink.Text = "Netzwerk";
            this.networkLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.networkLink_LinkClicked);
            // 
            // messagesLink
            // 
            this.messagesLink.ActiveLinkColor = System.Drawing.Color.LimeGreen;
            this.messagesLink.AutoSize = true;
            this.messagesLink.LinkColor = System.Drawing.Color.Lime;
            this.messagesLink.Location = new System.Drawing.Point(25, 9);
            this.messagesLink.Name = "messagesLink";
            this.messagesLink.Size = new System.Drawing.Size(65, 13);
            this.messagesLink.TabIndex = 0;
            this.messagesLink.TabStop = true;
            this.messagesLink.Text = "Nachrichten";
            // 
            // pageContainer
            // 
            this.pageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageContainer.Location = new System.Drawing.Point(119, 0);
            this.pageContainer.Name = "pageContainer";
            this.pageContainer.Size = new System.Drawing.Size(772, 390);
            this.pageContainer.TabIndex = 1;
            // 
            // statusbarContainer
            // 
            this.statusbarContainer.Controls.Add(this.ipLabel);
            this.statusbarContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusbarContainer.Location = new System.Drawing.Point(119, 390);
            this.statusbarContainer.Name = "statusbarContainer";
            this.statusbarContainer.Size = new System.Drawing.Size(772, 38);
            this.statusbarContainer.TabIndex = 2;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(16, 14);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(101, 13);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "Suche nach IP:  {0}";
            // 
            // messagesButton
            // 
            this.messagesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.messagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messagesButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.messagesButton.Location = new System.Drawing.Point(7, 115);
            this.messagesButton.Name = "messagesButton";
            this.messagesButton.Size = new System.Drawing.Size(109, 23);
            this.messagesButton.TabIndex = 4;
            this.messagesButton.Text = "Messages";
            this.messagesButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(891, 428);
            this.Controls.Add(this.pageContainer);
            this.Controls.Add(this.statusbarContainer);
            this.Controls.Add(this.menuContainer);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HackIt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuContainer.ResumeLayout(false);
            this.menuContainer.PerformLayout();
            this.statusbarContainer.ResumeLayout(false);
            this.statusbarContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuContainer;
        private System.Windows.Forms.Panel pageContainer;
        private System.Windows.Forms.LinkLabel consoleLink;
        private System.Windows.Forms.LinkLabel toolsLink;
        private System.Windows.Forms.LinkLabel networkLink;
        private System.Windows.Forms.LinkLabel messagesLink;
        private System.Windows.Forms.Timer policeTimer;
        private System.Windows.Forms.Panel statusbarContainer;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Button messagesButton;
    }
}

