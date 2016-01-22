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
        public void Usersregistration(string login, string password)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                string x = string.Format(@"INSERT INTO Users(Login,Password) VALUES ('{0}','{1}')", login, password);
                sql.Open();
                SqlCommand zapros = new SqlCommand();
                zapros.Connection = sql;
                zapros.CommandText = x;
                zapros.ExecuteNonQuery();
            }
        }
        public bool UsersAutoriseishen(string login, string passwrod)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                string x = string.Format("SELECT Users.Login,Users.Password FROM Users"
+ " WHERE Users.Login='{0}' AND Users.Password='{1}'", login, passwrod);
                SqlCommand zapros = new SqlCommand(x, sql);
                SqlDataReader h = zapros.ExecuteReader();
                int count = 0;
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
                string zapros = string.Format("SELECT Sections.id_section,Sections.Section,Subjects.Subject,Subjects.id_subject FROM Sections,Subjects"
+ " WHERE Sections.id_section = Subjects.id_section");
                SqlCommand a = new SqlCommand(zapros, sql);
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
        public void AddTema(string add, string add2)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                string x = string.Format(@"INSERT INTO Subjects(Subject,id_section) VALUES ('{0}','{1}')", add, add2);
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
                string zapros = string.Format("SELECT Sections.Section,Subjects.Subject,Texts.Text,Texts.id_text,Subjects.id_subject  FROM Texts,Subjects,Sections"
+ " WHERE Sections.id_section = Subjects.id_section AND Subjects.id_subject = Texts.id_subject");
                SqlCommand a = new SqlCommand(zapros, sql);
                SqlDataReader z = a.ExecuteReader();
                table.Load(z);
                z.Close();
                return table;
            }
        }
        public void SaveText(string path, string id, string title)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                string x = string.Format(@"INSERT INTO Texts(Text,id_subject,titles) VALUES ('{0}',{1},'{2}')", path, id, title);
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
+ " WHERE Questions.id_option = Options.id_options AND Questions.Question LIKE '{0}'", str);
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
            return (bool)a.ExecuteScalar();
            db.Close();



        }
        public DataTable SelectOtvet()
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                DataTable table = new DataTable();
                sql.Open();
                string zapros = string.Format("SELECT Answers.Answer,Questions.Question,Options.[Option],Answers.[right],Texts.titles FROM Answers,Questions,Texts,Options,Tests"
 + " WHERE Questions.id_question = Answers.id_question  AND Options.id_options = Questions.id_option AND Questions.id_test = Tests.id_test AND Texts.id_text = Tests.id_texts");
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
+ " WHERE Users.Login = '{0}'", name);
            SqlCommand a = new SqlCommand(x, db);
            return (int)a.ExecuteScalar();
            db.Close();
        }
        public int SelTs(int name)
        {
            SqlConnection db = new SqlConnection(connection);

            db.Open();
            string x = string.Format("SELECT Tests.id_test FROM Tests,Texts "
+ " WHERE Texts.id_text = Tests.id_texts AND Texts.id_text = {0}", name);
            SqlCommand a = new SqlCommand(x, db);
            return (int)a.ExecuteScalar();
            db.Close();
        }
        public void SaveResult(int result, int idUser, int idText, DateTime time)
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
        public DataSet SelectRazdel()
        {
            SqlConnection db = new SqlConnection(connection);
            string command = "SELECT Sections.Section,Sections.id_section  FROM Sections";
            SqlDataAdapter da = new SqlDataAdapter(command, connection);
            DataSet ds = new DataSet();
            db.Open();
            da.Fill(ds);
            db.Close();
            return ds;
        }
        public DataSet SelectTem(string id)
        {
            SqlConnection db = new SqlConnection(connection);
            string command = string.Format("SELECT Subjects.Subject ,Subjects.id_subject FROM Sections,Subjects "
+ " WHERE Sections.id_section = Subjects.id_section AND Sections.Section = '{0}'", id);
            SqlDataAdapter da = new SqlDataAdapter(command, connection);
            DataSet ds = new DataSet();
            db.Open();
            da.Fill(ds);
            db.Close();
            return ds;
        }
        public DataSet SelectText(string id)
        {
            SqlConnection db = new SqlConnection(connection);
            string command = string.Format("SELECT Texts.id_text,Texts.titles FROM Texts,Subjects,Sections,Tests"
+ " WHERE Subjects.id_subject = Texts.id_subject AND Texts.id_text = Tests.id_texts AND Sections.id_section = Subjects.id_section AND Subjects.Subject = '{0}'", id);
            SqlDataAdapter da = new SqlDataAdapter(command, connection);
            DataSet ds = new DataSet();
            db.Open();
            da.Fill(ds);
            db.Close();
            return ds;
        }
        public DataSet SelectQuestion(string id)
        {
            SqlConnection db = new SqlConnection(connection);
            string command = string.Format("SELECT Questions.Question,Questions.id_question FROM Texts,Tests,Questions"
+ " WHERE Tests.id_test = Questions.id_test AND Tests.id_texts = Texts.id_text AND Texts.titles = '{0}'", id);
            SqlDataAdapter da = new SqlDataAdapter(command, connection);
            DataSet ds = new DataSet();
            db.Open();
            da.Fill(ds);
            db.Close();
            return ds;
        }
        public bool OptionsDD(string id)
        {
            SqlConnection db = new SqlConnection(connection);
            db.Open();
            string command = string.Format("SELECT Options.[Option] FROM Texts,Tests,Questions,Options"
+ " WHERE Questions.id_option = Options.id_options AND Tests.id_test = Questions.id_test AND Texts.id_text = Tests.id_texts AND Questions.Question Like '{0}'", id);
            SqlCommand a = new SqlCommand(command, db);
            if ((string)a.ExecuteScalar() == "Один ответ                                                                                          ")
            {
                return true;
            }
            else
            {
                return false;
            }
            db.Close();
        }
        public void SaveQuestion(string path, int id, int title)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                string x = string.Format(@"INSERT INTO Questions(Question,id_test,id_option) VALUES ('{0}',{1},{2})", path, id, title);
                sql.Open();
                SqlCommand zapros = new SqlCommand();
                zapros.Connection = sql;
                zapros.CommandText = x;
                zapros.ExecuteNonQuery();
            }
        }
        public int IDTest(string id)
        {
            SqlConnection db = new SqlConnection(connection);
            db.Open();
            string command = string.Format("SELECT Tests.id_test  FROM Tests,Texts "
+ " WHERE Texts.id_text = Tests.id_texts AND Texts.titles = '{0}'", id);
            SqlCommand a = new SqlCommand(command, db);
            return (int)a.ExecuteScalar();
        }
        public void SaveOtvet(string path, int id, int title)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                string x = string.Format(@"INSERT INTO Answers(Answer,id_question,[right]) VALUES ('{0}',{1},{2})", path, id, title);
                sql.Open();
                SqlCommand zapros = new SqlCommand();
                zapros.Connection = sql;
                zapros.CommandText = x;
                zapros.ExecuteNonQuery();
            }
        }
        public string IDQuestion(string id)
        {
            SqlConnection db = new SqlConnection(connection);
            db.Open();
            string command = string.Format("SELECT Questions.id_question  FROM Questions"
+ " WHERE Questions.Question LIKE '{0}'", id);
            SqlCommand a = new SqlCommand(command, db);
            return a.ExecuteScalar().ToString();
        }
        public DataSet SelectTextFULL(string id)
        {
            SqlConnection db = new SqlConnection(connection);
            string command = string.Format("SELECT Texts.id_text,Texts.titles FROM Texts,Subjects,Sections"
+ " WHERE Subjects.id_subject = Texts.id_subject AND Sections.id_section = Subjects.id_section AND Subjects.Subject = '{0}'", id);
            SqlDataAdapter da = new SqlDataAdapter(command, connection);
            DataSet ds = new DataSet();
            db.Open();
            da.Fill(ds);
            db.Close();
            return ds;
        }
        public void AddTest(int path)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                string x = string.Format("INSERT INTO Tests(id_texts) VALUES({0})", path);
                sql.Open();
                SqlCommand zapros = new SqlCommand();
                zapros.Connection = sql;
                zapros.CommandText = x;
                zapros.ExecuteNonQuery();
            }
        }
        public int IDText(string id)
        {
            SqlConnection db = new SqlConnection(connection);
            db.Open();
            string command = string.Format("SELECT Texts.id_text  FROM Texts "
+ " WHERE Texts.titles = '{0}'", id);
            SqlCommand a = new SqlCommand(command, db);
            return (int)a.ExecuteScalar();
        }
        public bool QuestionSoc(string txt)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                string x = string.Format("SELECT Questions.Question,Questions.id_question FROM Texts,Tests,Questions"
+ " WHERE Tests.id_test = Questions.id_test AND Tests.id_texts = Texts.id_text AND Texts.titles = '{0}'", txt);
                SqlCommand zapros = new SqlCommand(x, sql);
                SqlDataReader h = zapros.ExecuteReader();
                int count = 0;
                while (h.Read())
                {
                    count++;
                }
                if (count >= 10)
                {
                    return true;
                }
                else return false;
            }
        }
        public bool OtvetSoc(string txt)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                string x = string.Format("SELECT Answers.Answer  FROM Answers,Questions"
+ " WHERE Questions.id_question = Answers.id_question AND Questions.Question LIKE '{0}'", txt);
                SqlCommand zapros = new SqlCommand(x, sql);
                SqlDataReader h = zapros.ExecuteReader();
                int count = 0;
                while (h.Read())
                {
                    count++;
                }
                if (count >= 4)
                {
                    return true;
                }
                else return false;
            }
        }
        public bool OtvetSocTwo(string txt)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                string x = string.Format("SELECT Answers.Answer  FROM Answers,Questions,Texts,Tests"
+ " WHERE Questions.id_question = Answers.id_question AND Questions.id_test = Tests.id_test AND Texts.id_text = Tests.id_texts AND Texts.Text = '{0}'", txt);
                SqlCommand zapros = new SqlCommand(x, sql);
                SqlDataReader h = zapros.ExecuteReader();
                int count = 0;
                while (h.Read())
                {
                    count++;
                }
                if (count < 40)
                {
                    return true;
                }
                else return false;
            }
        }
        public bool QuestionSocTwo(string txt)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                string x = string.Format("SELECT Questions.Question,Questions.id_question FROM Texts,Tests,Questions"
+ " WHERE Tests.id_test = Questions.id_test AND Tests.id_texts = Texts.id_text AND Texts.Text = '{0}'", txt);
                SqlCommand zapros = new SqlCommand(x, sql);
                SqlDataReader h = zapros.ExecuteReader();
                int count = 0;
                while (h.Read())
                {
                    count++;
                }
                if (count < 10)
                {
                    return true;
                }
                else return false;
            }
        }
        public DataTable ResulUsersAll()
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                DataTable table = new DataTable();
                sql.Open();
                string zapros = string.Format("SELECT Users.Login,Results.Result,Texts.titles,Results.DateAndTime FROM Users,Results,Tests,Texts"
+" WHERE Results.id_users = Users.id_users AND Results.id_test = Tests.id_test AND Tests.id_texts = Texts.id_text");
                SqlCommand a = new SqlCommand(zapros, sql);
                SqlDataReader z = a.ExecuteReader();
                table.Load(z);
                z.Close();
                return table;
            }
        }
        public DataTable ResulUsers(string name)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                DataTable table = new DataTable();
                sql.Open();
                string zapros = string.Format("SELECT Users.Login,Results.Result,Texts.titles,Results.DateAndTime FROM Users,Results,Tests,Texts"
+" WHERE Results.id_users = Users.id_users AND Results.id_test = Tests.id_test AND Tests.id_texts = Texts.id_text AND Users.Login = '{0}'",name);
                SqlCommand a = new SqlCommand(zapros, sql);
                SqlDataReader z = a.ExecuteReader();
                table.Load(z);
                z.Close();
                return table;
            }
        }
        public DataTable SelectQuestionall()
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                DataTable table = new DataTable();
                sql.Open();
                string zapros = string.Format("SELECT Questions.Question,Options.[Option],Texts.titles,Questions.id_question,Options.id_options,Tests.id_test FROM Questions,Texts,Options,Tests"
+" WHERE Questions.id_option = Options.id_options AND Tests.id_test = Questions.id_test AND Texts.id_text = Tests.id_texts");
                SqlCommand a = new SqlCommand(zapros, sql);
                SqlDataReader z = a.ExecuteReader();
                table.Load(z);
                z.Close();
                return table;
            }
        }
        public DataTable SelectOtvetall()
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                DataTable table = new DataTable();
                sql.Open();
                string zapros = string.Format("SELECT Questions.Question,Answers.Answer,Answers.[right],Answers.id_answer,Questions.id_question  FROM Answers,Questions"
+" WHERE Questions.id_question = Answers.id_question");
                SqlCommand a = new SqlCommand(zapros, sql);
                SqlDataReader z = a.ExecuteReader();
                table.Load(z);
                z.Close();
                return table;
            }
        }
        public bool UsersProverk(string str)
        {
            using (SqlConnection db = new SqlConnection(connection))
            {
                db.Open();
                string x = string.Format("SELECT Users.Login FROM Users where Users.Login = '{0}'",str);
                SqlCommand a = new SqlCommand(x, db);
                if ((string)a.ExecuteScalar() == str)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool RazdelProverk(string str)
        {
            using (SqlConnection db = new SqlConnection(connection))
            {
                db.Open();
                string x = string.Format("SELECT Sections.Section FROM Sections where Sections.Section = '{0}'", str);
                SqlCommand a = new SqlCommand(x, db);
                if ((string)a.ExecuteScalar() == str)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool TemaProverk(string str,string str1)
        {
            using (SqlConnection db = new SqlConnection(connection))
            {
                db.Open();
                string x = string.Format("SELECT Subjects.Subject FROM Sections,Subjects"
+" where Sections.id_section = Subjects.id_section and Subjects.id_section = {0} and Subjects.Subject = '{1}'", str1,str);
                SqlCommand a = new SqlCommand(x, db);
                if ((string)a.ExecuteScalar() == str)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
