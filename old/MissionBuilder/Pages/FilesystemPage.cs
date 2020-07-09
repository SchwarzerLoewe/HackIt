using System;
using System.Windows.Forms;
using HackIt.Core;

namespace MissionBuilder.Pages
{
    public partial class FilesystemPage : UserControl, INavigatable
    {
        public FilesystemPage()
        {
            InitializeComponent();
        }

        public string Title => "Filesystem";

        public void OnNavigate()
        {
            
        }
    }
}