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

namespace _3kiursWPF1.Pages
{
    /// <summary>
    /// Логика взаимодействия для RedactKaktus.xaml
    /// </summary>
    public partial class RedactKaktus : Window
    {
        private Kaktus _kaktus;
        private ListView _listKaktus;
        public RedactKaktus(Kaktus kaktus,ListView KaktusList)
        {
            _kaktus = kaktus;
            _listKaktus = KaktusList;
            InitializeComponent();
            NameKaktus.Text = _kaktus.Name;
            TypeKaktus.Text = Convert.ToString(_kaktus.Id_Type);
            PriceKaktus.Text = Convert.ToString(_kaktus.Price);
            AgeKaktus.Text= Convert.ToString(_kaktus.Age);
            OtkudaKaktus.Text = _kaktus.Otkuda;
            InfoKaktus.Text = _kaktus.Uhod;

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var oldKaktus = ConnectionDB.db.Kaktus.FirstOrDefault(k => k.Id_kaktus == _kaktus.Id_kaktus);
            
            if(oldKaktus != null)
            {
                var name = NameKaktus.Text;
                var type = Convert.ToInt32(TypeKaktus.Text);
                var age = Convert.ToInt32(AgeKaktus.Text);
                var otkuda = OtkudaKaktus.Text;
                var price = Convert.ToInt32(PriceKaktus.Text);
                var info = InfoKaktus.Text;
                var Type = ConnectionDB.db.Type.FirstOrDefault(t => t.Id_Type == type);
                oldKaktus.Name = name;
                oldKaktus.Type = Type;
                oldKaktus.Age = age;
                oldKaktus.Price = price;
                oldKaktus.Otkuda = otkuda;
                oldKaktus.Uhod = info;
                ConnectionDB.db.SaveChanges();
                MessageBox.Show("Редактирование прошло успешно");
                _listKaktus.ItemsSource = ConnectionDB.db.Kaktus.ToList();
                this.DialogResult = true;
            }
        }

        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            var oldKaktus = ConnectionDB.db.Kaktus.FirstOrDefault(k => k.Id_kaktus == _kaktus.Id_kaktus);

            if (oldKaktus != null)
            {
                ConnectionDB.db.Kaktus.Remove(oldKaktus);
                ConnectionDB.db.SaveChanges();
                MessageBox.Show("Удаление прошло успешно");
                _listKaktus.ItemsSource = ConnectionDB.db.Kaktus.ToList();
                this.DialogResult = true;
            }
        }
    }
}
