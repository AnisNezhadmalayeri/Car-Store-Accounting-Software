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
using System.Data;
using System.Data.SqlClient;

namespace CarsStore
{
    /// <summary>
    /// Interaction logic for EditingReports.xaml
    /// </summary>
    public partial class EditingReports : Window
    {
        public EditingReports()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlCommand comm1 = new SqlCommand("Select Date FROM Reports WHERE [Id] ='" + DA.ReportsDA.EditItemReport + "' ", SqlServer.con);
            SqlServer.openConnection();
            string Date = comm1.ExecuteScalar().ToString();
            SqlServer.closeConnection();

            SqlCommand comm2 = new SqlCommand("Select Count FROM Reports WHERE [Id] ='" + DA.ReportsDA.EditItemReport + "' ", SqlServer.con);
            SqlServer.openConnection();
            string Count = comm2.ExecuteScalar().ToString();
            SqlServer.closeConnection();

            SqlCommand comm3 = new SqlCommand("Select Status FROM Reports WHERE [Id] ='" + DA.ReportsDA.EditItemReport + "' ", SqlServer.con);
            SqlServer.openConnection();
            string Status = comm3.ExecuteScalar().ToString();
            SqlServer.closeConnection();

            SqlCommand comm4 = new SqlCommand("Select Explnation FROM Reports WHERE [Id] ='" + DA.ReportsDA.EditItemReport + "' ", SqlServer.con);
            SqlServer.openConnection();
            string Explnation = comm4.ExecuteScalar().ToString();
            SqlServer.closeConnection();

            date.Text = Date;
            count.Text = Count;
            status.Text = Status;
            ex.Text = Explnation;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DA.ReportsDA.UpdateReport(DA.ReportsDA.EditItemReport, date.Text, count.Text, status.Text, ex.Text);
            this.Close();
            DA.ReportsDA.EditItemReport = 0;
        }
    }
}
