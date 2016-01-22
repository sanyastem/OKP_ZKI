namespace OKP_ZKI
{
    partial class Autorizaishen
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
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.Logintxt = new Telerik.WinControls.UI.RadTextBox();
            this.Passwordtxt = new Telerik.WinControls.UI.RadTextBox();
            this.AutorizeishenBtn = new Telerik.WinControls.UI.RadButton();
            this.Registration = new Telerik.WinControls.UI.RadButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radLabel19 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Logintxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Passwordtxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutorizeishenBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registration)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Logintxt
            // 
            this.Logintxt.Location = new System.Drawing.Point(72, 33);
            this.Logintxt.Name = "Logintxt";
            this.Logintxt.Size = new System.Drawing.Size(137, 24);
            this.Logintxt.TabIndex = 0;
            this.Logintxt.ThemeName = "VisualStudio2012Light";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(72, 63);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(137, 24);
            this.Passwordtxt.TabIndex = 1;
            this.Passwordtxt.Tag = "";
            this.Passwordtxt.ThemeName = "VisualStudio2012Light";
            // 
            // AutorizeishenBtn
            // 
            this.AutorizeishenBtn.Location = new System.Drawing.Point(89, 93);
            this.AutorizeishenBtn.Name = "AutorizeishenBtn";
            this.AutorizeishenBtn.Size = new System.Drawing.Size(110, 24);
            this.AutorizeishenBtn.TabIndex = 2;
            this.AutorizeishenBtn.Text = "Вход";
            this.AutorizeishenBtn.ThemeName = "VisualStudio2012Light";
            this.AutorizeishenBtn.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(89, 148);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(110, 24);
            this.Registration.TabIndex = 3;
            this.Registration.Text = "Регистрация";
            this.Registration.ThemeName = "VisualStudio2012Light";
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 4;
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
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
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
            // radLabel19
            // 
            this.radLabel19.Location = new System.Drawing.Point(12, 34);
            this.radLabel19.Name = "radLabel19";
            this.radLabel19.Size = new System.Drawing.Size(38, 18);
            this.radLabel19.TabIndex = 14;
            this.radLabel19.Text = "Логин";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 64);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(45, 18);
            this.radLabel1.TabIndex = 14;
            this.radLabel1.Text = "Пароль";
            // 
            // Autorizaishen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(292, 184);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radLabel19);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.AutorizeishenBtn);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Logintxt);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Autorizaishen";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.Logintxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Passwordtxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutorizeishenBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registration)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadTextBox Logintxt;
        private Telerik.WinControls.UI.RadTextBox Passwordtxt;
        private Telerik.WinControls.UI.RadButton AutorizeishenBtn;
        private Telerik.WinControls.UI.RadButton Registration;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private Telerik.WinControls.UI.RadLabel radLabel19;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}