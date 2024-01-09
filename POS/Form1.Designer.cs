namespace POS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DashboardTabControl = new MaterialSkin.Controls.MaterialTabControl();
            homeTab = new TabPage();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            SalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialProgressBar2 = new MaterialSkin.Controls.MaterialProgressBar();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            lblSalesToday = new MaterialSkin.Controls.MaterialLabel();
            inventoryTab = new TabPage();
            salesTab = new TabPage();
            miscTab = new TabPage();
            darkModeswitch = new MaterialSkin.Controls.MaterialSwitch();
            usersTab = new TabPage();
            imageList1 = new ImageList(components);
            DashboardTabControl.SuspendLayout();
            homeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalesChart).BeginInit();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            miscTab.SuspendLayout();
            SuspendLayout();
            // 
            // DashboardTabControl
            // 
            DashboardTabControl.Appearance = TabAppearance.FlatButtons;
            DashboardTabControl.CausesValidation = false;
            DashboardTabControl.Controls.Add(homeTab);
            DashboardTabControl.Controls.Add(inventoryTab);
            DashboardTabControl.Controls.Add(salesTab);
            DashboardTabControl.Controls.Add(miscTab);
            DashboardTabControl.Controls.Add(usersTab);
            DashboardTabControl.Depth = 0;
            DashboardTabControl.Dock = DockStyle.Fill;
            DashboardTabControl.HotTrack = true;
            DashboardTabControl.ImageList = imageList1;
            DashboardTabControl.Location = new Point(3, 64);
            DashboardTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            DashboardTabControl.Multiline = true;
            DashboardTabControl.Name = "DashboardTabControl";
            DashboardTabControl.SelectedIndex = 0;
            DashboardTabControl.ShowToolTips = true;
            DashboardTabControl.Size = new Size(1164, 638);
            DashboardTabControl.TabIndex = 0;
            // 
            // homeTab
            // 
            homeTab.Controls.Add(materialDivider1);
            homeTab.Controls.Add(SalesChart);
            homeTab.Controls.Add(materialCard2);
            homeTab.Controls.Add(materialCard1);
            homeTab.ImageKey = "home_FILL0_wght400_GRAD0_opsz24.png";
            homeTab.Location = new Point(4, 42);
            homeTab.Name = "homeTab";
            homeTab.Padding = new Padding(3);
            homeTab.Size = new Size(1156, 592);
            homeTab.TabIndex = 0;
            homeTab.Text = "Home";
            homeTab.ToolTipText = "Home";
            homeTab.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(27, 165);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(1126, 10);
            materialDivider1.TabIndex = 3;
            materialDivider1.Text = "materialDivider1";
            // 
            // SalesChart
            // 
            chartArea1.Name = "ChartArea1";
            SalesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            SalesChart.Legends.Add(legend1);
            SalesChart.Location = new Point(27, 181);
            SalesChart.Name = "SalesChart";
            SalesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            SalesChart.Series.Add(series1);
            SalesChart.Size = new Size(796, 370);
            SalesChart.TabIndex = 2;
            SalesChart.Text = "chart1";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(materialProgressBar2);
            materialCard2.Controls.Add(materialLabel1);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(439, 26);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(384, 138);
            materialCard2.TabIndex = 1;
            // 
            // materialProgressBar2
            // 
            materialProgressBar2.Depth = 0;
            materialProgressBar2.Location = new Point(17, 75);
            materialProgressBar2.Maximum = 10000;
            materialProgressBar2.MouseState = MaterialSkin.MouseState.HOVER;
            materialProgressBar2.Name = "materialProgressBar2";
            materialProgressBar2.Size = new Size(350, 5);
            materialProgressBar2.Step = 1;
            materialProgressBar2.Style = ProgressBarStyle.Marquee;
            materialProgressBar2.TabIndex = 1;
            materialProgressBar2.Value = 1000;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            materialLabel1.HighEmphasis = true;
            materialLabel1.Location = new Point(17, 14);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(280, 58);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Php 1,000.00";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialProgressBar1);
            materialCard1.Controls.Add(lblSalesToday);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(27, 26);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(384, 138);
            materialCard1.TabIndex = 0;
            // 
            // materialProgressBar1
            // 
            materialProgressBar1.Depth = 0;
            materialProgressBar1.Location = new Point(17, 75);
            materialProgressBar1.MarqueeAnimationSpeed = 500;
            materialProgressBar1.Maximum = 10000;
            materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            materialProgressBar1.Name = "materialProgressBar1";
            materialProgressBar1.Size = new Size(350, 5);
            materialProgressBar1.Step = 1;
            materialProgressBar1.Style = ProgressBarStyle.Marquee;
            materialProgressBar1.TabIndex = 1;
            // 
            // lblSalesToday
            // 
            lblSalesToday.AutoSize = true;
            lblSalesToday.Depth = 0;
            lblSalesToday.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSalesToday.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblSalesToday.HighEmphasis = true;
            lblSalesToday.Location = new Point(17, 14);
            lblSalesToday.MouseState = MaterialSkin.MouseState.HOVER;
            lblSalesToday.Name = "lblSalesToday";
            lblSalesToday.Size = new Size(280, 58);
            lblSalesToday.TabIndex = 0;
            lblSalesToday.Text = "Php 1,000.00";
            // 
            // inventoryTab
            // 
            inventoryTab.ImageKey = "store_FILL0_wght400_GRAD0_opsz24.png";
            inventoryTab.Location = new Point(4, 42);
            inventoryTab.Name = "inventoryTab";
            inventoryTab.Padding = new Padding(3);
            inventoryTab.Size = new Size(1156, 592);
            inventoryTab.TabIndex = 1;
            inventoryTab.Text = "Inventory";
            inventoryTab.ToolTipText = "Inventory";
            inventoryTab.UseVisualStyleBackColor = true;
            // 
            // salesTab
            // 
            salesTab.ImageKey = "payments_FILL0_wght400_GRAD0_opsz24.png";
            salesTab.Location = new Point(4, 42);
            salesTab.Name = "salesTab";
            salesTab.Size = new Size(1156, 592);
            salesTab.TabIndex = 2;
            salesTab.Text = "Sales";
            salesTab.UseVisualStyleBackColor = true;
            // 
            // miscTab
            // 
            miscTab.Controls.Add(darkModeswitch);
            miscTab.ImageKey = "category_FILL0_wght400_GRAD0_opsz24.png";
            miscTab.Location = new Point(4, 42);
            miscTab.Name = "miscTab";
            miscTab.Size = new Size(1156, 592);
            miscTab.TabIndex = 3;
            miscTab.Text = "Miscellenous";
            miscTab.UseVisualStyleBackColor = true;
            // 
            // darkModeswitch
            // 
            darkModeswitch.AutoSize = true;
            darkModeswitch.BackgroundImage = (Image)resources.GetObject("darkModeswitch.BackgroundImage");
            darkModeswitch.Depth = 0;
            darkModeswitch.Location = new Point(24, 22);
            darkModeswitch.Margin = new Padding(0);
            darkModeswitch.MouseLocation = new Point(-1, -1);
            darkModeswitch.MouseState = MaterialSkin.MouseState.HOVER;
            darkModeswitch.Name = "darkModeswitch";
            darkModeswitch.Ripple = true;
            darkModeswitch.Size = new Size(135, 37);
            darkModeswitch.TabIndex = 2;
            darkModeswitch.Text = "Dark Mode";
            darkModeswitch.UseVisualStyleBackColor = true;
            darkModeswitch.CheckedChanged += DarkModeToggle;
            // 
            // usersTab
            // 
            usersTab.ImageKey = "manage_accounts_FILL0_wght400_GRAD0_opsz24.png";
            usersTab.Location = new Point(4, 42);
            usersTab.Name = "usersTab";
            usersTab.Size = new Size(1156, 592);
            usersTab.TabIndex = 4;
            usersTab.Text = "Users";
            usersTab.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "account_circle_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(1, "category_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(2, "currency_ruble_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(3, "home_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(4, "manage_accounts_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(5, "payments_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(6, "shopping_cart_FILL0_wght400_GRAD0_opsz24.png");
            imageList1.Images.SetKeyName(7, "store_FILL0_wght400_GRAD0_opsz24.png");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1170, 705);
            Controls.Add(DashboardTabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = DashboardTabControl;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Micro POS";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            DashboardTabControl.ResumeLayout(false);
            homeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SalesChart).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            miscTab.ResumeLayout(false);
            miscTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl DashboardTabControl;
        private TabPage homeTab;
        private TabPage inventoryTab;
        private ImageList imageList1;
        private TabPage salesTab;
        private TabPage miscTab;
        private TabPage usersTab;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialLabel lblSalesToday;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesChart;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSwitch darkModeswitch;
    }
}
