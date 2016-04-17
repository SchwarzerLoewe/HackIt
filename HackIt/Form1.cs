using HackIt.Core;
using HackIt.Pages;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace HackIt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            NavigationService.Container = pageContainer;

            var drag = DragableBehavior.Create(titleBar, this);
            drag.EnableDrag();

            var imgs = new PreLoader<string>();
            imgs.PreLoad(new Func<string, string>((_) =>
            {
                var wc = new WebClient();
                return wc.DownloadStringTaskAsync(new Uri(_)).Result;
            }), "http://mail.aol.de/");

            Adorner.AddBadgeTo(messagesButton, "10");
            var badge = Adorner.GetBadge(messagesButton);
            badge.ForeColor = Color.LawnGreen;

            var links = NavigationService.CreateLinks(new[] { typeof(ConsolePage), typeof(NetworkPage) },
                (_) =>
                {
                    _.ForeColor = Color.FromArgb(0, 192, 0);
                    _.LinkColor = Color.FromArgb(0, 192, 0);
                    _.VisitedLinkColor = Color.FromArgb(0, 192, 0);
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