using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataBase
{
    public class DataBaseJobs
    {
        string connection = @"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True";
        public void Usersregistration(string login,string password)
        {
            using(SqlConnection sql = new SqlConnection(connection))
            {
                string x =string.Format(@"INSERT INTO Users(Login,Password) VALUES ('{0}','{1}')",login,password);
                sql.Open();
                SqlCommand zapros = new SqlCommand();
                zapros.Connection = sql;
                zapros.CommandText = x;
                zapros.ExecuteNonQuery();
            }
        }
        public bool UsersAutoriseishen(string login,string passwrod)
        {
            using(SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                string x = string.Format("SELECT Users.Login,Users.Password FROM Users"
+" WHERE Users.Login='{0}' AND Users.Password='{1}'",login,passwrod);
                SqlCommand zapros = new SqlCommand(x,sql);
                SqlDataReader h = zapros.ExecuteReader();
                int count =0;
                while (h.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    return true;
                }
                else return false;
            }
        }


    }
}
