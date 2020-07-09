using HackIt.Core;
using System.Windows.Forms;

namespace HackIt
{
    public partial class NewMissionPackDialog : Form
    {
        public NewMissionPackDialog()
        {
            InitializeComponent();
        }

        public MissionPack MissionPack { get; internal set; }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            MissionPack = MissionPack.Load(Application.StartupPath + "\\MissionPacks\\" + missionNameTextBox.Text + ".mp");
            MissionPack.Name = missionNameTextBox.Text;

            ServiceLocator.Add("filename", Application.StartupPath + "\\MissionPacks\\" + missionNameTextBox.Text + ".mp");
            DialogResult = DialogResult.OK;
        }
    }
}