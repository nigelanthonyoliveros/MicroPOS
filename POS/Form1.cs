
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.Logging;
using POS.Contracts;
using POS.Services;
using System.Configuration;

namespace POS
{
    public partial class MainForm : MaterialForm
    {
        private readonly ILogger<MainForm> _logger;
        private readonly IPOSService pOSService;

        public MainForm(ILogger<MainForm> logger, IPOSService pOSService)
        {
            InitializeComponent();

            this.ActivateSkin();

            dynamic confobject = ConfigurationManager.GetSection("appSettings");

            this._logger = logger;
            this.pOSService=pOSService;


          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _logger.LogTrace("Form1 has been loaded");
            #region Random Value 

            materialProgressBar1.Style = ProgressBarStyle.Marquee;
            materialProgressBar1.MarqueeAnimationSpeed = 5000;
            //materialProgressBar1.MarqueeAnimationSpeed = 1;


            var randomvalue = (double)new Random().Next(1, 10000);
            var randomvalue2 = (double)new Random().Next(1, 10000);

            lblSalesToday.Text = $"Php {randomvalue.ToString()}";

            materialProgressBar1.Value = Convert.ToInt32(randomvalue);

            materialLabel1.Text = $"Php {randomvalue2.ToString()}";

            materialProgressBar2.Value = Convert.ToInt32(randomvalue2);
            #endregion

        }




    }
}
