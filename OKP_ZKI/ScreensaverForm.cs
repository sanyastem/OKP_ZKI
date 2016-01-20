using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace OKP_ZKI
{
    public partial class ScreensaverForm : Telerik.WinControls.UI.RadForm
    {
        public ScreensaverForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            Autorizaishen form = new Autorizaishen();
            form.Show();
            this.Hide();
            timer1.Enabled = false;

        }
    }
}
