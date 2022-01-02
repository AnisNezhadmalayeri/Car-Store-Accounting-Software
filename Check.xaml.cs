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
using System.Data;
using System.Data.SqlClient;


namespace CarsStore
{
    /// <summary>
    /// Interaction logic for Check.xaml
    /// </summary>
    public partial class Check : Page
    {
        public Check()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SqlServer.openConnection();
            SqlServer.sql = "SELECT * FROM Checks";
            SqlServer.cmd.CommandType = CommandType.Text;
            SqlServer.cmd.CommandText = SqlServer.sql;
            SqlServer.da = new SqlDataAdapter(SqlServer.cmd);
            SqlServer.dt = new DataTable();
            SqlServer.da.Fill(SqlServer.dt);
            DataGrid.ItemsSource = SqlServer.dt.DefaultView;
            SqlServer.closeConnection();
        }
        //refresh
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlServer.openConnection();
            SqlServer.sql = "SELECT * FROM Checks";
            SqlServer.cmd.CommandType = CommandType.Text;
            SqlServer.cmd.CommandText = SqlServer.sql;
            SqlServer.da = new SqlDataAdapter(SqlServer.cmd);
            SqlServer.dt = new DataTable();
            SqlServer.da.Fill(SqlServer.dt);
            DataGrid.ItemsSource = SqlServer.dt.DefaultView;
            SqlServer.closeConnection();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ChecksDelete checksDelete = new ChecksDelete();
            checksDelete.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ChecksEdit checksEdit = new ChecksEdit();
            checksEdit.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddChecks addChecks = new AddChecks();
            addChecks.Show();
        }
    }
}
