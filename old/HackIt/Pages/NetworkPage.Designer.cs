namespace HackIt.Pages
{
    partial class NetworkPage
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
            this.components = new System.ComponentModel.Container();
            this.computerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iPAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // computerContextMenu
            // 
            this.computerContextMenu.BackColor = System.Drawing.Color.Black;
            this.computerContextMenu.DropShadowEnabled = false;
            this.computerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iPAnzeigenToolStripMenuItem});
            this.computerContextMenu.Name = "computerContextMenu";
            this.computerContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.computerContextMenu.ShowImageMargin = false;
            this.computerContextMenu.Size = new System.Drawing.Size(128, 48);
            // 
            // iPAnzeigenToolStripMenuItem
            // 
            this.iPAnzeigenToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.iPAnzeigenToolStripMenuItem.Name = "iPAnzeigenToolStripMenuItem";
            this.iPAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.iPAnzeigenToolStripMenuItem.Text = "IP Anzeigen";
            // 
            // NetworkPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Name = "NetworkPage";
            this.Size = new System.Drawing.Size(478, 283);
            this.computerContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip computerContextMenu;
        private System.Windows.Forms.ToolStripMenuItem iPAnzeigenToolStripMenuItem;
    }
}
