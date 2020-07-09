using System.Drawing;
using System.Windows.Forms;

namespace HackIt.Core
{
    public class DragableBehavior
    {
        private bool drag = false;
        private Point startPoint = new Point(0, 0);
        private Control[] target;
        private Control movable;

        public static DragableBehavior Create(Control[] target, Control movable = null)
        {
            var db = new DragableBehavior();
            db.target = target;

            if(movable == null) {
                db.movable = target[0];
            }
            else
            {
                db.movable = movable;
            }

            return db;
        }
        public static DragableBehavior Create(Control target, Control movable = null)
        {
            var db = new DragableBehavior();
            db.target = new[] { target };

            if (movable == null)
            {
                db.movable = target;
            }
            else
            {
                db.movable = movable;
            }

            return db;
        }

        public void EnableDrag()
        {
            foreach (var t in target)
            {
                t.MouseDown += new MouseEventHandler(target_MouseDown);
                t.MouseUp += new MouseEventHandler(target_MouseUp);
                t.MouseMove += new MouseEventHandler(target_MouseMove);
            }
        }
        public void DisableDrag()
        {
            foreach (var t in target)
            {
                t.MouseDown -= new MouseEventHandler(target_MouseDown);
                t.MouseUp -= new MouseEventHandler(target_MouseUp);
                t.MouseMove -= new MouseEventHandler(target_MouseMove);
            }
        }

        private void target_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = ((Control)sender).PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);
                movable.Location = p3;
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