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

            ServiceLocator.Add("SavedGame", SavedGame.Load());
        }

        private void consoleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationService.Navigate(new ConsolePage());
        }

        private void networkLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationService.Navigate(new NetworkPage());
        }
    }
}