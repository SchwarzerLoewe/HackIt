using HackIt.Core;
using System.IO;
using System.Windows.Forms;

namespace HackIt
{
    public partial class MissionPackSelector : DialogForm
    {
        public MissionPackSelector()
        {
            InitializeComponent();

            if(!Directory.Exists(Application.StartupPath + "\\MissionPacks"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\MissionPacks"); 
            }

            foreach (var m in Directory.GetFiles(Application.StartupPath + "\\MissionPacks", "*.mp"))
            {
                var mp = MissionPack.Load(m);
                var item = new ComboboxItem();
                item.Text = mp.Name;
                item.Value = mp;

                mpComboBox.Items.Add(item);
            }

            mpComboBox.SelectedIndex = 0;
        }

        private void mpComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ServiceLocator.Add("MissionPack", (mpComboBox.SelectedItem as ComboboxItem).Value);
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString() => Text;
    }
}