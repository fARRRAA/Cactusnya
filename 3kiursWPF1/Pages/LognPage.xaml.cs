using _3kiursWPF1.DB;
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

namespace _3kiursWPF1.Pages
{

    public partial class LognPage : Page
    {
        static MainWindow _mainWindow;
        public LognPage(MainWindow mw)
        {
            InitializeComponent();
            _mainWindow = mw;
            txtLogin.Text = "fara";
            txtPassword.Password = "123123";
        }
        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            var password = txtPassword.Password;
            var Login = ConnectionDB.db.Logins.FirstOrDefault(log => log.Login == login && log.Password==password);
            if (Login == null)
            {
                MessageBox.Show("неверный логин или парль");
                return;
            }
            var User = ConnectionDB.db.Users.FirstOrDefault(us => us.Id_User == Login.Id_User);
            _mainWindow.MainFrame.NavigationService.Navigate(new UserPage(_mainWindow, User, Login));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //_mainWindow.MainFrame.NavigationService.Navigate(new AuthPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainFrame.NavigationService.Navigate(new AuthPage(_mainWindow));

        }
    }
}
