namespace OKP_ZKI
{
    partial class InformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dataBaseZKIDataSet = new OKP_ZKI.DataBaseZKIDataSet();
            this.textsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textsTableAdapter = new OKP_ZKI.DataBaseZKIDataSetTableAdapters.TextsTableAdapter();
            this.btnTest = new Telerik.WinControls.UI.RadButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseZKIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTest)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 31);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(270, 543);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(315, 31);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(490, 554);
            this.webBrowser1.TabIndex = 1;
            // 
            // dataBaseZKIDataSet
            // 
            this.dataBaseZKIDataSet.DataSetName = "DataBaseZKIDataSet";
            this.dataBaseZKIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textsBindingSource
            // 
            this.textsBindingSource.DataMember = "Texts";
            this.textsBindingSource.DataSource = this.dataBaseZKIDataSet;
            // 
            // textsTableAdapter
            // 
            this.textsTableAdapter.ClearBeforeFill = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(814, 539);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(76, 34);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Пройти тест";
            this.btnTest.ThemeName = "VisualStudio2012Light";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.администраторToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // администраторToolStripMenuItem
            // 
            this.администраторToolStripMenuItem.Name = "администраторToolStripMenuItem";
            this.администраторToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.администраторToolStripMenuItem.Text = "Администратор";
            this.администраторToolStripMenuItem.Click += new System.EventHandler(this.администраторToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 591);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InformationForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "InformationForm";
            this.ThemeName = "VisualStudio2012Light";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InformationForm_FormClosed);
            this.Load += new System.EventHandler(this.InformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseZKIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTest)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DataBaseZKIDataSet dataBaseZKIDataSet;
        private System.Windows.Forms.BindingSource textsBindingSource;
        private DataBaseZKIDataSetTableAdapters.TextsTableAdapter textsTableAdapter;
        private Telerik.WinControls.UI.RadButton btnTest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}
