namespace HackIt
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pageContainer = new System.Windows.Forms.Panel();
            this.policeTimer = new System.Windows.Forms.Timer(this.components);
            this.statusbarContainer = new System.Windows.Forms.Panel();
            this.yourIPLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.menuContainer.SuspendLayout();
            this.statusbarContainer.SuspendLayout();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuContainer
            // 
            this.menuContainer.Controls.Add(this.flowLayoutPanel1);
            this.menuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuContainer.Location = new System.Drawing.Point(0, 38);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(119, 390);
            this.menuContainer.TabIndex = 0;
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
            // pageContainer
            // 
            this.pageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageContainer.Location = new System.Drawing.Point(119, 38);
            this.pageContainer.Name = "pageContainer";
            this.pageContainer.Size = new System.Drawing.Size(772, 352);
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
            this.yourIPLabel.Size = new System.Drawing.Size(65, 13);
            this.yourIPLabel.TabIndex = 1;
            this.yourIPLabel.Text = "Your IP:  {0}";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(16, 14);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(106, 13);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "Searching for IP:  {0}";
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.titleBar.Controls.Add(this.pictureBox1);
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Controls.Add(this.formTitleLabel);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(891, 38);
            this.titleBar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::HackIt.Properties.Resources._1460914717_Unlock;
            this.pictureBox1.Location = new System.Drawing.Point(13, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(848, 8);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(31, 22);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.formTitleLabel.Location = new System.Drawing.Point(416, 9);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(63, 19);
            this.formTitleLabel.TabIndex = 0;
            this.formTitleLabel.Text = "HackIt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(891, 428);
            this.Controls.Add(this.pageContainer);
            this.Controls.Add(this.statusbarContainer);
            this.Controls.Add(this.menuContainer);
            this.Controls.Add(this.titleBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HackIt";
            this.menuContainer.ResumeLayout(false);
            this.statusbarContainer.ResumeLayout(false);
            this.statusbarContainer.PerformLayout();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuContainer;
        private System.Windows.Forms.Panel pageContainer;
        private System.Windows.Forms.Timer policeTimer;
        private System.Windows.Forms.Panel statusbarContainer;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label yourIPLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label formTitleLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

