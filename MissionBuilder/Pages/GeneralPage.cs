using System;
using System.Windows.Forms;
using HackIt.Core;
using HackIt.Core.Models;

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
    }
}