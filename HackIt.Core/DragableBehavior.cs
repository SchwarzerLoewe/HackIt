using System.Drawing;
using System.Windows.Forms;

namespace HackIt.Core
{
    public class DragableBehavior
    {
        private bool drag = false; // determine if we should be moving the form
        private Point startPoint = new Point(0, 0); // also for the moving
        private Control target;

        public static DragableBehavior Create(Control target)
        {
            var db = new DragableBehavior();
            db.target = target;

            return db;
        }

        public void EnableDrag()
        {
            target.MouseDown += new MouseEventHandler(target_MouseDown);
            target.MouseUp += new MouseEventHandler(target_MouseUp);
            target.MouseMove += new MouseEventHandler(target_MouseMove);
        }
        public void DisableDrag()
        {
            target.MouseDown -= new MouseEventHandler(target_MouseDown);
            target.MouseUp -= new MouseEventHandler(target_MouseUp);
            target.MouseMove -= new MouseEventHandler(target_MouseMove);
        }

        private void target_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = target.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);
                target.Location = p3;
            }
        }
        private void target_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        private void target_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            drag = true;
        }
    }
}