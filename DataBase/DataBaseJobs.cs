﻿using System;
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
        public DataTable SelectTemRazdel()
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                DataTable table = new DataTable();
                sql.Open();
                string zapros = string.Format("SELECT Sections.Section,Subjects.Subject FROM Sections,Subjects"
+" WHERE Sections.id_section = Subjects.id_section");
                SqlCommand a = new SqlCommand(zapros,sql);
                SqlDataReader z = a.ExecuteReader();
                table.Load(z);
                z.Close();
                return table;
            }
        }
        public void AddRazdel(string one)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                string x = string.Format(@"INSERT INTO Sections(Section) VALUES ('{0}')", one);
                sql.Open();
                SqlCommand zapros = new SqlCommand();
                zapros.Connection = sql;
                zapros.CommandText = x;
                zapros.ExecuteNonQuery();
            }
        }
        public void AddTema(string add,string add2)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                string x = string.Format(@"INSERT INTO Subjects(Subject,id_section) VALUES ('{0}','{1}')", add,add2);
                sql.Open();
                SqlCommand zapros = new SqlCommand();
                zapros.Connection = sql;
                zapros.CommandText = x;
                zapros.ExecuteNonQuery();
            }
        }
        public DataTable SelectText()
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                DataTable table = new DataTable();
                sql.Open();
                string zapros = string.Format("SELECT Sections.Section,Subjects.Subject,Texts.Text  FROM Texts,Subjects,Sections"
+" WHERE Sections.id_section = Subjects.id_section AND Subjects.id_subject = Texts.id_subject");
                SqlCommand a = new SqlCommand(zapros, sql);
                SqlDataReader z = a.ExecuteReader();
                table.Load(z);
                z.Close();
                return table;
            }
        }

    }
}
