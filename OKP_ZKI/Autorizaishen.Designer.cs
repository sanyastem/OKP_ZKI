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
            ((System.ComponentModel.ISupportInitialize)(this.Logintxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Passwordtxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutorizeishenBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registration)).BeginInit();
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
            // Autorizaishen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 184);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.AutorizeishenBtn);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Logintxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Autorizaishen";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Авторизация";
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.Logintxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Passwordtxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutorizeishenBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registration)).EndInit();
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
    }
}