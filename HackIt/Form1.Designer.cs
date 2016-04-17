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
            this.messagesButton = new System.Windows.Forms.Button();
            this.pageContainer = new System.Windows.Forms.Panel();
            this.policeTimer = new System.Windows.Forms.Timer(this.components);
            this.statusbarContainer = new System.Windows.Forms.Panel();
            this.yourIPLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuContainer.SuspendLayout();
            this.statusbarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuContainer
            // 
            this.menuContainer.Controls.Add(this.flowLayoutPanel1);
            this.menuContainer.Controls.Add(this.messagesButton);
            this.menuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuContainer.Location = new System.Drawing.Point(0, 0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(119, 428);
            this.menuContainer.TabIndex = 0;
            // 
            // messagesButton
            // 
            this.messagesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messagesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.messagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messagesButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.messagesButton.Location = new System.Drawing.Point(0, 390);
            this.messagesButton.Name = "messagesButton";
            this.messagesButton.Size = new System.Drawing.Size(119, 38);
            this.messagesButton.TabIndex = 4;
            this.messagesButton.Text = "Messages";
            this.messagesButton.UseVisualStyleBackColor = true;
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
            this.statusbarContainer.Controls.Add(this.yourIPLabel);
            this.statusbarContainer.Controls.Add(this.ipLabel);
            this.statusbarContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusbarContainer.Location = new System.Drawing.Point(119, 390);
            this.statusbarContainer.Name = "statusbarContainer";
            this.statusbarContainer.Size = new System.Drawing.Size(772, 38);
            this.statusbarContainer.TabIndex = 2;
            // 
            // yourIPLabel
            // 
            this.yourIPLabel.AutoSize = true;
            this.yourIPLabel.Location = new System.Drawing.Point(659, 14);
            this.yourIPLabel.Name = "yourIPLabel";
            this.yourIPLabel.Size = new System.Drawing.Size(71, 13);
            this.yourIPLabel.TabIndex = 1;
            this.yourIPLabel.Text = "Deine IP:  {0}";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(119, 390);
            this.flowLayoutPanel1.TabIndex = 5;
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
            this.statusbarContainer.ResumeLayout(false);
            this.statusbarContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuContainer;
        private System.Windows.Forms.Panel pageContainer;
        private System.Windows.Forms.Timer policeTimer;
        private System.Windows.Forms.Panel statusbarContainer;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Button messagesButton;
        private System.Windows.Forms.Label yourIPLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

