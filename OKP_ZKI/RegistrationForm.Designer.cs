namespace OKP_ZKI
{
    partial class RegistrationForm
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
            this.btnRegistration = new Telerik.WinControls.UI.RadButton();
            this.txtlogin = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword_one = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword_two = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword_one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword_two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(45, 163);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(101, 24);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "Зарегистрировать";
            this.btnRegistration.ThemeName = "VisualStudio2012Light";
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(28, 23);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(135, 24);
            this.txtlogin.TabIndex = 1;
            this.txtlogin.ThemeName = "VisualStudio2012Light";
            // 
            // txtPassword_one
            // 
            this.txtPassword_one.Location = new System.Drawing.Point(28, 79);
            this.txtPassword_one.Name = "txtPassword_one";
            this.txtPassword_one.Size = new System.Drawing.Size(135, 24);
            this.txtPassword_one.TabIndex = 1;
            this.txtPassword_one.ThemeName = "VisualStudio2012Light";
            // 
            // txtPassword_two
            // 
            this.txtPassword_two.Location = new System.Drawing.Point(28, 133);
            this.txtPassword_two.Name = "txtPassword_two";
            this.txtPassword_two.Size = new System.Drawing.Size(135, 24);
            this.txtPassword_two.TabIndex = 1;
            this.txtPassword_two.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(69, -1);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(38, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Логин";
            this.radLabel1.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(62, 55);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(45, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Пароль";
            this.radLabel2.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(45, 109);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(102, 18);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Повторить пароль";
            this.radLabel3.ThemeName = "VisualStudio2012Light";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 212);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtPassword_two);
            this.Controls.Add(this.txtPassword_one);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.btnRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistrationForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword_one)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword_two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnRegistration;
        private Telerik.WinControls.UI.RadTextBox txtlogin;
        private Telerik.WinControls.UI.RadTextBox txtPassword_one;
        private Telerik.WinControls.UI.RadTextBox txtPassword_two;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
