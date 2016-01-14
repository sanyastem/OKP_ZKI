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
           /* radCheckBox1.Visible = false;
            radCheckBox2.Visible = false;
            radCheckBox3.Visible = false;
            radCheckBox4.Visible = false;
            radCheckBox5.Visible = false;
            radCheckBox6.Visible = false;
            radCheckBox7.Visible = false;
            radCheckBox8.Visible = false;
            radCheckBox9.Visible = false;
            radCheckBox10.Visible = false;
            radCheckBox11.Visible = false;
            radCheckBox12.Visible = false;
            radCheckBox13.Visible = false;
            radCheckBox14.Visible = false;
            radCheckBox15.Visible = false;
            radCheckBox16.Visible = false;
            radCheckBox17.Visible = false;
            radCheckBox18.Visible = false;
            radCheckBox19.Visible = false;
            radCheckBox20.Visible = false;
            radCheckBox21.Visible = false;
            radCheckBox22.Visible = false;
            radCheckBox23.Visible = false;
            radCheckBox24.Visible = false;
            radCheckBox25.Visible = false;
            radCheckBox26.Visible = false;
            radCheckBox27.Visible = false;
            radCheckBox28.Visible = false;
            radCheckBox29.Visible = false;
            radCheckBox30.Visible = false;
            radCheckBox31.Visible = false;
            radCheckBox32.Visible = false;
            radCheckBox33.Visible = false;
            radCheckBox34.Visible = false;
            radCheckBox35.Visible = false;
            radCheckBox36.Visible = false;
            radCheckBox37.Visible = false;
            radCheckBox38.Visible = false;
            radCheckBox39.Visible = false;
            radCheckBox40.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton2.Visible = false;
            radRadioButton3.Visible = false;
            radRadioButton4.Visible = false;
            radRadioButton5.Visible = false;
            radRadioButton6.Visible = false;
            radRadioButton7.Visible = false;
            radRadioButton8.Visible = false;
            radRadioButton9.Visible = false;
            radRadioButton10.Visible = false;
            radRadioButton11.Visible = false;
            radRadioButton12.Visible = false;
            radRadioButton13.Visible = false;
            radRadioButton14.Visible = false;
            radRadioButton15.Visible = false;
            radRadioButton16.Visible = false;
            radRadioButton17.Visible = false;
            radRadioButton18.Visible = false;
            radRadioButton19.Visible = false;
            radRadioButton20.Visible = false;
            radRadioButton21.Visible = false;
            radRadioButton22.Visible = false;
            radRadioButton23.Visible = false;
            radRadioButton24.Visible = false;
            radRadioButton25.Visible = false;
            radRadioButton26.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton1.Visible = false;
            radRadioButton1.Visible = false;*/
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
            // radPageViewPage1.Text == 1
            List<string> dt = db.Otvet(write[0]);
            foreach (var item in write)
            {
                
                if (db.Option(write[0]))
                {
                    radRadioButton1.Visible = true;
                    radRadioButton1.Text = dt[0];

                    radRadioButton2.Visible = true;
                   
                    radRadioButton3.Visible = true;
                    radRadioButton4.Visible = true;
                    radRadioButton2.Text = dt[1];
                    radRadioButton3.Text = dt[2];
                    radRadioButton4.Text = dt[3];
                }
                else
                {
                    radCheckBox1.Visible = true;
                    radCheckBox2.Visible = true;
                    radCheckBox3.Visible = true;
                    radCheckBox4.Visible = true;
                }
                
                
            }
        }
        public static void Hai()
        {

        }
       
    }
}
