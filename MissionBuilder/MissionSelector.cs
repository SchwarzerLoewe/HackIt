using HackIt.Core;
using System.Windows.Forms;
using HackIt.Core.Models;

namespace MissionBuilder
{
    public partial class MissionSelector : Form
    {
        public MissionSelector(MissionPack mp)
        {
            InitializeComponent();

            foreach (var m in mp)
            {
                var item = new ComboboxItem();
                item.Text = m.Title;
                item.Value = m;

                mpComboBox.Items.Add(item);
            }

            if (mpComboBox.Items.Count > 0)
            {
                mpComboBox.SelectedIndex = 0;
            }
        }

        public Mission Mission { get; internal set; }

        private void mpComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Mission = (mpComboBox.SelectedItem as ComboboxItem).Value as Mission;

            ServiceLocator.Add("CurrentMission", Mission);
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString() => Text;
    }
}