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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MEdiCom.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var userName = txtUserName.Text.Trim();
            var password = txtPassword.Password.ToString();
            if (validate(userName, password)) {
                if (verifyUser(userName, password))
                {
                    wndHome wnd = new wndHome();
                    this.Hide();
                    wnd.Show();
                }
                else
                {
                    lblMsg.Content = "Invalid Username or Password!";
                }
            }
        }

        bool verifyUser(string username, string password)
        {
            return true;
        }

        bool validate(string username, string password)
        {
            var flag = true;
            if (string.IsNullOrEmpty(username))
            {
                lblMsg.Content = "Enter user name";
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                lblMsg.Content = "Enter password";
                return false;
            }
            return true;
        }
    }
}
