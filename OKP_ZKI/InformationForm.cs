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
            treeView1.Nodes.Clear();
            using (SqlConnection db = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=DataBaseZKI;Integrated Security=True"))
            {
                db.Open();
                SqlCommand one = new SqlCommand("SELECT Sections.Section,Subjects.Subject,Texts.titles FROM Sections,Subjects,Texts"
+ " WHERE Sections.id_section = Subjects.id_section AND Subjects.id_subject = Texts.id_subject",db);
                SqlDataReader two = one.ExecuteReader();
                while (two.Read())
                {
                    TreeNode node = new TreeNode(two["Section"].ToString());
                    node.Nodes.Add(two["Subject"].ToString());
                    node.Nodes.Add(two["titles"].ToString());
                    treeView1.Nodes.Add(node);
                }
                db.Close();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
    }
}
