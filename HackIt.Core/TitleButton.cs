using System.Drawing;
using System.Windows.Forms;

namespace HackIt.Core
{
    public partial class TitleButton : UserControl
    {
        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public Image Icon
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public TitleButton()
        {
            InitializeComponent();


        }
    }
}