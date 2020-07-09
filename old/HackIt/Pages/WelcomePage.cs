using System;
using System.Windows.Forms;
using HackIt.Core;

namespace HackIt.Pages
{
    public partial class WelcomePage : UserControl, INavigatable
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        public string Title => "";

        public void OnNavigate()
        {
            
        }
    }
}
