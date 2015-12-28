using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            DtGridViewTM.Refresh();
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
            DtGridViewTM.Refresh();
        }
    }
}
