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
    /// Логика взаимодействия для VystavkaAdd.xaml
    /// </summary>
    public partial class VystavkaAdd : Window
    {
        private ListView _vystlist;
        public VystavkaAdd(ListView vystlist)
        {
            _vystlist = vystlist;
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var mesto = MestoVyst.Text;
            var date = calendar1.SelectedDate;
            if (date == null)
            {
                MessageBox.Show("выберите дату");

            }
            else
            {
                var temp = new Vystavka() { Date = (DateTime)date, Mesto = mesto };
                ConnectionDB.db.Vystavka.Add(temp);
                ConnectionDB.db.SaveChanges();
                MessageBox.Show("Выставка успешно создана");
                _vystlist.ItemsSource = ConnectionDB.db.Vystavka.ToList();
                this.DialogResult = true;
            }

        }

        private void calendar1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateText.Text = $"Дата: {calendar1.SelectedDate}";
        }
    }
}
