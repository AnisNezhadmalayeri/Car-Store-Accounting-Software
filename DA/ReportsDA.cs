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
    public class ReportsDA
    {
        public static int EditItemReport;
        public static void StoreReport(string Date, string Count, string Status, string Explnation)
        {
            Domain.Reports reports = new Domain.Reports();
            reports.Date = Date;
            reports.Count = Count;
            reports.Status = Status;
            reports.Explnation = Explnation;
            string Query = "INSERT INTO Reports(Date,Count,Status,Explnation) VALUES ('" + reports.Date + "','" + reports.Count + "','" + reports.Status + "','" + reports.Explnation + "')";
            SqlServer.openConnection();
            SqlCommand com = new SqlCommand(Query, SqlServer.con);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            SqlServer.closeConnection();
        }
        public static void UpdateReport(int ID, string Date, string Count, string Status, string Explnation)
        {
            string Query = "UPDATE Reports SET Date='" + Date + "' , Count='" + Count + "' , Status='" + Status + "', Explnation='" + Explnation + "'  WHERE Id ='" + ID + "' ;";
            SqlServer.openConnection();
            SqlCommand com = new SqlCommand(Query, SqlServer.con);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            SqlServer.closeConnection();
        }


    }
}
