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

    public class ChecksDA
    {
        public static int EditItemCheck;
        public static void StoreCheck(string Date, string Count, string OwnerName)
        {
            Checks checks = new Checks();
            checks.Date = Date;
            checks.Count = Count;
            checks.OwnerName = OwnerName;
            string Query = "INSERT INTO Checks(Date,Count,OwnerName) VALUES ('" + checks.Date + "','" + checks.Count + "','" + checks.OwnerName + "')";
            SqlServer.openConnection();
            SqlCommand com = new SqlCommand(Query, SqlServer.con);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            SqlServer.closeConnection();
        }
        public static void UpdateCheck(int ID, string Date, string Count, string OwnerName)
        {
            string Query = "UPDATE Checks SET Date='" + Date + "' , Count='" + Count + "' , OwnerName='" + OwnerName + "'  WHERE Id ='" + ID + "' ;";
            SqlServer.openConnection();
            SqlCommand com = new SqlCommand(Query, SqlServer.con);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            SqlServer.closeConnection();
        }

    }
}
