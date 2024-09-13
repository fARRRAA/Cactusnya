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
using System.Windows.Shapes;
using _3kiursWPF1.DB;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity;
namespace _3kiursWPF1.Pages
{
    /// <summary>
    /// Логика взаимодействия для VystavkaRedact.xaml
    /// </summary>
    public partial class VystavkaRedact : Window
    {
        public Vystavka _vystavka;
        public ListView _vystavkaList;
        public List<Kaktus> kaktuses = new List<Kaktus>();
        public async void GetKaktus()
        {
            string connectionStr = "Server=(localdb)\\Local;Database=WPFKOURS1;Trusted_Connection=True";
            string sqlExpression = $"select Id_Kaktus from Collection where Id_Vystavka = {_vystavka.Id_Vystavka}";
            List<int> data = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                await connection.OpenAsync();
                using (SqlCommand command = new SqlCommand(sqlExpression, connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            int a = 0;
                            int idKaktus = reader.GetInt32(a);
                            data.Add(idKaktus);
                            a++;
                        }
                    }
                }
            }
            foreach (int id in data)
            {
                var temp = await ConnectionDB.db.Kaktus.FirstOrDefaultAsync(x => x.Id_kaktus == id);
                kaktuses.Add(temp);
                VystavkaKaktus.ItemsSource = kaktuses;
            }
            //VystavkaKaktus.ItemsSource = ConnectionDB.db.Kaktus.ToList();
            //AllKaktus.ItemsSource = kaktuses;
        }
        public VystavkaRedact(Vystavka vystavka, ListView lw)
        {
            InitializeComponent();
            _vystavka = vystavka;
            _vystavkaList = lw;
            AllKaktus.ItemsSource = ConnectionDB.db.Kaktus.ToList();
            DateText.Text = $"Дата: {_vystavka.Date}";
            MestoVyst.Text = _vystavka.Mesto;
            GetKaktus();
            VystavkaKaktus.ItemsSource = kaktuses;
        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var oldVystavka = ConnectionDB.db.Vystavka.FirstOrDefault(x => x.Id_Vystavka == _vystavka.Id_Vystavka);
            if (calendar1.SelectedDate == null)
            {
                MessageBox.Show("выберите дату");
            }
            else
            {
                oldVystavka.Date = (DateTime)calendar1.SelectedDate;
                oldVystavka.Mesto = MestoVyst.Text;
                ConnectionDB.db.SaveChanges();
                MessageBox.Show("Редактирование прошло успешно");
                _vystavkaList.ItemsSource = ConnectionDB.db.Vystavka.ToList();
            }
        }
        private void calendar1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateText.Text = $"Дата: {calendar1.SelectedDate}";
        }
        private void VystavkaKaktus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void VystavkaKaktus_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
        }
        private void ListKaktus_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
        }
        private async void AllKaktus_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var kaktus = (Kaktus)AllKaktus.SelectedItem;
            var tempcollection = new Collection() { Id_Vystavka = _vystavka.Id_Vystavka, Id_Kaktus = kaktus.Id_kaktus };
            var check = ConnectionDB.db.Collection.FirstOrDefault(x => x.Id_Kaktus == tempcollection.Id_Kaktus && x.Id_Vystavka == tempcollection.Id_Vystavka);
            if (check == null)
            {
                ConnectionDB.db.Collection.Add(tempcollection);
                ConnectionDB.db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Кактус уже есть в коллекции");
                return;
            }
            string connectionStr = "Server=(localdb)\\Local;Database=WPFKOURS1;Trusted_Connection=True";
            string sqlExpression = $"select Id_Kaktus from Collection where Id_Vystavka = {_vystavka.Id_Vystavka}";
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                await connection.OpenAsync();
                using (SqlCommand command = new SqlCommand(sqlExpression, connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int a = 0;
                            int idKaktus = reader.GetInt32(a);
                            var temp = ConnectionDB.db.Kaktus.FirstOrDefault(x => x.Id_kaktus == idKaktus);
                            var check1 = kaktuses.Find(x => x.Id_kaktus == temp.Id_kaktus);
                            if (check1 == null)
                            {
                                kaktuses.Add(temp);
                                VystavkaKaktus.ItemsSource = kaktuses;
                                a++;
                            }
                            else
                            {
                                return;
                            }
                            VystavkaKaktus.ItemsSource = kaktuses;
                        }
                    }
                }
                VystavkaKaktus.ItemsSource = kaktuses;
            }
            VystavkaKaktus.ItemsSource = kaktuses;
        }
        private void Page_Initialized(object sender, EventArgs e)
        {
        }
    }
}
