using System.Drawing;
using System.Windows.Forms;

namespace HackIt.Core
{
    public partial class DialogForm : Form
    {
        private bool drag = false; // determine if we should be moving the form
        private Point startPoint = new Point(0, 0); // also for the moving

        public bool Dragable { get; set; }

        public DialogForm()
        {
            InitializeComponent();

            titlePanel.MouseDown += new MouseEventHandler(Title_MouseDown);
            titlePanel.MouseUp += new MouseEventHandler(Title_MouseUp);
            titlePanel.MouseMove += new MouseEventHandler(Title_MouseMove);
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            { 
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);
                Location = p3;
            }
        }

        private void Title_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            if(Dragable)
            {
                startPoint = e.Location;
                drag = true;
            }
        }

        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
    }
}