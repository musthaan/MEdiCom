using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MEdiCom.UI
{
    /// <summary>
    /// Interaction logic for wndHome.xaml
    /// </summary>
    public partial class wndHome : Window
    {
        public wndHome()
        {
            InitializeComponent();
        }

        private void MenuItem_Users_Click(object sender, RoutedEventArgs e)
        {
            wndUserList wnd = new wndUserList();
            wnd.Show();
        }
    }
}
