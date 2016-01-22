using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DataBase;

namespace OKP_ZKI
{
    public partial class RegistrationForm : Telerik.WinControls.UI.RadForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            DataBaseJobs db = new DataBaseJobs();
            if (db.UsersProverk(txtlogin.Text))
            {
                MessageBox.Show("Такая запись уже существует!");
            }
            else
            {
                if (txtPassword_one.Text == txtPassword_two.Text)
                {
                    
                    db.Usersregistration(txtlogin.Text.ToString(), txtPassword_two.Text.ToString());
                    this.Close();
                    MessageBox.Show("Регистрация произведена!");
                }
                else
                {
                    MessageBox.Show("Поля не равны!", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }
    }
}
                                                                                