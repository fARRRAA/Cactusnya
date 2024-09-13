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
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        static MainWindow _mainWindow;

        private Users _user;
        private Logins _login;

        public UserPage(MainWindow mw,Users user,Logins login)
        {
            InitializeComponent();
            _mainWindow = mw;
            Name.Text = $"Имя: {user.Name}";
            Login.Text = $"Логин: {login.Login}";
            Password.Text = $"Пароль: {login.Password}";
            ID.Text = $"Айди: {user.Id_User}";
            Role.Text = $"Роль: {login.Role}";
            _user = user;
            _login = login;
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainFrame.NavigationService.Navigate(new VystavkaPage(_mainWindow,_user,_login));
        }
    }

}