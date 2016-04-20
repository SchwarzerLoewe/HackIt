namespace MissionBuilder.Pages
{
    partial class GeneralPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolsListBox = new System.Windows.Forms.ListBox();
            this.toolsComboBox = new System.Windows.Forms.ComboBox();
            this.addToolBtn = new System.Windows.Forms.Button();
            this.removeToolBtn = new System.Windows.Forms.Button();
            this.toolAsDialogCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(103, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(372, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usable Tools";
            // 
            // toolsListBox
            // 
            this.toolsListBox.FormattingEnabled = true;
            this.toolsListBox.Location = new System.Drawing.Point(103, 85);
            this.toolsListBox.Name = "toolsListBox";
            this.toolsListBox.Size = new System.Drawing.Size(134, 212);
            this.toolsListBox.TabIndex = 5;
            // 
            // toolsComboBox
            // 
            this.toolsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolsComboBox.FormattingEnabled = true;
            this.toolsComboBox.Items.AddRange(new object[] {
            "PasswordCracker",
            "VirusUploader",
            "Downloader",
            "Deleter"});
            this.toolsComboBox.Location = new System.Drawing.Point(243, 85);
            this.toolsComboBox.Name = "toolsComboBox";
            this.toolsComboBox.Size = new System.Drawing.Size(121, 21);
            this.toolsComboBox.TabIndex = 6;
            // 
            // addToolBtn
            // 
            this.addToolBtn.Location = new System.Drawing.Point(370, 83);
            this.addToolBtn.Name = "addToolBtn";
            this.addToolBtn.Size = new System.Drawing.Size(45, 23);
            this.addToolBtn.TabIndex = 7;
            this.addToolBtn.Text = "+";
            this.addToolBtn.UseVisualStyleBackColor = true;
            this.addToolBtn.Click += new System.EventHandler(this.addToolBtn_Click);
            // 
            // removeToolBtn
            // 
            this.removeToolBtn.Location = new System.Drawing.Point(421, 83);
            this.removeToolBtn.Name = "removeToolBtn";
            this.removeToolBtn.Size = new System.Drawing.Size(45, 23);
            this.removeToolBtn.TabIndex = 8;
            this.removeToolBtn.Text = "-";
            this.removeToolBtn.UseVisualStyleBackColor = true;
            this.removeToolBtn.Click += new System.EventHandler(this.removeToolBtn_Click);
            // 
            // toolAsDialogCheckBox
            // 
            this.toolAsDialogCheckBox.AutoSize = true;
            this.toolAsDialogCheckBox.Location = new System.Drawing.Point(103, 52);
            this.toolAsDialogCheckBox.Name = "toolAsDialogCheckBox";
            this.toolAsDialogCheckBox.Size = new System.Drawing.Size(15, 14);
            this.toolAsDialogCheckBox.TabIndex = 9;
            this.toolAsDialogCheckBox.UseVisualStyleBackColor = true;
            this.toolAsDialogCheckBox.CheckedChanged += new System.EventHandler(this.toolAsDialogCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tools as Dialoges";
            // 
            // GeneralPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolAsDialogCheckBox);
            this.Controls.Add(this.removeToolBtn);
            this.Controls.Add(this.addToolBtn);
            this.Controls.Add(this.toolsComboBox);
            this.Controls.Add(this.toolsListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "GeneralPage";
            this.Size = new System.Drawing.Size(485, 312);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox toolsListBox;
        private System.Windows.Forms.ComboBox toolsComboBox;
        private System.Windows.Forms.Button addToolBtn;
        private System.Windows.Forms.Button removeToolBtn;
        private System.Windows.Forms.CheckBox toolAsDialogCheckBox;
        private System.Windows.Forms.Label label4;
    }
}
