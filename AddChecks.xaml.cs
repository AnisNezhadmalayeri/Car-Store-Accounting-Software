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
    /// Interaction logic for AddChecks.xaml
    /// </summary>
    public partial class AddChecks : Window
    {
        public AddChecks()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DA.ChecksDA.StoreCheck(date.Text, count.Text, name.Text);
            this.Close();
        }
    }
}
