namespace HackIt
{
    partial class MissionPackSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissionPackSelector));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mpComboBox = new System.Windows.Forms.ComboBox();
            this.newMissionPackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.ForeColor = System.Drawing.Color.Black;
            this.okButton.Location = new System.Drawing.Point(197, 40);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(116, 40);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // mpComboBox
            // 
            this.mpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mpComboBox.FormattingEnabled = true;
            this.mpComboBox.Location = new System.Drawing.Point(13, 13);
            this.mpComboBox.Name = "mpComboBox";
            this.mpComboBox.Size = new System.Drawing.Size(259, 21);
            this.mpComboBox.TabIndex = 2;
            this.mpComboBox.SelectedIndexChanged += new System.EventHandler(this.mpComboBox_SelectedIndexChanged);
            // 
            // newMissionPackButton
            // 
            this.newMissionPackButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.newMissionPackButton.ForeColor = System.Drawing.Color.Black;
            this.newMissionPackButton.Location = new System.Drawing.Point(13, 40);
            this.newMissionPackButton.Name = "newMissionPackButton";
            this.newMissionPackButton.Size = new System.Drawing.Size(75, 23);
            this.newMissionPackButton.TabIndex = 3;
            this.newMissionPackButton.Text = "New";
            this.newMissionPackButton.UseVisualStyleBackColor = true;
            this.newMissionPackButton.Click += new System.EventHandler(this.newMissionPackButton_Click);
            // 
            // MissionPackSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 75);
            this.Controls.Add(this.newMissionPackButton);
            this.Controls.Add(this.mpComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MissionPackSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MissionPack";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox mpComboBox;
        private System.Windows.Forms.Button newMissionPackButton;
    }
}