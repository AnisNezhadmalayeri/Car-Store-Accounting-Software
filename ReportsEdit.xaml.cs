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
    /// Interaction logic for ReportsEdit.xaml
    /// </summary>
    public partial class ReportsEdit : Window
    {
        public ReportsEdit()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DA.ReportsDA.EditItemReport = Convert.ToInt32(text.Text);
            EditingReports editingReports = new EditingReports();
            this.Close();
            editingReports.Show();
        }
    }
}
