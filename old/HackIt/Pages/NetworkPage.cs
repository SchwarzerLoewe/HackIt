using HackIt.Core;
using System.Windows.Forms;

namespace HackIt.Pages
{
    public partial class NetworkPage : UserControl, INavigatable
    {
        public NetworkPage()
        {
            InitializeComponent();
        }

        public string Title => "Network";

        public void OnNavigate()
        {
            
        }
    }
}