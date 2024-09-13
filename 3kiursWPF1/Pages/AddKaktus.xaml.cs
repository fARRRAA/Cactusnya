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
namespace _3kiursWPF1.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddKaktus.xaml
    /// </summary>
    public partial class AddKaktus : Window
    {
        private ListView _listKaktus;
        public AddKaktus(ListView lw)
        {
            InitializeComponent();
            _listKaktus = lw;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var name = NameKaktus.Text;
            var type = Convert.ToInt32(TypeKaktus.Text);
            var age = Convert.ToInt32(AgeKaktus.Text);
            var otkuda = OtkudaKaktus.Text;
            var price = Convert.ToInt32(PriceKaktus.Text);
            var info = InfoKaktus.Text;
            var tempKaktus = new Kaktus()
            {
                Id_Type = type,
                Otkuda = otkuda,
                Age = age,
                Price = price,
                Uhod = info,
                Name = name
            };
            ConnectionDB.db.Kaktus.Add(tempKaktus);
            ConnectionDB.db.SaveChanges();
            MessageBox.Show("Кактус добавился");
            _listKaktus.ItemsSource = ConnectionDB.db.Kaktus.ToList();
            this.DialogResult = true;
            
        }
    }
}
