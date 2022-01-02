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
    /// Interaction logic for CarsDelete.xaml
    /// </summary>
    public partial class CarsDelete : Window
    {
        public CarsDelete()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DI.Text != "")
            {
                string Query = "DELETE FROM Cars WHERE Id ='" + DI.Text + "' ";
                SqlServer.openConnection();
                SqlCommand com = new SqlCommand(Query, SqlServer.con);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                SqlServer.closeConnection();

                this.Close();
            }
        }
    }
}
