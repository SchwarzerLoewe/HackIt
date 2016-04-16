using System.Windows.Forms;

namespace HackIt.Core
{
    public static class NavigationService
    {
        public static Control Container { get; set; }

        public static void Navigate(Control ctrl)
        {
            Container.Controls.Clear();
            ctrl.Dock = DockStyle.Fill;

            Container.Controls.Add(ctrl);
        }
    }
}