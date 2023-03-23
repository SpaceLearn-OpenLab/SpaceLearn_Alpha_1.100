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

namespace SpaceLearn_demo
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
        public void Image()
        {
           
        }
        private void arrow_Click(object sender, RoutedEventArgs e)
        {
            grid02.Visibility = Visibility.Collapsed;

            newMenu.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grid02.Visibility = Visibility.Visible;

            newMenu.Visibility = Visibility.Collapsed;
        }



        //private void Quiz_window(object sender, RoutedEventArgs e)
        //{
        //    Uri uri = new Uri("Page1.xaml", UriKind.Relative);
        //    this.NavigationService.Navigate(uri);
        //}
    }
}
