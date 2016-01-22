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
    public partial class AllResultForms : Telerik.WinControls.UI.RadForm
    {
        string nameAuto;
        public AllResultForms()
        {
            
            InitializeComponent();
        }

        private void AllResultForms_Load(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            dataGridView2.DataSource = db.ResulUsersAll();
            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            
        }
    }
}
