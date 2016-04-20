using HackIt.Core;
using HackIt.Pages;
using System.Drawing;
using System.Windows.Forms;

namespace HackIt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            NavigationService.Container = pageContainer;

            var drag = DragableBehavior.Create(titleBar, this);
            drag.EnableDrag();

            var links = NavigationService.CreateLinks(new[] { typeof(ConsolePage), typeof(NetworkPage) },
                (_) =>
                {
                    _.ForeColor = Color.FromArgb(0, 192, 0);
                    _.LinkColor = Color.FromArgb(0, 192, 0);
                    _.VisitedLinkColor = Color.FromArgb(0, 192, 0);
                });

            flowLayoutPanel1.Controls.AddRange(links);

            ServiceLocator.Add("SavedGame", SavedGame.Load());
            NavigationService.Navigate(new WelcomePage());
        }

        private void closeBtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}