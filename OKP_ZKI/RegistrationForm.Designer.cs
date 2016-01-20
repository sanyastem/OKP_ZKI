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
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword_one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword_two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(45, 116);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(101, 24);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "Зарегистрировать";
            this.btnRegistration.ThemeName = "VisualStudio2012Light";
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(28, 12);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(118, 24);
            this.txtlogin.TabIndex = 1;
            this.txtlogin.ThemeName = "VisualStudio2012Light";
            // 
            // txtPassword_one
            // 
            this.txtPassword_one.Location = new System.Drawing.Point(28, 42);
            this.txtPassword_one.Name = "txtPassword_one";
            this.txtPassword_one.Size = new System.Drawing.Size(118, 24);
            this.txtPassword_one.TabIndex = 1;
            this.txtPassword_one.ThemeName = "VisualStudio2012Light";
            // 
            // txtPassword_two
            // 
            this.txtPassword_two.Location = new System.Drawing.Point(28, 72);
            this.txtPassword_two.Name = "txtPassword_two";
            this.txtPassword_two.Size = new System.Drawing.Size(118, 24);
            this.txtPassword_two.TabIndex = 1;
            this.txtPassword_two.ThemeName = "VisualStudio2012Light";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 186);
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
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnRegistration;
        private Telerik.WinControls.UI.RadTextBox txtlogin;
        private Telerik.WinControls.UI.RadTextBox txtPassword_one;
        private Telerik.WinControls.UI.RadTextBox txtPassword_two;
    }
}
