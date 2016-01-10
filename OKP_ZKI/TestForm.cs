using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace OKP_ZKI
{
    public partial class TestForm : Telerik.WinControls.UI.RadForm
    {
        List<string> write = new List<string>();
        public TestForm(int str)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True"))
            {
                string zapros = string.Format("SELECT Questions.Question FROM Sections,Subjects,Texts,Questions"
 +" WHERE Sections.id_section = Subjects.id_section AND Subjects.id_subject = Texts.id_subject AND"
 +" Texts.id_text = '{0}'",str);
                con.Open();
                SqlCommand db = new SqlCommand(zapros,con);
                SqlDataReader one = db.ExecuteReader();
                
                while (one.Read())
                {
                    int dd = 0;
                    write.Add(one["Question"].ToString());
                        ++dd;
                }
               
            }

                InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            DataBase.DataBaseJobs db = new DataBase.DataBaseJobs();
            radLabel1.Text = write[0];
            radLabel2.Text = write[1];
            radLabel3.Text = write[2];
            radLabel4.Text = write[3];
            radLabel5.Text = write[4];
            radLabel6.Text = write[5];
            radLabel7.Text = write[6];
            radLabel8.Text = write[7];
            radLabel9.Text = write[8];
            radLabel10.Text = write[9];
            RadRadioButton[] one = new RadRadioButton [40];
            foreach (var item in write)
            {
                if (db.Option(item))
                {
                    
                }
                else
                {
                    MessageBox.Show("НЕЧЕГО!");
                }
            }
        }
       
    }
}
