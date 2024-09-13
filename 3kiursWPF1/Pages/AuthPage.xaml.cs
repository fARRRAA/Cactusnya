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

    public partial class AuthPage : Page
    {
        static MainWindow _mainWindow;
        public AuthPage(MainWindow mw)
        {
            InitializeComponent();
            _mainWindow = mw;
        }
        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            var password = txtPassword.Password;
            var user = ConnectionDB.db.Logins.FirstOrDefault(log => log.Login == login && log.Password == password);
            if (user == null)
            {
                Users tempUser = new Users(){ Name = login };
                Logins tempLogins = new Logins() { Login=login, Password=password,Users=tempUser };
                ConnectionDB.db.Users.Add(tempUser);
                ConnectionDB.db.Logins.Add(tempLogins);
                ConnectionDB.db.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно");
                _mainWindow.MainFrame.NavigationService.Navigate(new UserPage(_mainWindow, tempUser, tempLogins));
                return;
            }
            MessageBox.Show("Такой юзер уже есть");
        }
    }
}
