using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace OKP_ZKI
{
    public partial class AdminForm : Telerik.WinControls.UI.RadForm
    {
        DataBase.DataBaseJobs ddd = new DataBase.DataBaseJobs();
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
        public AdminForm()
        {
            InitializeComponent();
        }

        private void radPageViewPage1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnSaveRaz_Click(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            if (db.RazdelProverk(txtRazd.Text))
            {
                MessageBox.Show("Такая запись уже существует!");
            }
            else
            {
                if (txtRazd.Text == "")
                {
                    MessageBox.Show("Не введено некоторое поле!");
                }
                else
                {

                    db.AddRazdel(txtRazd.Text);
                    dataGridView1.DataSource = db.SelectTemRazdel();
                    dataGridView2.DataSource = db.SelectText();
                    comboBox3.DataSource = db.SelectRazdel().Tables[0];
                    comboBox3.ValueMember = "id_section";
                    comboBox3.DisplayMember = "Section";
                    dataGridView1.Refresh();
                    txtRazd.Clear();
                    MessageBox.Show("Добавление осуществилась!");
                }
            }
            
            
            

            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseZKIDataSet2.Texts". При необходимости она может быть перемещена или удалена.
            this.textsTableAdapter1.Fill(this.dataBaseZKIDataSet2.Texts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseZKIDataSet2.Options". При необходимости она может быть перемещена или удалена.
            this.optionsTableAdapter1.Fill(this.dataBaseZKIDataSet2.Options);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseZKIDataSet2.Sections". При необходимости она может быть перемещена или удалена.
            this.sectionsTableAdapter1.Fill(this.dataBaseZKIDataSet2.Sections);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseZKIDataSet1.Options". При необходимости она может быть перемещена или удалена.
            this.optionsTableAdapter.Fill(this.dataBaseZKIDataSet1.Options);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseZKIDataSet.Answers". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseZKIDataSet.Texts". При необходимости она может быть перемещена или удалена.
            this.textsTableAdapter.Fill(this.dataBaseZKIDataSet.Texts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseZKIDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.dataBaseZKIDataSet.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseZKIDataSet.Sections". При необходимости она может быть перемещена или удалена.
            this.sectionsTableAdapter.Fill(this.dataBaseZKIDataSet.Sections);
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            dataGridView1.DataSource = db.SelectTemRazdel();
            
            dataGridView2.DataSource = db.SelectText();
            dataGridView3.DataSource = db.SelectQuestionall();
            dataGridView4.DataSource = db.SelectOtvetall();
            dataGridView1.Columns["id_section"].Visible = false;
            dataGridView1.Columns["id_subject"].Visible = false;
            dataGridView2.Columns["id_text"].Visible = false;
            dataGridView2.Columns["id_subject"].Visible = false;
            dataGridView3.Columns["id_question"].Visible = false;
            
            dataGridView3.Columns["id_test"].Visible = false;
            dataGridView4.Columns["id_answer"].Visible = false;
            dataGridView4.Columns["id_question"].Visible = false;
            

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView3.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView4.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            comboBox1.DataSource = db.SelectRazdel().Tables[0];
            comboBox1.ValueMember = "id_section";
            comboBox1.DisplayMember = "Section";
            

        }

        private void SaveTMBtn_Click(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            if (db.TemaProverk(txtTema.Text,comboBox3.SelectedValue.ToString()))
            {
                MessageBox.Show("Такая запись уже существует!");
            }
            else
            {
                if (txtTema.Text == "")
                {
                    MessageBox.Show("Не введено некоторое поле!");
                }
                else
                {
                    
                    db.AddTema(txtTema.Text, comboBox3.SelectedValue.ToString());
                    dataGridView1.DataSource = db.SelectTemRazdel();
                    dataGridView2.DataSource = db.SelectText();
                    dataGridView1.Refresh();
                    txtTema.Clear();
                    MessageBox.Show("Добавление осуществилась!");
                    comboBox1.DataSource = db.SelectRazdel().Tables[0];
                    comboBox1.ValueMember = "id_section";
                    comboBox1.DisplayMember = "Section";
                    
                }    
            }
           
            
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (OpenFilebtnOne.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(OpenFilebtnOne.FileName);
                OpenFilebtnOne.DefaultExt = "*.html"; // Default file extension
                OpenFilebtnOne.Filter = "Text documents (.txt)|*.txt";
                txtPath.Text = OpenFilebtnOne.FileName;
                sr.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            comboBox2.DataSource = db.SelectTem(comboBox1.Text).Tables[0];
            comboBox2.ValueMember = "id_subject";
            comboBox2.DisplayMember = "Subject";
            
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (txtNameText.Text == "" || txtPath.Text == "")
            {
                MessageBox.Show("Не введено некоторое поле!"); 
            }
            else
            {
                DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
                db.SaveText(OpenFilebtnOne.FileName, comboBox2.SelectedValue.ToString(), txtNameText.Text);
                dataGridView2.DataSource = db.SelectText();
                dataGridView2.Refresh();
                txtPath.Clear();
                txtNameText.Clear();
                MessageBox.Show("Добавление осуществилась!");
            }
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void пользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autorizaishen forms = new Autorizaishen();
            forms.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void radButton3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            comboBox5.DataSource = db.SelectTem(comboBox4.Text).Tables[0];
            comboBox5.ValueMember = "id_subject";
            comboBox5.DisplayMember = "Subject";
        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            comboBox6.DataSource = db.SelectText(comboBox5.Text).Tables[0];
            comboBox6.ValueMember = "id_text";
            comboBox6.DisplayMember = "titles";
            if (comboBox6.Text == "")
            {
                
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == "")
            {
                MessageBox.Show("Нету теста для данной темы");
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            comboBox9.DataSource = db.SelectQuestion(comboBox8.Text).Tables[0];
            comboBox9.ValueMember = "id_question";
            comboBox9.DisplayMember = "Question";
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            if (radTextBox2.Text == "" || radTextBox3.Text == "" || radTextBox4.Text == "" || radTextBox5.Text == "" )
            {
                MessageBox.Show("Не введено некоторое поле!"); 
            }
            else
            {

                if (db.OtvetSoc(comboBox9.Text))
                {
                    MessageBox.Show("В данном вопросе все ответы заполнены!");
                }
                else
                {
                    if (comboBox10.Visible == true)
                    {
                        db.SaveOtvet(radTextBox2.Text, int.Parse(db.IDQuestion(comboBox9.Text)), comboBox10.SelectedIndex);
                        db.SaveOtvet(radTextBox3.Text, int.Parse(db.IDQuestion(comboBox9.Text)), comboBox11.SelectedIndex);
                        db.SaveOtvet(radTextBox4.Text, int.Parse(db.IDQuestion(comboBox9.Text)), comboBox12.SelectedIndex);
                        db.SaveOtvet(radTextBox5.Text, int.Parse(db.IDQuestion(comboBox9.Text)), comboBox13.SelectedIndex);
                        radTextBox2.Clear();
                        radTextBox3.Clear();
                        radTextBox4.Clear();
                        radTextBox5.Clear();
                        dataGridView1.DataSource = db.SelectTemRazdel();
                        dataGridView2.DataSource = db.SelectText();
                        dataGridView3.DataSource = db.SelectQuestionall();
                        dataGridView4.DataSource = db.SelectOtvetall();
                        MessageBox.Show("Добавление осуществилась!");
                    }
                    else
                    {
                        db.SaveOtvet(radTextBox2.Text, int.Parse(db.IDQuestion(comboBox9.Text)),Convert.ToInt32(radioButton1.Checked));
                        db.SaveOtvet(radTextBox3.Text, int.Parse(db.IDQuestion(comboBox9.Text)), Convert.ToInt32(radioButton2.Checked));
                        db.SaveOtvet(radTextBox4.Text, int.Parse(db.IDQuestion(comboBox9.Text)), Convert.ToInt32(radioButton3.Checked));
                        db.SaveOtvet(radTextBox5.Text, int.Parse(db.IDQuestion(comboBox9.Text)), Convert.ToInt32(radioButton4.Checked));
                        radTextBox2.Clear();
                        radTextBox3.Clear();
                        radTextBox4.Clear();
                        radTextBox5.Clear();
                        dataGridView1.DataSource = db.SelectTemRazdel();
                        dataGridView2.DataSource = db.SelectText();
                        dataGridView3.DataSource = db.SelectQuestionall();
                        dataGridView4.DataSource = db.SelectOtvetall();
                        MessageBox.Show("Добавление осуществилась!");
                    }
                    
                }
               

            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs one = new DataBase.DataBaseJobs();
            
            
            if (one.OptionsDD(comboBox9.Text))
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
            }
            else
            {
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                comboBox12.Visible = true;
                comboBox13.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox10.Text);
        }

        private void radButton3_Click_1(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            if (radTextBox1.Text =="")
            {
                MessageBox.Show("Не введено некоторое поле!"); 
            }
            else
            {
                if (db.QuestionSoc(comboBox6.Text))
                {
                    MessageBox.Show("В данной теме уже есть вопросы!");  
                }
                else
                {
                    db.SaveQuestion(radTextBox1.Text, db.IDTest(comboBox6.Text), comboBox7.SelectedIndex + 1);
                    comboBox8.Refresh();
                    radTextBox1.Clear();
                    dataGridView1.DataSource = db.SelectTemRazdel();
                    dataGridView2.DataSource = db.SelectText();
                    dataGridView3.DataSource = db.SelectQuestionall();
                    dataGridView4.DataSource = db.SelectOtvetall();
                    MessageBox.Show("Добавление осуществилась!");
                }
                
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            comboBox15.DataSource = db.SelectTem(comboBox16.Text).Tables[0];
            comboBox15.ValueMember = "id_subject";
            comboBox15.DisplayMember = "Subject";
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            comboBox14.DataSource = db.SelectTextFULL(comboBox15.Text).Tables[0];
            comboBox14.ValueMember = "id_text";
            comboBox14.DisplayMember = "titles";
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            
            db.AddTest(db.IDText(comboBox14.Text));
            comboBox4.Refresh();
            dataGridView1.DataSource = db.SelectTemRazdel();
            dataGridView2.DataSource = db.SelectText();
            dataGridView3.DataSource = db.SelectQuestionall();
            dataGridView4.DataSource = db.SelectOtvetall();
            MessageBox.Show("Добавление осуществилась!");
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            string sql = string.Format("DELETE FROM Subjects WHERE id_subject = {0} AND id_section = {1} ", dataGridView1.CurrentRow.Cells["id_subject"].Value.ToString(), dataGridView1.CurrentRow.Cells["id_section"].Value.ToString());
            con.Open();
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                int i = cmd.ExecuteNonQuery();
            }
            con.Dispose();
            dataGridView1.DataSource = ddd.SelectTemRazdel();
            con.Close();
            dataGridView1.Columns["id_section"].Visible = false;
            dataGridView1.Columns["id_subject"].Visible = false;
            dataGridView2.Columns["id_text"].Visible = false;
            dataGridView2.Columns["id_subject"].Visible = false;
            dataGridView3.Columns["id_question"].Visible = false;

            dataGridView3.Columns["id_test"].Visible = false;
            dataGridView4.Columns["id_answer"].Visible = false;
            dataGridView4.Columns["id_question"].Visible = false; 
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            string sql = string.Format("DELETE FROM Texts WHERE id_text = {0} AND id_subject = {1} ", dataGridView2.CurrentRow.Cells["id_text"].Value.ToString(), dataGridView2.CurrentRow.Cells["id_subject"].Value.ToString());
            con.Open();
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                int i = cmd.ExecuteNonQuery();
            }
            con.Dispose();
            dataGridView2.DataSource = ddd.SelectText();
            con.Close();
            dataGridView1.Columns["id_section"].Visible = false;
            dataGridView1.Columns["id_subject"].Visible = false;
            dataGridView2.Columns["id_text"].Visible = false;
            dataGridView2.Columns["id_subject"].Visible = false;
            dataGridView3.Columns["id_question"].Visible = false;

            dataGridView3.Columns["id_test"].Visible = false;
            dataGridView4.Columns["id_answer"].Visible = false;
            dataGridView4.Columns["id_question"].Visible = false;
        }

        private void radButton12_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            string sql = string.Format("DELETE FROM Answers WHERE id_answer = {0} AND id_question = {1} ", dataGridView4.CurrentRow.Cells["id_answer"].Value.ToString(), dataGridView4.CurrentRow.Cells["id_question"].Value.ToString());
            con.Open();
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                int i = cmd.ExecuteNonQuery();
            }
            con.Dispose();
            dataGridView4.DataSource = ddd.SelectQuestionall();
            con.Close();
        }

        private void radButton10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            string sql = string.Format("DELETE FROM Questions WHERE id_question = {0}  AND id_test = {1} ", dataGridView3.CurrentRow.Cells["id_question"].Value.ToString(),  dataGridView3.CurrentRow.Cells["id_test"].Value.ToString());
            con.Open();
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                int i = cmd.ExecuteNonQuery();
            }
            con.Dispose();
            dataGridView3.DataSource = ddd.SelectQuestionall() ;
            con.Close();
            dataGridView1.Columns["id_section"].Visible = false;
            dataGridView1.Columns["id_subject"].Visible = false;
            dataGridView2.Columns["id_text"].Visible = false;
            dataGridView2.Columns["id_subject"].Visible = false;
            dataGridView3.Columns["id_question"].Visible = false;

            dataGridView3.Columns["id_test"].Visible = false;
            dataGridView4.Columns["id_answer"].Visible = false;
            dataGridView4.Columns["id_question"].Visible = false;
            dataGridView1.Columns["id_section"].Visible = false;
            dataGridView1.Columns["id_subject"].Visible = false;
            dataGridView2.Columns["id_text"].Visible = false;
            dataGridView2.Columns["id_subject"].Visible = false;
            dataGridView3.Columns["id_question"].Visible = false;

            dataGridView3.Columns["id_test"].Visible = false;
            dataGridView4.Columns["id_answer"].Visible = false;
            dataGridView4.Columns["id_question"].Visible = false;
        }

        private void radButton6_Click(object sender, EventArgs e)
        {

            string sql = string.Format("UPDATE Subjects SET Subject = '{0}' WHERE id_subject = {1} and id_section = {2}  ", dataGridView1.CurrentRow.Cells["Subject"].Value.ToString(), dataGridView1.CurrentRow.Cells["id_subject"].Value.ToString(), dataGridView1.CurrentRow.Cells["id_section"].Value.ToString());
            using (SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    int i = cmd.ExecuteNonQuery();
                }
                con.Dispose();

                con.Close();
                using (SqlConnection con1 = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True"))
                {
                    string sql1 = string.Format("UPDATE Sections SET Section = '{0}' WHERE id_section = {1}  ", dataGridView1.CurrentRow.Cells["Section"].Value.ToString(), dataGridView1.CurrentRow.Cells["id_section"].Value.ToString());
                    con1.Open();
                    using (SqlCommand cmd = new SqlCommand(sql1, con1))
                    {
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con1;
                        int i = cmd.ExecuteNonQuery();
                    }
                    con1.Dispose();
                    dataGridView1.DataSource = ddd.SelectText();
                    con1.Close();
                }
            }
            dataGridView1.Columns["id_section"].Visible = false;
            dataGridView1.Columns["id_subject"].Visible = false;
            dataGridView2.Columns["id_text"].Visible = false;
            dataGridView2.Columns["id_subject"].Visible = false;
            dataGridView3.Columns["id_question"].Visible = false;

            dataGridView3.Columns["id_test"].Visible = false;
            dataGridView4.Columns["id_answer"].Visible = false;
            dataGridView4.Columns["id_question"].Visible = false;
        }

        private void radButton9_Click(object sender, EventArgs e)
        {
            string sql = string.Format("UPDATE Texts SET Text = '{0}' WHERE id_subject = {1} and id_text = {2}", dataGridView2.CurrentRow.Cells["Text"].Value.ToString(), dataGridView2.CurrentRow.Cells["id_subject"].Value.ToString(), dataGridView2.CurrentRow.Cells["id_text"].Value.ToString());
            using (SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    int i = cmd.ExecuteNonQuery();
                }
                con.Dispose();

                con.Close();
                
                    
                    dataGridView2.DataSource = ddd.SelectText();
                    dataGridView1.Columns["id_section"].Visible = false;
                    dataGridView1.Columns["id_subject"].Visible = false;
                    dataGridView2.Columns["id_text"].Visible = false;
                    dataGridView2.Columns["id_subject"].Visible = false;
                    dataGridView3.Columns["id_question"].Visible = false;

                    dataGridView3.Columns["id_test"].Visible = false;
                    dataGridView4.Columns["id_answer"].Visible = false;
                    dataGridView4.Columns["id_question"].Visible = false;
                
            }

        }

        private void radButton11_Click(object sender, EventArgs e)
        {
            string sql = string.Format("UPDATE Questions SET Question = '{0}' WHERE id_question = {1} ", dataGridView3.CurrentRow.Cells["Question"].Value.ToString(), dataGridView3.CurrentRow.Cells["id_question"].Value.ToString());
            using (SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    int i = cmd.ExecuteNonQuery();
                }
                con.Dispose();
                dataGridView4.DataSource = ddd.SelectQuestionall();
                con.Close();
                dataGridView1.Columns["id_section"].Visible = false;
                dataGridView1.Columns["id_subject"].Visible = false;
                dataGridView2.Columns["id_text"].Visible = false;
                dataGridView2.Columns["id_subject"].Visible = false;
                dataGridView3.Columns["id_question"].Visible = false;

                dataGridView3.Columns["id_test"].Visible = false;
                
                dataGridView4.Columns["id_question"].Visible = false; 
            }
        }

        private void radButton13_Click(object sender, EventArgs e)
        {
            string sql = string.Format("UPDATE Answers SET Answer = '{0}' WHERE id_question = {1} and id_answer = {2} ", dataGridView4.CurrentRow.Cells["Answer"].Value.ToString(), dataGridView4.CurrentRow.Cells["id_question"].Value.ToString(), dataGridView4.CurrentRow.Cells["id_answer"].Value.ToString());
            using (SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    int i = cmd.ExecuteNonQuery();
                }
                con.Dispose();
                dataGridView4.DataSource = ddd.SelectOtvetall();
                con.Close();
                dataGridView1.Columns["id_section"].Visible = false;
                dataGridView1.Columns["id_subject"].Visible = false;
                dataGridView2.Columns["id_text"].Visible = false;
                dataGridView2.Columns["id_subject"].Visible = false;
                dataGridView3.Columns["id_question"].Visible = false;

                dataGridView3.Columns["id_test"].Visible = false;
                dataGridView4.Columns["id_answer"].Visible = false;
                dataGridView4.Columns["id_question"].Visible = false;
                //using (SqlConnection con1 = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True"))
                //{
                //    string sql1 = string.Format("UPDATE Sections SET Section = '{0}' WHERE id_section = {1}  ", dataGridView4.CurrentRow.Cells["Section"].Value.ToString(), dataGridView4.CurrentRow.Cells["id_section"].Value.ToString());
                //    con1.Open();
                //    using (SqlCommand cmd = new SqlCommand(sql1, con1))
                //    {
                //        cmd.CommandText = sql;
                //        cmd.CommandType = CommandType.Text;
                //        cmd.Connection = con1;
                //        int i = cmd.ExecuteNonQuery();
                //    }
                //    con1.Dispose();
                //    dataGridView4.DataSource = ddd.SelectTemRazdel();
                //    con1.Close();
                //}
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"help.chm",  HelpNavigator.TableOfContents);
        }
    }
}
