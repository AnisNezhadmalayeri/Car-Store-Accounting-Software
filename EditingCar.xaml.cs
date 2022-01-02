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
    /// Interaction logic for EditingCar.xaml
    /// </summary>
    public partial class EditingCar : Window
    {
        public EditingCar()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlCommand comm1 = new SqlCommand("Select Name FROM Cars WHERE [Id] ='" + DA.GoodsDA.EditItem + "' ", SqlServer.con);
            SqlServer.openConnection();
            string Name = comm1.ExecuteScalar().ToString();
            SqlServer.closeConnection();

            SqlCommand comm2 = new SqlCommand("Select Color FROM Cars WHERE [Id] ='" + DA.GoodsDA.EditItem + "' ", SqlServer.con);
            SqlServer.openConnection();
            string Color = comm2.ExecuteScalar().ToString();
            SqlServer.closeConnection();

            SqlCommand comm3 = new SqlCommand("Select Model FROM Cars WHERE [Id] ='" + DA.GoodsDA.EditItem + "' ", SqlServer.con);
            SqlServer.openConnection();
            string Model = comm3.ExecuteScalar().ToString();
            SqlServer.closeConnection();

            SqlCommand comm4 = new SqlCommand("Select Cost FROM Cars WHERE [Id] ='" + DA.GoodsDA.EditItem + "' ", SqlServer.con);
            SqlServer.openConnection();
            string Cost = comm4.ExecuteScalar().ToString();
            SqlServer.closeConnection();

            name1.Text = Name;
            color.Text = Color;
            model.Text = Model;
            price.Text = Cost;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DA.GoodsDA.UpdateGood(DA.GoodsDA.EditItem, name1.Text, color.Text, model.Text, price.Text);
            this.Close();
            DA.GoodsDA.EditItem = 0;
        }
    }
}
