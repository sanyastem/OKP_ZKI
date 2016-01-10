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
            SqlConnection connRC = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            string command = string.Format("SELECT Subjects.Subject FROM Sections,Subjects"
+ " WHERE Subjects.id_section = Sections.id_section ");
            SqlDataAdapter da = new SqlDataAdapter(command, connRC);

            DataSet ds = new DataSet();
            connRC.Open();
            da.Fill(ds);
            connRC.Close();

            comboBox3.DataSource = ds.Tables[0];
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseZKIDataSet.Texts". При необходимости она может быть перемещена или удалена.
            this.textsTableAdapter.Fill(this.dataBaseZKIDataSet.Texts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseZKIDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.dataBaseZKIDataSet.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseZKIDataSet.Sections". При необходимости она может быть перемещена или удалена.
            this.sectionsTableAdapter.Fill(this.dataBaseZKIDataSet.Sections);
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            DtGridViewTM.DataSource = db.SelectTemRazdel();
            TextGridview.DataSource = db.SelectText();

           
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

            SqlConnection connRC = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
            string command = string.Format("SELECT Subjects.Subject FROM Sections,Subjects"
+ " WHERE Subjects.id_section = Sections.id_section AND Sections.id_section='{0}'", comboBox1.SelectedValue);
            connRC.Open();
            SqlDataAdapter da = new SqlDataAdapter(command, connRC);

            DataSet ds = new DataSet();

            da.Fill(ds);


            comboBox2.DataSource = ds.Tables[0];
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
    }
}
