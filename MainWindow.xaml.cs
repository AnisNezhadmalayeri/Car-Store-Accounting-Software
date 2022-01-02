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

namespace CarsStore
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new StoreMaterial();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frame.Content = new Reports();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            frame.Content = new Check();
        }

        private void Button_Clickk(object sender, RoutedEventArgs e)
        {
            frame.Content = new Cars();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
