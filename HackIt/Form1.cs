using HackIt.Core;
using HackIt.Pages;
using System.Windows.Forms;

namespace HackIt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            NavigationService.Container = pageContainer;

            Adorner.AddBadgeTo(messagesButton, "10");
            var badge = Adorner.GetBadge(messagesButton);
            badge.ForeColor = System.Drawing.Color.LawnGreen;

            var links = NavigationService.CreateLinks(new[] { typeof(ConsolePage), typeof(NetworkPage) },
                (_) =>
                {
                    _.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
                    _.LinkColor = System.Drawing.Color.FromArgb(0, 192, 0);
                    _.VisitedLinkColor = System.Drawing.Color.FromArgb(0, 192, 0);
                });

            flowLayoutPanel1.Controls.AddRange(links);

            ServiceLocator.Add("SavedGame", SavedGame.Load());
        }

        private void closeBtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}