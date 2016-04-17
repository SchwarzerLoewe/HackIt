using System;
using System.Windows.Forms;
using HackIt.Core;
using HackIt.Core.Models;
using System.Linq;

namespace MissionBuilder.Pages
{
    public partial class GeneralPage : UserControl, INavigatable
    {
        private Mission currentMission;
        private MissionPack mp;

        public string Title => "General";

        public GeneralPage()
        {
            this.currentMission = ServiceLocator.Get<Mission>("CurrentMission");
            this.mp = ServiceLocator.Get<MissionPack>("MissionPack");

            InitializeComponent();

            nameTextBox.Text = currentMission.Title;
            toolAsDialogCheckBox.Checked = currentMission.ToolsAsDialog;

            toolsComboBox.SelectedIndex = 0;

            if (currentMission.UsableTools != null)
            {
                toolsListBox.Items.AddRange(currentMission.UsableTools);

                foreach (var tool in currentMission.UsableTools)
                {
                    toolsComboBox.Items.Remove(tool);
                }
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            currentMission.Title = nameTextBox.Text;
        }

        private void addToolBtn_Click(object sender, EventArgs e)
        {
            toolsListBox.Items.Add(toolsComboBox.SelectedItem.ToString());
            currentMission.UsableTools = toolsListBox.Items.ToArray();

            toolsComboBox.Items.RemoveAt(toolsComboBox.SelectedIndex);
        }

        private void removeToolBtn_Click(object sender, EventArgs e)
        {
            toolsComboBox.Items.Add(toolsListBox.SelectedItem.ToString());

            toolsListBox.Items.RemoveAt(toolsListBox.SelectedIndex);
            currentMission.UsableTools = toolsListBox.Items.ToArray();
        }


        private void toolAsDialogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            currentMission.ToolsAsDialog = toolAsDialogCheckBox.Checked;
        }

        public void OnNavigate()
        {
            
        }
    }
}