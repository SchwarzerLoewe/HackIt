using System.Windows.Forms;

namespace HackIt.Core
{
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        public new string Text
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

    }
}