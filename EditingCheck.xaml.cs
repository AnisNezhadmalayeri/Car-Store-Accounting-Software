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
    /// Interaction logic for EditingCheck.xaml
    /// </summary>
    public partial class EditingCheck : Window
    {
        public EditingCheck()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DA.ChecksDA.UpdateCheck(DA.ChecksDA.EditItemCheck, date.Text, count.Text, name.Text);
            this.Close();
            DA.ChecksDA.EditItemCheck = 0;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlCommand comm1 = new SqlCommand("Select Date FROM Checks WHERE [Id] ='" + DA.ChecksDA.EditItemCheck + "' ", SqlServer.con);
            SqlServer.openConnection();
            string Date = comm1.ExecuteScalar().ToString();
            SqlServer.closeConnection();

            SqlCommand comm2 = new SqlCommand("Select Count FROM Checks WHERE [Id] ='" + DA.ChecksDA.EditItemCheck + "' ", SqlServer.con);
            SqlServer.openConnection();
            string Count = comm2.ExecuteScalar().ToString();
            SqlServer.closeConnection();

            SqlCommand comm3 = new SqlCommand("Select OwnerName FROM Checks WHERE [Id] ='" + DA.ChecksDA.EditItemCheck + "' ", SqlServer.con);
            SqlServer.openConnection();
            string OwnerName = comm3.ExecuteScalar().ToString();
            SqlServer.closeConnection();

            date.Text = Date;
            count.Text = Count;
            name.Text = OwnerName;
        }
    }
}
