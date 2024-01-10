
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using POS.Contracts;
using POS.Domains.Categories;
using POS.Domains.Items;
using POS.Services;
using POS.Utils;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace POS
{
    public partial class MainForm : MaterialForm
    {
        private readonly ILogger<MainForm> _logger;
        private readonly POSService pOSService;
        private readonly ApplicationDBContext dBContext;

        Loading loadingSplash = new Loading()
        {
            Dock = DockStyle.Fill,
            StartPosition = FormStartPosition.CenterScreen,
            TopLevel = true
        };

        public  MainForm(ILogger<MainForm> logger, POSService pOSService, ApplicationDBContext dBContext)
        {
            InitializeComponent();

            this.ActivateSkin(MaterialSkinManager.Themes.LIGHT); // Sets the initial theme of the app to light

            dynamic confobject = ConfigurationManager.GetSection("appSettings");

            this._logger = logger;
            this.pOSService=pOSService;
            this.dBContext=dBContext;
           
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            await Form1_LoadAsync(sender, e);
        }
        private async Task Form1_LoadAsync(object sender, EventArgs e)
        {
            this.DashboardTabControl.Alignment = TabAlignment.Top;
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


            //await pOSService(new Category() { Name = "Perishable", Description = "Perishable items" });




            // Example data
            var salesData = new int[] { 4000, 15000, 4000, 4311, 4211, 1000 };
            var salesData1 = new int[] { 4000, 15000, 4000, 4311, 4211, 1000, 3200 };

            // Clear existing data
            SalesChart.Series.Clear();

            // Add a new series
            Series series = new Series("SalesData");
            Series series1 = new Series("SalesData1");

            series.ChartType = SeriesChartType.Column; // Choose the chart type

            // Add data points
            for (int i = 0; i < salesData.Length; i++)
            {
                series.Points.AddXY($"Month {i + 1}", salesData[i]);
            }
            for (int i = 0; i < salesData1.Length; i++)
            {
                series.Points.AddXY($"Month {i + 1}", salesData1[i]);
            }


            // Add the series to the chart
            SalesChart.Series.Add(series);
            SalesChart.Series.Add(series1);

            categorycb.DataSource = await pOSService.GetAllCategoriesAsync();

            categorycb.DisplayMember = "Name";
            categorycb.ValueMember = "CategoryID";
            categorycb.SelectedText = "Category";
            categorycb.SelectedValue = "00000000-0000-0000-0000-000000000000";
            await RefreshData();
        }

        private async Task RefreshData()
        {
              datatableForProducts.DataSource= await pOSService.GetAllAvailableProducts(false);
        }
        private async void DarkModeToggle(object sender, EventArgs e)
        {
            if (loadingSplash.Visible == true)
            {
                loadingSplash.Hide();
            }
            loadingSplash.TopMost = true;
            loadingSplash.Show();


            if (darkModeswitch.CheckState == CheckState.Unchecked)
            {
                this.ActivateSkin(MaterialSkinManager.Themes.LIGHT);


            }
            else
            {
                this.ActivateSkin(MaterialSkinManager.Themes.DARK);
            }

            await Task.Delay(500);
            loadingSplash.Hide();
        }

        private async void materialButton1_ClickAsync(object sender, EventArgs e)
        {
            //UserConfirmMessageBox uc = new UserConfirmMessageBox("Are you sure you want to add this product?");

            Product product = new Product
            {
                ProductName = txtProductName.Text,
                ProductDescription = txtProductDescription.Text,
                Available= checkBoxIsAvailable.Checked,
                ProductPrice = Convert.ToDecimal(txtPrice.Text),
                SKU = txtSKU.Text,
                CategoryID = new Guid(categorycb.SelectedValue.ToString() ?? ""),
            };

            await pOSService.AddProduct(product);
           await RefreshData();
        }

        private void categorycb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categorycb.SelectedValue is null)
            {
                CategoryIDbind.Text = string.Empty;
            }
            else
            {
                CategoryIDbind.Text = categorycb.SelectedValue.ToString();
            }

        }

        
    }
}
