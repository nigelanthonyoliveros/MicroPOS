using MaterialSkin;
using MaterialSkin.Controls;
using POS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Utils
{
    public partial class UserConfirmMessageBox : MaterialForm
    {
        private string Message { get; set; }

        public UserConfirmMessageBox(string message,string No = "Cancel", string Yes= "Confirm")
        {
            this.ActivateSkin();
            InitializeComponent();
            this.FormStyle = FormStyles.ActionBar_None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.Size = new Size(400, 150);
            this.Sizable = false;
            this.ShowInTaskbar = false;
            
            Message=message;
            lblMessage.Text = message;
            btnNo.Text = No;
            btnYes.Text = Yes;
            

            this.Show();

        }
         ~UserConfirmMessageBox()
        {
            this.Message =string.Empty;
            this.Hide();
            this.Close();
        }


    }
}
