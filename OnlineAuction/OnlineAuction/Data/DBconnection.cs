using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineAuction.Data
{
    public class DBconnection
    {
        SqlConnection connetion = new SqlConnection("Server=localhost;Database=OnlineAuction;Trusted_Connection=True;MultipleActiveResultSets=true");

        public SqlConnection GetConnection()
        {
            return connetion;
        }

        public void openConnection()
        {
            if (connetion.State == System.Data.ConnectionState.Closed)
                connetion.Open();

        }

        public void closeConnection()
        {
            if (connetion.State == System.Data.ConnectionState.Open)
                connetion.Close();

        }
    }
}