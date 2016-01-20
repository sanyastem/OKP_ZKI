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
    public partial class ResultForms : Telerik.WinControls.UI.RadForm
    { 
        string resultText;
        string UsersText;
        public ResultForms(int result,string name)
        {
            resultText = string.Format("Реузльтат:{0}",result);
            UsersText = string.Format("Пользователь:{0}",name);
            InitializeComponent();
        }

        private void ResultForms_Load(object sender, EventArgs e)
        {
            radLabel1.Text = UsersText;
            radLabel2.Text = resultText;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
