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
            this.SuspendLayout();
            // 
            // shellControl1
            // 
            this.shellControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellControl1.Location = new System.Drawing.Point(0, 0);
            this.shellControl1.Name = "shellControl1";
            this.shellControl1.Prompt = "> ";
            this.shellControl1.ShellTextBackColor = System.Drawing.Color.Black;
            this.shellControl1.ShellTextFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shellControl1.ShellTextForeColor = System.Drawing.Color.LimeGreen;
            this.shellControl1.Size = new System.Drawing.Size(621, 291);
            this.shellControl1.TabIndex = 0;
            this.shellControl1.CommandEntered += new UILibrary.EventCommandEntered(this.shellControl1_CommandEntered);
            // 
            // ConsolePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shellControl1);
            this.Name = "ConsolePage";
            this.Size = new System.Drawing.Size(621, 291);
            this.ResumeLayout(false);

        }

        #endregion

        private UILibrary.ShellControl shellControl1;
    }
}
