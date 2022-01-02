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
    /// Interaction logic for AddReports.xaml
    /// </summary>
    public partial class AddReports : Window
    {
        public AddReports()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DA.ReportsDA.StoreReport(date.Text, count.Text, status.Text, ex.Text);
            this.Close();
        }
    }
}
