using HackIt.Core;
using System.IO;
using System.Windows.Forms;

namespace HackIt
{
    public partial class MissionPackSelector : Form
    {
        public MissionPackSelector()
        {
            InitializeComponent();

            foreach (var m in Directory.GetFiles(Application.StartupPath + "\\MissionPacks", "*.mp"))
            {
                var mp = MissionPack.Load(m);
                var item = new ComboboxItem();
                item.Text = mp.Name;
                item.Value = mp;
                item.Filename = m;

                mpComboBox.Items.Add(item);
            }

            if (mpComboBox.Items.Count > 0)
            {
                mpComboBox.SelectedIndex = 0;
            }
        }

        private void mpComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (mpComboBox.SelectedItem != null)
            {
                var item = (mpComboBox.SelectedItem as ComboboxItem);
                ServiceLocator.Add("MissionPack", item.Value);
                ServiceLocator.Add("filename", item.Filename);
            }
        }

        private void newMissionPackButton_Click(object sender, System.EventArgs e)
        {
            var nmp = new NewMissionPackDialog();
            if(nmp.ShowDialog() == DialogResult.OK)
            {
                ServiceLocator.Add("MissionPack", nmp.MissionPack);
            }
        }
    }

    public class ComboboxItem
    {
        public string Filename { get; internal set; }
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString() => Text;
    }
}