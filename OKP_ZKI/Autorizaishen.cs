using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OKP_ZKI
{
    public partial class Autorizaishen : Telerik.WinControls.UI.RadForm
    {
        public Autorizaishen()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs a = new DataBase.DataBaseJobs();
            if (a.UsersAutoriseishen(Logintxt.Text,Passwordtxt.Text))
            {
                InformationForm forms = new InformationForm(Logintxt.Text);
                forms.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!","Ошибка!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        

        }

        private void Registration_Click(object sender, EventArgs e)
        {
            RegistrationForm forms = new RegistrationForm();
            forms.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void администраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAutorizeishen form = new AdminAutorizeishen();
            form.Show();
            this.Hide();
        }
    }
}
