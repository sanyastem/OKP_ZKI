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
    public partial class AdminAutorizeishen : Telerik.WinControls.UI.RadForm
    {
        public AdminAutorizeishen()
        {
            InitializeComponent();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True"))
            {
                sql.Open();
                string x = string.Format("SELECT Adminstrator.Login,Adminstrator.Password FROM Adminstrator"
+" WHERE Adminstrator.Login = '{0}' AND Adminstrator.Password = '{1}'", txtLogin.Text, txtPassword.Text);
                SqlCommand zapros = new SqlCommand(x, sql);
                SqlDataReader h = zapros.ExecuteReader();
                int count = 0;
                while (h.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    AdminForm forms = new AdminForm();
                    forms.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Логин или пароль не верен!","ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AdminAutorizeishen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
