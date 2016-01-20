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
        string connection = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True";
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
        public void SaveText(string path,string id,string title)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                string x = string.Format(@"INSERT INTO Texts(Text,id_subject,titles) VALUES ('{0}',{1},'{2}')", path, id,title);
                sql.Open();
                SqlCommand zapros = new SqlCommand();
                zapros.Connection = sql;
                zapros.CommandText = x;
                zapros.ExecuteNonQuery();
            }
        }
        public bool Option(string str)
        {
            using (SqlConnection db = new SqlConnection(connection))
            {
                db.Open();
                string x = string.Format("SELECT Options.[Option] FROM Questions,Options"
+" WHERE Questions.id_option = Options.id_options AND Questions.Question LIKE '{0}'",str);
                SqlCommand a = new SqlCommand(x, db);
                if ((string)a.ExecuteScalar() == "Один ответ                                                                                          ")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public List<string> Otvet(string str)
        {
            List<string> one = new List<string>();
            using (SqlConnection db = new SqlConnection(connection))
            {
                db.Open();
                string x = string.Format("SELECT Answers.Answer FROM Questions,Answers,Texts,Tests "
+ " WHERE Answers.id_question = Questions.id_question AND Texts.id_text = Tests.id_texts AND Questions.id_test = Tests.id_test AND Questions.Question LIKE '{0}'", str);
                SqlCommand a = new SqlCommand(x, db);
                SqlDataReader rd = a.ExecuteReader();

                while (rd.Read())
                {
                    one.Add(rd["Answer"].ToString());
                    
                }
           }
            return one;
        }
        public bool PravOtvet(string one, string two)
        {
                SqlConnection db = new SqlConnection(connection);
            
                db.Open();
                string x = string.Format("SELECT Answers.[right] FROM Answers,Questions"
+ " WHERE Questions.id_question = Questions.id_question AND Answers.Answer LIKE '{0}' AND Questions.Question LIKE '{1}'", one, two);
                SqlCommand a = new SqlCommand(x, db);
                return (bool) a.ExecuteScalar();
                db.Close();
                 
                
            
        }
        public DataTable SelectOtvet()
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                DataTable table = new DataTable();
                sql.Open();
                string zapros = string.Format("SELECT Answers.Answer,Questions.Question,Options.[Option],Answers.[right],Texts.titles FROM Answers,Questions,Texts,Options,Tests"
 +" WHERE Questions.id_question = Answers.id_question  AND Options.id_options = Questions.id_option AND Questions.id_test = Tests.id_test AND Texts.id_text = Tests.id_texts");
                SqlCommand a = new SqlCommand(zapros, sql);
                SqlDataReader z = a.ExecuteReader();
                table.Load(z);
                z.Close();
                return table;
            }
        }

         public int SelName(string name)
        {
                SqlConnection db = new SqlConnection(connection);
            
                db.Open();
                string x = string.Format("SELECT Users.id_users  FROM Users"
+" WHERE Users.Login = '{0}'", name);
                SqlCommand a = new SqlCommand(x, db);
                return (int) a.ExecuteScalar();
                db.Close();
        }
         public int SelTs(int name)
         {
             SqlConnection db = new SqlConnection(connection);

             db.Open();
             string x = string.Format("SELECT Tests.id_test FROM Tests,Texts "
+" WHERE Texts.id_text = Tests.id_texts AND Texts.id_text = {0}", name);
             SqlCommand a = new SqlCommand(x, db);
             return (int)a.ExecuteScalar();
             db.Close();
         }
         public void SaveResult(int result, int idUser,int idText, DateTime time)
         {
             using (SqlConnection sql = new SqlConnection(connection))
             {
                 sql.Open();
                 string x = string.Format(@"INSERT INTO Results(Result,id_users,id_test,DateAndTime) VALUES ('{0}','{1}','{2}','{3}')", result, idUser, idText, time);
                 SqlCommand zapros = new SqlCommand();
                 zapros.Connection = sql;
                 zapros.CommandText = x;
                 zapros.ExecuteNonQuery();
             }
         }

    }
}
