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
        string nameAutoriseishen;
        DataBase.DataBaseJobs lol = new DataBase.DataBaseJobs();
        int result = 0;
        int str1;
        List<string> write = new List<string>();
        public TestForm(int str,string name)
        {
            str1 = str;
            nameAutoriseishen = name;
            using (SqlConnection con = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True"))
            {
                string zapros = string.Format("SELECT Questions.Question FROM Sections,Subjects,Texts,Questions,Tests "
+" WHERE Sections.id_section = Subjects.id_section AND Subjects.id_subject = Texts.id_subject AND Tests.id_test = Questions.id_test AND Texts.id_text = Tests.id_texts AND "
+" Texts.id_text = {0}",str);
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

            List<string> dt = db.Otvet(write[0]);
            List<string> da = db.Otvet(write[1]);
            List<string> dw = db.Otvet(write[2]);
            List<string> de = db.Otvet(write[3]);
            List<string> dr = db.Otvet(write[4]);
            List<string> dy = db.Otvet(write[5]);
            List<string> du = db.Otvet(write[6]);
            List<string> di = db.Otvet(write[7]);
            List<string> dp = db.Otvet(write[8]);
            List<string> dz = db.Otvet(write[9]);
            
                if (db.Option(write[0]))
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = dt[0];
                    
                    radioButton2.Visible = true;
                   
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton2.Text = dt[1];
                    radioButton3.Text = dt[2];
                    radioButton4.Text = dt[3];
                    radioButton1.BringToFront();
                }
                else
                {
                    radCheckBox1.Visible = true;
                    radCheckBox2.Visible = true;
                    radCheckBox3.Visible = true;
                    radCheckBox4.Visible = true;
                    radCheckBox1.Text = da[0];
                    radCheckBox2.Text = da[1];
                    radCheckBox3.Text = da[2];
                    radCheckBox4.Text = da[3];
                }
            if (db.Option(write[1]))
            {
                radioButton5.Visible = true;
                radioButton5.Text = da[0];
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                radioButton6.Text = da[1];
                radioButton7.Text = da[2];
                radioButton8.Text = da[3];
            }
            else
            {
                radCheckBox5.Visible = true;
                radCheckBox6.Visible = true;
                radCheckBox7.Visible = true;
                radCheckBox8.Visible = true;
                radCheckBox5.Text = da[0];
                radCheckBox6.Text = da[1];
                radCheckBox7.Text = da[2];
                radCheckBox8.Text = da[3];
            }
            if (db.Option(write[2]))
            {
                radioButton9.Visible = true;
                radioButton9.Text = dw[0];

                radioButton10.Visible = true;

                radioButton11.Visible = true;
                radioButton12.Visible = true;
                radioButton10.Text = dw[1];
                radioButton11.Text = dw[2];
                radioButton12.Text = dw[3];
            }
            else
            {
                radCheckBox9.Visible = true;
                radCheckBox10.Visible = true;
                radCheckBox11.Visible = true;
                radCheckBox12.Visible = true;
                radCheckBox9.Text = dw[0];
                radCheckBox10.Text = dw[1];
                radCheckBox11.Text = dw[2];
                radCheckBox12.Text = dw[3];
            }
            if (db.Option(write[3]))
            {
                radioButton13.Visible = true;
                radioButton13.Text = de[0];

                radioButton14.Visible = true;

                radioButton15.Visible = true;
                radioButton16.Visible = true;
                radioButton14.Text = de[1];
                radioButton15.Text = de[2];
                radioButton16.Text = de[3];
            }
            else
            {
                radCheckBox13.Visible = true;
                radCheckBox14.Visible = true;
                radCheckBox15.Visible = true;
                radCheckBox16.Visible = true;
                radCheckBox13.Text = de[0];
                radCheckBox14.Text = de[1];
                radCheckBox15.Text = de[2];
                radCheckBox16.Text = de[3];
            }
            if (db.Option(write[4]))
            {
                radioButton17.Visible = true;
                radioButton17.Text = dr[0];

                radioButton18.Visible = true;

                radioButton19.Visible = true;
                radioButton20.Visible = true;
                radioButton18.Text = dr[1];
                radioButton19.Text = dr[2];
                radioButton20.Text = dr[3];
            }
            else
            {
                radCheckBox17.Visible = true;
                radCheckBox18.Visible = true;
                radCheckBox19.Visible = true;
                radCheckBox20.Visible = true;
                radCheckBox17.Text = dr[0];
                radCheckBox18.Text = dr[1];
                radCheckBox19.Text = dr[2];
                radCheckBox20.Text = dr[3];
            }
            if (db.Option(write[5]))
            {
                radioButton21.Visible = true;
                radioButton21.Text = dy[0];

                radioButton22.Visible = true;

                radioButton23.Visible = true;
                radioButton24.Visible = true;
                radioButton22.Text = dy[1];
                radioButton23.Text = dy[2];
                radioButton24.Text = dy[3];
            }
            else
            {
                radCheckBox21.Visible = true;
                radCheckBox22.Visible = true;
                radCheckBox23.Visible = true;
                radCheckBox24.Visible = true;
                radCheckBox21.Text = dy[0];
                radCheckBox22.Text = dy[1];
                radCheckBox23.Text = dy[2];
                radCheckBox24.Text = dy[3];
            }
            if (db.Option(write[6]))
            {
                radioButton25.Visible = true;
                radioButton25.Text = du[0];

                radioButton26.Visible = true;

                radioButton27.Visible = true;
                radioButton28.Visible = true;
                radioButton26.Text = du[1];
                radioButton27.Text = du[2];
                radioButton28.Text = du[3];
            }
            else
            {
                radCheckBox25.Visible = true;
                radCheckBox26.Visible = true;
                radCheckBox27.Visible = true;
                radCheckBox28.Visible = true;
                radCheckBox25.Text = du[0];
                radCheckBox26.Text = du[1];
                radCheckBox27.Text = du[2];
                radCheckBox28.Text = du[3];
            }
            if (db.Option(write[7]))
            {
                radioButton29.Visible = true;
                radioButton29.Text = di[0];

                radioButton30.Visible = true;

                radioButton31.Visible = true;
                radioButton32.Visible = true;
                radioButton30.Text = di[1];
                radioButton31.Text = di[2];
                radioButton32.Text = di[3];
            }
            else
            {
                radCheckBox29.Visible = true;
                radCheckBox30.Visible = true;
                radCheckBox31.Visible = true;
                radCheckBox32.Visible = true;
                radCheckBox29.Text = di[0];
                radCheckBox30.Text = di[1];
                radCheckBox31.Text = di[2];
                radCheckBox32.Text = di[3];
            }
            if (db.Option(write[8]))
            {
                radioButton33.Visible = true;
                radioButton33.Text = dp[0];

                radioButton34.Visible = true;

                radioButton35.Visible = true;
                radioButton36.Visible = true;
                radioButton34.Text = dp[1];
                radioButton35.Text = dp[2];
                radioButton36.Text = dp[3];
            }
            else
            {
                radCheckBox33.Visible = true;
                radCheckBox34.Visible = true;
                radCheckBox35.Visible = true;
                radCheckBox36.Visible = true;
                radCheckBox33.Text = dp[0];
                radCheckBox34.Text = dp[1];
                radCheckBox35.Text = dp[2];
                radCheckBox36.Text = dp[3];
            }
            if (db.Option(write[9]))
            {
                radioButton37.Visible = true;
                radioButton37.Text = dz[0];

                radioButton38.Visible = true;

                radioButton39.Visible = true;
                radioButton40.Visible = true;
                radioButton38.Text = dz[1];
                radioButton39.Text = dz[2];
                radioButton40.Text = dz[3];
            }
            else
            {
                radCheckBox37.Visible = true;
                radCheckBox38.Visible = true;
                radCheckBox39.Visible = true;
                radCheckBox40.Visible = true;
                radCheckBox37.Text = dz[0];
                radCheckBox38.Text = dz[1];
                radCheckBox39.Text = dz[2];
                radCheckBox40.Text = dz[3];
            }



        }
        public static void Hai()
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (radCheckBox1.Visible == true && radCheckBox2.Visible == true && radCheckBox3.Visible == true && radCheckBox4.Visible == true)
            {
                if (lol.PravOtvet(radCheckBox1.Text, write[0]) && radCheckBox1.Checked == true && lol.PravOtvet(radCheckBox2.Text, write[0]) && radCheckBox2.Checked == true || lol.PravOtvet(radCheckBox1.Text, write[0]) && radCheckBox1.Checked == true && lol.PravOtvet(radCheckBox3.Text, write[0]) && radCheckBox3.Checked == true ||
                lol.PravOtvet(radCheckBox1.Text, write[0]) && radCheckBox1.Checked == true && lol.PravOtvet(radCheckBox4.Text, write[0]) && radCheckBox4.Checked == true || lol.PravOtvet(radCheckBox2.Text, write[0]) && radCheckBox2.Checked == true && lol.PravOtvet(radCheckBox3.Text, write[0]) && radCheckBox3.Checked == true ||
                lol.PravOtvet(radCheckBox2.Text, write[0]) && radCheckBox2.Checked == true && lol.PravOtvet(radCheckBox4.Text, write[0]) && radCheckBox4.Checked == true || lol.PravOtvet(radCheckBox3.Text, write[0]) && radCheckBox3.Checked == true && lol.PravOtvet(radCheckBox4.Text, write[0]) && radCheckBox4.Checked == true)
                   {
                      ++result;
                   }
            }
            else
            {
                if (lol.PravOtvet(radioButton1.Text, write[0]) && radioButton1.Checked || lol.PravOtvet(radioButton2.Text, write[0]) && radioButton2.Checked || lol.PravOtvet(radioButton3.Text, write[0]) && radioButton3.Checked ||
                 lol.PravOtvet(radioButton4.Text, write[0]) && radioButton4.Checked )
                {
                    ++result;
                }
            }
            radPageViewPage1.Enabled=false;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (radCheckBox5.Visible == true && radCheckBox6.Visible == true && radCheckBox7.Visible == true && radCheckBox8.Visible == true)
            {
                if (lol.PravOtvet(radCheckBox5.Text, write[0]) && radCheckBox5.Checked == true && lol.PravOtvet(radCheckBox6.Text, write[0]) && radCheckBox6.Checked == true || lol.PravOtvet(radCheckBox5.Text, write[0]) && radCheckBox5.Checked == true && lol.PravOtvet(radCheckBox7.Text, write[0]) && radCheckBox7.Checked == true ||
               lol.PravOtvet(radCheckBox5.Text, write[0]) && radCheckBox5.Checked == true && lol.PravOtvet(radCheckBox8.Text, write[0]) && radCheckBox8.Checked == true || lol.PravOtvet(radCheckBox6.Text, write[0]) && radCheckBox6.Checked == true && lol.PravOtvet(radCheckBox7.Text, write[0]) && radCheckBox7.Checked == true ||
               lol.PravOtvet(radCheckBox6.Text, write[0]) && radCheckBox6.Checked == true && lol.PravOtvet(radCheckBox8.Text, write[0]) && radCheckBox8.Checked == true || lol.PravOtvet(radCheckBox7.Text, write[0]) && radCheckBox7.Checked == true && lol.PravOtvet(radCheckBox8.Text, write[0]) && radCheckBox8.Checked == true)
                {
                    ++result;
                }
            }
            else
            {
                if (lol.PravOtvet(radioButton5.Text, write[0]) && radioButton5.Checked == true || lol.PravOtvet(radioButton6.Text, write[0]) && radioButton6.Checked == true || lol.PravOtvet(radioButton7.Text, write[0]) && radioButton7.Checked == true ||
                 lol.PravOtvet(radioButton8.Text, write[0]) && radioButton8.Checked == true)
                {
                    ++result; 
                }
            }
            radPageViewPage2.Enabled = false;
           
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            if (radCheckBox9.Visible == true && radCheckBox10.Visible == true && radCheckBox11.Visible == true && radCheckBox12.Visible == true)
            {
                if (lol.PravOtvet(radCheckBox9.Text, write[0]) && radCheckBox9.Checked == true && lol.PravOtvet(radCheckBox10.Text, write[0]) && radCheckBox10.Checked == true || lol.PravOtvet(radCheckBox9.Text, write[0]) && radCheckBox9.Checked == true && lol.PravOtvet(radCheckBox11.Text, write[0]) && radCheckBox11.Checked == true ||
               lol.PravOtvet(radCheckBox9.Text, write[0]) && radCheckBox9.Checked == true && lol.PravOtvet(radCheckBox12.Text, write[0]) && radCheckBox12.Checked == true || lol.PravOtvet(radCheckBox10.Text, write[0]) && radCheckBox10.Checked == true && lol.PravOtvet(radCheckBox11.Text, write[0]) && radCheckBox11.Checked == true ||
               lol.PravOtvet(radCheckBox10.Text, write[0]) && radCheckBox10.Checked == true && lol.PravOtvet(radCheckBox12.Text, write[0]) && radCheckBox12.Checked == true || lol.PravOtvet(radCheckBox11.Text, write[0]) && radCheckBox11.Checked == true && lol.PravOtvet(radCheckBox12.Text, write[0]) && radCheckBox12.Checked == true)
                {
                    ++result;
                }
            }
            else
            {
                if (lol.PravOtvet(radioButton9.Text, write[0]) && radioButton9.Checked == true || lol.PravOtvet(radioButton10.Text, write[0]) && radioButton10.Checked == true || lol.PravOtvet(radioButton11.Text, write[0]) && radioButton11.Checked == true ||
               lol.PravOtvet(radioButton12.Text, write[0]) && radioButton12.Checked == true)
                {
                    ++result;
                }
            }
            radPageViewPage3.Enabled = false;
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            if (radCheckBox13.Visible == true && radCheckBox14.Visible == true && radCheckBox15.Visible == true && radCheckBox16.Visible == true)
            {
                if (lol.PravOtvet(radCheckBox13.Text, write[0]) && radCheckBox13.Checked == true && lol.PravOtvet(radCheckBox14.Text, write[0]) && radCheckBox14.Checked == true || lol.PravOtvet(radCheckBox13.Text, write[0]) && radCheckBox13.Checked == true && lol.PravOtvet(radCheckBox15.Text, write[0]) && radCheckBox15.Checked == true ||
               lol.PravOtvet(radCheckBox13.Text, write[0]) && radCheckBox13.Checked == true && lol.PravOtvet(radCheckBox16.Text, write[0]) && radCheckBox16.Checked == true || lol.PravOtvet(radCheckBox14.Text, write[0]) && radCheckBox14.Checked == true && lol.PravOtvet(radCheckBox15.Text, write[0]) && radCheckBox15.Checked == true ||
               lol.PravOtvet(radCheckBox14.Text, write[0]) && radCheckBox14.Checked == true && lol.PravOtvet(radCheckBox16.Text, write[0]) && radCheckBox16.Checked == true || lol.PravOtvet(radCheckBox15.Text, write[0]) && radCheckBox15.Checked == true && lol.PravOtvet(radCheckBox16.Text, write[0]) && radCheckBox16.Checked == true)
                 {
                     ++result;
                 }
            }
            else
            {
                if (lol.PravOtvet(radioButton13.Text, write[0]) && radioButton13.Checked == true || lol.PravOtvet(radioButton14.Text, write[0]) && radioButton14.Checked == true || lol.PravOtvet(radioButton15.Text, write[0]) && radioButton15.Checked == true ||
                lol.PravOtvet(radioButton16.Text, write[0]) && radioButton16.Checked == true)
                {
                    ++result;
                }
            }
            radPageViewPage4.Enabled = false;  
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            if (radCheckBox17.Visible == true && radCheckBox18.Visible == true && radCheckBox19.Visible == true && radCheckBox20.Visible == true)
            {
                if (lol.PravOtvet(radCheckBox17.Text, write[0]) && radCheckBox17.Checked == true && lol.PravOtvet(radCheckBox18.Text, write[0]) && radCheckBox18.Checked == true || lol.PravOtvet(radCheckBox17.Text, write[0]) && radCheckBox17.Checked == true && lol.PravOtvet(radCheckBox19.Text, write[0]) && radCheckBox19.Checked == true ||
               lol.PravOtvet(radCheckBox17.Text, write[0]) && radCheckBox17.Checked == true && lol.PravOtvet(radCheckBox20.Text, write[0]) && radCheckBox20.Checked == true || lol.PravOtvet(radCheckBox18.Text, write[0]) && radCheckBox18.Checked == true && lol.PravOtvet(radCheckBox19.Text, write[0]) && radCheckBox19.Checked == true ||
               lol.PravOtvet(radCheckBox18.Text, write[0]) && radCheckBox18.Checked == true && lol.PravOtvet(radCheckBox20.Text, write[0]) && radCheckBox20.Checked == true || lol.PravOtvet(radCheckBox19.Text, write[0]) && radCheckBox19.Checked == true && lol.PravOtvet(radCheckBox20.Text, write[0]) && radCheckBox20.Checked == true)
                 {
                     ++result;
                 }
            }
            else
            {
                if (lol.PravOtvet(radioButton17.Text, write[0]) && radioButton17.Checked == true || lol.PravOtvet(radioButton18.Text, write[0]) && radioButton18.Checked == true || lol.PravOtvet(radioButton19.Text, write[0]) && radioButton19.Checked == true ||
                lol.PravOtvet(radioButton20.Text, write[0]) && radioButton20.Checked == true)
                {
                    ++result;
                }
            }
            radPageViewPage5.Enabled = false;
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            if (radCheckBox21.Visible == true && radCheckBox22.Visible == true && radCheckBox23.Visible == true && radCheckBox24.Visible == true)
            {
                if (lol.PravOtvet(radCheckBox21.Text, write[0]) && radCheckBox21.Checked == true && lol.PravOtvet(radCheckBox22.Text, write[0]) && radCheckBox22.Checked == true || lol.PravOtvet(radCheckBox21.Text, write[0]) && radCheckBox21.Checked == true && lol.PravOtvet(radCheckBox23.Text, write[0]) && radCheckBox23.Checked == true ||
               lol.PravOtvet(radCheckBox21.Text, write[0]) && radCheckBox21.Checked == true && lol.PravOtvet(radCheckBox24.Text, write[0]) && radCheckBox24.Checked == true || lol.PravOtvet(radCheckBox22.Text, write[0]) && radCheckBox22.Checked == true && lol.PravOtvet(radCheckBox23.Text, write[0]) && radCheckBox23.Checked == true ||
               lol.PravOtvet(radCheckBox22.Text, write[0]) && radCheckBox22.Checked == true && lol.PravOtvet(radCheckBox24.Text, write[0]) && radCheckBox24.Checked == true || lol.PravOtvet(radCheckBox23.Text, write[0]) && radCheckBox23.Checked == true && lol.PravOtvet(radCheckBox24.Text, write[0]) && radCheckBox24.Checked == true)
                 {
                     ++result;
                 }
            }
            else
            {
                if (lol.PravOtvet(radioButton21.Text, write[0]) && radioButton21.Checked == true || lol.PravOtvet(radioButton22.Text, write[0]) && radioButton22.Checked == true || lol.PravOtvet(radioButton23.Text, write[0]) && radioButton23.Checked == true ||
                lol.PravOtvet(radioButton24.Text, write[0]) && radioButton24.Checked == true)
                {
                    ++result;
                }
            }
            radPageViewPage6.Enabled = false;
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            if (radCheckBox25.Visible == true && radCheckBox26.Visible == true && radCheckBox27.Visible == true && radCheckBox28.Visible == true)
            {
                if (lol.PravOtvet(radCheckBox25.Text, write[0]) && radCheckBox25.Checked == true && lol.PravOtvet(radCheckBox26.Text, write[0]) && radCheckBox26.Checked == true || lol.PravOtvet(radCheckBox25.Text, write[0]) && radCheckBox25.Checked == true && lol.PravOtvet(radCheckBox27.Text, write[0]) && radCheckBox27.Checked == true ||
              lol.PravOtvet(radCheckBox25.Text, write[0]) && radCheckBox25.Checked == true && lol.PravOtvet(radCheckBox28.Text, write[0]) && radCheckBox28.Checked == true || lol.PravOtvet(radCheckBox26.Text, write[0]) && radCheckBox26.Checked == true && lol.PravOtvet(radCheckBox27.Text, write[0]) && radCheckBox27.Checked == true ||
              lol.PravOtvet(radCheckBox26.Text, write[0]) && radCheckBox26.Checked == true && lol.PravOtvet(radCheckBox28.Text, write[0]) && radCheckBox28.Checked == true || lol.PravOtvet(radCheckBox27.Text, write[0]) && radCheckBox27.Checked == true && lol.PravOtvet(radCheckBox28.Text, write[0]) && radCheckBox28.Checked == true)
                {
                    ++result;
                }
            }
            else
            {
                if (lol.PravOtvet(radioButton25.Text, write[0]) && radioButton25.Checked == true || lol.PravOtvet(radioButton26.Text, write[0]) && radioButton26.Checked == true || lol.PravOtvet(radioButton27.Text, write[0]) && radioButton27.Checked == true ||
                lol.PravOtvet(radioButton28.Text, write[0]) && radioButton28.Checked == true)
                {
                    ++result;
                }
            }
            radPageViewPage7.Enabled = false;
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            if (radCheckBox29.Visible == true && radCheckBox30.Visible == true && radCheckBox31.Visible == true && radCheckBox32.Visible == true)
            {
                if (lol.PravOtvet(radCheckBox29.Text, write[0]) && radCheckBox29.Checked == true && lol.PravOtvet(radCheckBox30.Text, write[0]) && radCheckBox30.Checked == true || lol.PravOtvet(radCheckBox29.Text, write[0]) && radCheckBox29.Checked == true && lol.PravOtvet(radCheckBox31.Text, write[0]) && radCheckBox31.Checked == true ||
              lol.PravOtvet(radCheckBox29.Text, write[0]) && radCheckBox29.Checked == true && lol.PravOtvet(radCheckBox32.Text, write[0]) && radCheckBox32.Checked == true || lol.PravOtvet(radCheckBox30.Text, write[0]) && radCheckBox30.Checked == true && lol.PravOtvet(radCheckBox31.Text, write[0]) && radCheckBox31.Checked == true ||
              lol.PravOtvet(radCheckBox30.Text, write[0]) && radCheckBox30.Checked == true && lol.PravOtvet(radCheckBox32.Text, write[0]) && radCheckBox32.Checked == true || lol.PravOtvet(radCheckBox31.Text, write[0]) && radCheckBox31.Checked == true && lol.PravOtvet(radCheckBox32.Text, write[0]) && radCheckBox32.Checked == true)
                  {
                      ++result;
                  }
            }
            else
            {
                if (lol.PravOtvet(radioButton29.Text, write[0]) && radioButton29.Checked == true || lol.PravOtvet(radioButton30.Text, write[0]) && radioButton30.Checked == true || lol.PravOtvet(radioButton31.Text, write[0]) && radioButton31.Checked == true ||
                lol.PravOtvet(radioButton32.Text, write[0]) && radioButton32.Checked == true)
                {
                    ++result; 
                }
            }
            radPageViewPage8.Enabled = false;
        }

        private void radButton9_Click(object sender, EventArgs e)
        {
            if (radCheckBox33.Visible == true && radCheckBox34.Visible == true && radCheckBox35.Visible == true && radCheckBox36.Visible == true)
            {
                if(lol.PravOtvet(radCheckBox33.Text, write[0]) && radCheckBox33.Checked == true && lol.PravOtvet(radCheckBox34.Text, write[0]) && radCheckBox34.Checked == true || lol.PravOtvet(radCheckBox33.Text, write[0]) && radCheckBox33.Checked == true && lol.PravOtvet(radCheckBox35.Text, write[0]) && radCheckBox35.Checked == true ||
               lol.PravOtvet(radCheckBox33.Text, write[0]) && radCheckBox33.Checked == true && lol.PravOtvet(radCheckBox36.Text, write[0]) && radCheckBox36.Checked == true || lol.PravOtvet(radCheckBox34.Text, write[0]) && radCheckBox34.Checked == true && lol.PravOtvet(radCheckBox35.Text, write[0]) && radCheckBox35.Checked == true ||
               lol.PravOtvet(radCheckBox34.Text, write[0]) && radCheckBox34.Checked == true && lol.PravOtvet(radCheckBox36.Text, write[0]) && radCheckBox36.Checked == true || lol.PravOtvet(radCheckBox35.Text, write[0]) && radCheckBox35.Checked == true && lol.PravOtvet(radCheckBox36.Text, write[0]) && radCheckBox36.Checked == true)
                  {
                      ++result;
                  }
            }
            else
            {
                if (lol.PravOtvet(radioButton33.Text, write[0]) && radioButton33.Checked == true || lol.PravOtvet(radioButton34.Text, write[0]) && radioButton34.Checked == true || lol.PravOtvet(radioButton35.Text, write[0]) && radioButton35.Checked == true ||
                lol.PravOtvet(radioButton36.Text, write[0]) && radioButton36.Checked == true)
                {
                    ++result;
                }
            }
            radPageViewPage9.Enabled = false;
        }

        private void radButton10_Click(object sender, EventArgs e)
        {
            if (radCheckBox37.Visible == true && radCheckBox38.Visible == true && radCheckBox39.Visible == true && radCheckBox40.Visible == true)
            {
                if (lol.PravOtvet(radCheckBox37.Text, write[0]) && radCheckBox37.Checked == true && lol.PravOtvet(radCheckBox38.Text, write[0]) && radCheckBox38.Checked == true || lol.PravOtvet(radCheckBox37.Text, write[0]) && radCheckBox37.Checked == true && lol.PravOtvet(radCheckBox39.Text, write[0]) && radCheckBox39.Checked == true ||
               lol.PravOtvet(radCheckBox37.Text, write[0]) && radCheckBox37.Checked == true && lol.PravOtvet(radCheckBox40.Text, write[0]) && radCheckBox40.Checked == true || lol.PravOtvet(radCheckBox38.Text, write[0]) && radCheckBox38.Checked == true && lol.PravOtvet(radCheckBox39.Text, write[0]) && radCheckBox39.Checked == true ||
               lol.PravOtvet(radCheckBox38.Text, write[0]) && radCheckBox38.Checked == true && lol.PravOtvet(radCheckBox40.Text, write[0]) && radCheckBox40.Checked == true || lol.PravOtvet(radCheckBox39.Text, write[0]) && radCheckBox39.Checked == true && lol.PravOtvet(radCheckBox40.Text, write[0]) && radCheckBox40.Checked == true)
                 {
                     ++result;
                 }
            }
            else
            {
                if (lol.PravOtvet(radioButton37.Text, write[0]) && radioButton37.Checked == true || lol.PravOtvet(radioButton38.Text, write[0]) && radioButton38.Checked == true || lol.PravOtvet(radioButton39.Text, write[0]) && radioButton39.Checked == true ||
                lol.PravOtvet(radioButton40.Text, write[0]) && radioButton40.Checked == true)
                {
                    ++result; 
                }
            }
            radPageViewPage10.Enabled = false;
            ResultForms ff = new ResultForms(result,nameAutoriseishen);
            ff.ShowDialog();
            this.Close();
            lol.SaveResult(result,lol.SelName(nameAutoriseishen),lol.SelTs(str1),DateTime.Now);

        }
       
    }
}
