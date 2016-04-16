using System;
using System.Windows.Forms;
using HackIt.Core;
using HackIt.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace MissionBuilder.Pages
{
    public partial class GeneralPage : UserControl
    {
        private Mission currentMission;
        private MissionPack mp;

        public GeneralPage()
        {
            this.currentMission = ServiceLocator.Get<Mission>("CurrentMission");
            this.mp = ServiceLocator.Get<MissionPack>("MissionPack");

            InitializeComponent();

            dificultyComboBox.DataSource = Enum.GetValues(typeof(MissionDifficulty));
            nameTextBox.Text = currentMission.Title;
            toolAsDialogCheckBox.Checked = currentMission.ToolsAsDialog;

            toolsComboBox.SelectedIndex = 0;

            if (currentMission.UsableTools != null)
            {
                toolsListBox.Items.AddRange(currentMission.UsableTools);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            currentMission.Title = nameTextBox.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentMission != null)
            {
                currentMission.Difficulty = (MissionDifficulty)dificultyComboBox.SelectedItem;
            }
        }

        private void addToolBtn_Click(object sender, EventArgs e)
        {
            toolsListBox.Items.Add(toolsComboBox.SelectedText);
            currentMission.UsableTools = toolsListBox.Items.ToArray();
        }

        private void removeToolBtn_Click(object sender, EventArgs e)
        {
            toolsListBox.Items.RemoveAt(toolsListBox.SelectedIndex);
            currentMission.UsableTools = toolsListBox.Items.ToArray();
        }


        private void toolAsDialogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            currentMission.ToolsAsDialog = toolAsDialogCheckBox.Checked;
        }
    }
}