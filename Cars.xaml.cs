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
    /// Interaction logic for Cars.xaml
    /// </summary>
    public partial class Cars : Page
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SqlServer.openConnection();
            SqlServer.sql = "SELECT * FROM Cars";
            SqlServer.cmd.CommandType = CommandType.Text;
            SqlServer.cmd.CommandText = SqlServer.sql;
            SqlServer.da = new SqlDataAdapter(SqlServer.cmd);
            SqlServer.dt = new DataTable();
            SqlServer.da.Fill(SqlServer.dt);
            DataGrid.ItemsSource = SqlServer.dt.DefaultView;
            SqlServer.closeConnection();
        }
        //search
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (name1.Text != "")
            {
                SqlServer.openConnection();
                SqlServer.sql = "SELECT * FROM Cars WHERE Name='" + name1.Text + "' OR Color='" + name1.Text + "' OR Model='" + name1.Text + "' OR Cost='" + name1.Text + "' ";
                SqlServer.cmd.CommandType = CommandType.Text;
                SqlServer.cmd.CommandText = SqlServer.sql;
                SqlServer.da = new SqlDataAdapter(SqlServer.cmd);
                SqlServer.dt = new DataTable();
                SqlServer.da.Fill(SqlServer.dt);
                DataGrid.ItemsSource = SqlServer.dt.DefaultView;
                SqlServer.closeConnection();
            }
        }
        //edit
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CarsEdit carsEdit = new CarsEdit();
            carsEdit.Show();
        }
        //refresh
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlServer.openConnection();
            SqlServer.sql = "SELECT * FROM Cars";
            SqlServer.cmd.CommandType = CommandType.Text;
            SqlServer.cmd.CommandText = SqlServer.sql;
            SqlServer.da = new SqlDataAdapter(SqlServer.cmd);
            SqlServer.dt = new DataTable();
            SqlServer.da.Fill(SqlServer.dt);
            DataGrid.ItemsSource = SqlServer.dt.DefaultView;
            SqlServer.closeConnection();
        }
        //delete
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CarsDelete carsDelete = new CarsDelete();
            carsDelete.Show();
        }
    }
}
