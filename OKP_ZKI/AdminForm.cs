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
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            db.AddRazdel(txtRazd.Text);
            DtGridViewTM.DataSource = db.SelectTemRazdel();
            TextGridview.DataSource = db.SelectText();
            DtGridViewTM.Refresh();
            txtRazd.Clear();
            comboBox3.Refresh();
            SqlConnection connRC = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            string command1 = string.Format("SELECT Sections.Section  FROM Sections");
            SqlDataAdapter da = new SqlDataAdapter(command1, connRC);
            DataSet ds = new DataSet();
            connRC.Open();
            da.Fill(ds);
            comboBox4.DataSource = ds.Tables[0];
            connRC.Close();

            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection connRC = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            string command = string.Format("SELECT Texts.titles FROM Texts,Subjects "
+ " WHERE Subjects.id_subject = Texts.id_subject");
            connRC.Open();
            SqlDataAdapter da = new SqlDataAdapter(command, connRC);

            DataSet ds = new DataSet();

            da.Fill(ds);


            comboBox4.DataSource = ds.Tables[0];
            connRC.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
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

            SqlConnection connRC = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            string command = string.Format("SELECT Texts.titles FROM Texts,Subjects "
+ " WHERE Subjects.id_subject = Texts.id_subject");
            connRC.Open();
            SqlDataAdapter da = new SqlDataAdapter(command, connRC);
            DataSet ds = new DataSet();
            da.Fill(ds);
            comboBox4.DataSource = ds.Tables[0];
            comboBox4.DisplayMember = "titles";
            comboBox4.ValueMember = "titles";
            connRC.Close();

            SqlConnection connRC1 = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            string command1 = string.Format("SELECT Options.[Option] FROM Options");
            connRC.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(command1, connRC1);

            DataSet ds1 = new DataSet();

            da1.Fill(ds1);


            comboBox5.DataSource = ds1.Tables[0];
            comboBox5.DisplayMember = "Option";
            comboBox5.ValueMember = "Option";
            connRC1.Close();
            SqlConnection connRC2 = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            radGridView1.DataSource = db.SelectOtvet();
            string command2 = string.Format("SELECT Sections.Section  FROM Sections");
            SqlDataAdapter da2 = new SqlDataAdapter(command2, connRC2);
            DataSet ds2 = new DataSet();
            connRC2.Open();
            da.Fill(ds2);
            
            connRC2.Close();
            comboBox3.DataSource = ds2.Tables[0];
        }

        private void SaveTMBtn_Click(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            db.AddTema(txtTema.Text,comboBox3.SelectedValue.ToString());
            DtGridViewTM.DataSource = db.SelectTemRazdel();
            TextGridview.DataSource = db.SelectText();
            DtGridViewTM.Refresh();
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

            SqlConnection connRC = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            string command = string.Format("SELECT Subjects.Subject FROM Sections,Subjects"
+ " WHERE Subjects.id_section = Sections.id_section AND Sections.id_section='{0}'", comboBox1.SelectedValue);
            connRC.Open();
            SqlDataAdapter da = new SqlDataAdapter(command, connRC);

            DataSet ds = new DataSet();

            da.Fill(ds);


            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Subject";
            comboBox2.ValueMember = "Subject";
            connRC.Close();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            db.SaveText(OpenFilebtnOne.FileName,comboBox2.SelectedValue.ToString(),txtNameText.Text);
            TextGridview.DataSource = db.SelectText();
            TextGridview.Refresh();
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
            SqlConnection connRC = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            string command = string.Format("SELECT Texts.titles FROM Texts,Subjects "
+" WHERE Subjects.id_subject = Texts.id_subject");
            connRC.Open();
            SqlDataAdapter da = new SqlDataAdapter(command, connRC);

            DataSet ds = new DataSet();

            da.Fill(ds);


            comboBox4.DataSource = ds.Tables[0];
            comboBox4.DisplayMember = "titles";
            comboBox4.ValueMember = "titles";
            connRC.Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connRC = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            string command = string.Format("SELECT Options.[Option] FROM Options");
            connRC.Open();
            SqlDataAdapter da = new SqlDataAdapter(command, connRC);

            DataSet ds = new DataSet();

            da.Fill(ds);


            comboBox5.DataSource = ds.Tables[0];
            comboBox5.DisplayMember = "Option";
            comboBox5.ValueMember = "Option";
            connRC.Close();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
