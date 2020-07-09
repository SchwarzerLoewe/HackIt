using System.Windows.Forms;

namespace HackIt.Core
{
    public partial class DialogForm : Form
    {
        private bool _dragable;
        public bool Dragable
        {
            get { return _dragable; }
            set {
                _dragable = value;
                if(value)
                {
                    behavior.EnableDrag();
                }
                else
                {
                    behavior.DisableDrag();
                }
            }
        }

        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        DragableBehavior behavior;

        public DialogForm()
        {
            InitializeComponent();

            behavior = DragableBehavior.Create(titlePanel, this);
        }

        private void closeBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}