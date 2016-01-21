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
            if (txtRazd.Text == "")
            {
                MessageBox.Show("Не введено некоторое поле!");
            }
            else
            {
                DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
                db.AddRazdel(txtRazd.Text);
                DtGridViewTM.DataSource = db.SelectTemRazdel();
                TextGridview.DataSource = db.SelectText();
                comboBox3.DataSource = db.SelectRazdel().Tables[0];
                comboBox3.ValueMember = "id_section";
                comboBox3.DisplayMember = "Section";
                DtGridViewTM.Refresh();
                txtRazd.Clear();
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
            DtGridViewTM.DataSource = db.SelectTemRazdel();
            TextGridview.DataSource = db.SelectText();
            comboBox3.DataSource = db.SelectRazdel().Tables[0];
            comboBox3.ValueMember = "id_section";
            comboBox3.DisplayMember = "Section";
            
        }

        private void SaveTMBtn_Click(object sender, EventArgs e)
        {
            if (txtTema.Text == "")
            {
                MessageBox.Show("Не введено некоторое поле!");
            }
            else
            {
                DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
                db.AddTema(txtTema.Text, comboBox3.SelectedValue.ToString());
                DtGridViewTM.DataSource = db.SelectTemRazdel();
                TextGridview.DataSource = db.SelectText();
                DtGridViewTM.Refresh();
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
            comboBox2.DataSource = db.SelectTem(comboBox1.SelectedIndex + 1).Tables[0];
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
                TextGridview.DataSource = db.SelectText();
                TextGridview.Refresh();
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
            comboBox5.DataSource = db.SelectTem(comboBox4.SelectedIndex + 1).Tables[0];
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
                radLabel4.Visible = true;
                radLabel4.Text = "Нету теста!";
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == "")
            {
                radLabel4.Visible = true;
                radLabel4.Text = "Нету теста!";
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
                    }
                    else
                    {
                        db.SaveOtvet(radTextBox2.Text, int.Parse(db.IDQuestion(comboBox9.Text)),Convert.ToInt32(radioButton1.Checked));
                        db.SaveOtvet(radTextBox3.Text, int.Parse(db.IDQuestion(comboBox9.Text)), Convert.ToInt32(radioButton2.Checked));
                        db.SaveOtvet(radTextBox4.Text, int.Parse(db.IDQuestion(comboBox9.Text)), Convert.ToInt32(radioButton3.Checked));
                        db.SaveOtvet(radTextBox5.Text, int.Parse(db.IDQuestion(comboBox9.Text)), Convert.ToInt32(radioButton4.Checked));
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
                }
                
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            comboBox15.DataSource = db.SelectTem(comboBox16.SelectedIndex + 1).Tables[0];
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
        }
    }
}
