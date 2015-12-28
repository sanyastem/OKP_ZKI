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
    public partial class InformationForm : Telerik.WinControls.UI.RadForm
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseZKIDataSet.Texts". При необходимости она может быть перемещена или удалена.
            this.textsTableAdapter.Fill(this.dataBaseZKIDataSet.Texts);
            treeView1.Nodes.Clear();
            using (SqlConnection db = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True"))
            {
                db.Open();
                SqlCommand one = new SqlCommand("SELECT Sections.Section,Subjects.Subject,Texts.titles FROM Sections,Subjects,Texts"
+ " WHERE Sections.id_section = Subjects.id_section AND Subjects.id_subject = Texts.id_subject",db);
                SqlDataReader two = one.ExecuteReader();
                while (two.Read())
                {
                    TreeNode node = new TreeNode(two["Subject"].ToString());
                    node.Nodes.Add(two["titles"].ToString());
                    treeView1.Nodes.Add(node);
                }
                db.Close();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SqlConnection db = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True");
             
                 db.Open();
                 
                     string zapros = string.Format("SELECT Texts.Text FROM Sections,Subjects,Texts"
 +" WHERE Sections.id_section = Subjects.id_section AND Subjects.id_subject = Texts.id_subject"
 +" AND Texts.titles = '{0}'",e.Node.Text.ToString());
                     SqlCommand a = new SqlCommand(zapros, db);
                     
            string n = (string)a.ExecuteScalar();
            webBrowser1.Navigate(n);
                     

                 
                 
        }

        private void InformationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
