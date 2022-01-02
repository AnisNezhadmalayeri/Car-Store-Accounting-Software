using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;
using CarsStore.Domain;

namespace CarsStore.DA
{
    public class GoodsDA
    {
        public static int EditItem;
        public static void StoreMaterials(string name,string color,string model,long cost)
        {
            Goods goods = new Goods();
            goods.Name = name;
            goods.Color = color;
            goods.Model = model;
            goods.Cost = cost;
            string Query = "INSERT INTO Cars(Name,Color,Model,Cost) VALUES ('" + goods.Name+"','"+ goods.Color+"','"+ goods.Model+"','"+ goods.Cost+"')";
            SqlServer.openConnection();
            SqlCommand com = new SqlCommand(Query, SqlServer.con);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            SqlServer.closeConnection();
        }
        public static void UpdateGood(int ID, string Name, string Color, string Model, string Cost)
        {
            string Query = "UPDATE Cars SET Name='" + Name + "' , Color='" + Color + "' , Model='" + Model + "' , Cost='" + Cost + "'  WHERE Id ='" + ID + "' ;";
            SqlServer.openConnection();
            SqlCommand com = new SqlCommand(Query, SqlServer.con);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            SqlServer.closeConnection();
        }
    }
}
