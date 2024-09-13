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
    /// Логика взаимодействия для Vystavka.xaml
    /// </summary>
    public partial class VystavkaPage : Page
    {
        static MainWindow _mainWindow;
        private Users _user;
        private Logins _login;
        public VystavkaPage(MainWindow mw, Users user, Logins login)
        {
            InitializeComponent();
            ListKaktus.ItemsSource = ConnectionDB.db.Kaktus.ToList();
            VystList.ItemsSource = ConnectionDB.db.Vystavka.ToList();
            _user = user;
            _login = login;
        }
        private void ListKaktus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_login.Role == "admin")
            {
                AddKaktus addKaktus = new AddKaktus(ListKaktus);
                addKaktus.ShowDialog();
            }
            else
            {
                MessageBox.Show("Добавить может только админ");
            }
        }
        private void Vystavka_Click(object sender, RoutedEventArgs e)
        {
            AddKaktus addKaktus = new AddKaktus(ListKaktus);
            addKaktus.ShowDialog();
        }
        private void ListKaktus_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var temp = (Kaktus)ListKaktus.SelectedItem;
            RedactKaktus rk = new RedactKaktus(temp, ListKaktus);
            rk.ShowDialog();
        }
        private void VystavkaAdd_Click(object sender, RoutedEventArgs e)
        {
            if (_login.Role == "admin")
            {
                VystavkaAdd vystavkaAdd = new VystavkaAdd(VystList);
                vystavkaAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Добавить может только админ");
            }
        }
        private void VystList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var temp = (Vystavka)VystList.SelectedItem;
            VystavkaRedact vr = new VystavkaRedact(temp, VystList);
            vr.ShowDialog();
        }
    }
}
