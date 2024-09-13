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
using _3kiursWPF1.Pages;

namespace _3kiursWPF1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationService.Navigate(new LognPage(this));

        }

        private void ButtonAuth_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.NavigationService.Navigate(new AuthPage(this));
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.NavigationService.Navigate(new LognPage(this));
        }
    }
}
