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

namespace POS
{
    public partial class Loading : MaterialForm
    {
        public Loading()
        {
            InitializeComponent();
            this.ActivateSkin();
            this.ShowInTaskbar = false;
            this.ControlBox = true;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            
        }
    }
}
