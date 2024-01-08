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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DashboardTabControl = new MaterialSkin.Controls.MaterialTabControl();
            homeTab = new TabPage();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialProgressBar2 = new MaterialSkin.Controls.MaterialProgressBar();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            lblSalesToday = new MaterialSkin.Controls.MaterialLabel();
            inventoryTab = new TabPage();
            salesTab = new TabPage();
            miscTab = new TabPage();
            usersTab = new TabPage();
            imageList1 = new ImageList(components);
            DashboardTabControl.SuspendLayout();
            homeTab.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
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
            DashboardTabControl.Size = new Size(1021, 554);
            DashboardTabControl.TabIndex = 0;
            // 
            // homeTab
            // 
            homeTab.Controls.Add(materialCard2);
            homeTab.Controls.Add(materialCard1);
            homeTab.ImageKey = "home_FILL0_wght400_GRAD0_opsz24.png";
            homeTab.Location = new Point(4, 42);
            homeTab.Name = "homeTab";
            homeTab.Padding = new Padding(3);
            homeTab.Size = new Size(1013, 508);
            homeTab.TabIndex = 0;
            homeTab.Text = "Home";
            homeTab.ToolTipText = "Home";
            homeTab.UseVisualStyleBackColor = true;
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
            inventoryTab.Size = new Size(1013, 508);
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
            salesTab.Size = new Size(1013, 508);
            salesTab.TabIndex = 2;
            salesTab.Text = "Sales";
            salesTab.UseVisualStyleBackColor = true;
            // 
            // miscTab
            // 
            miscTab.ImageKey = "category_FILL0_wght400_GRAD0_opsz24.png";
            miscTab.Location = new Point(4, 42);
            miscTab.Name = "miscTab";
            miscTab.Size = new Size(1013, 508);
            miscTab.TabIndex = 3;
            miscTab.Text = "Miscellenous";
            miscTab.UseVisualStyleBackColor = true;
            // 
            // usersTab
            // 
            usersTab.ImageKey = "manage_accounts_FILL0_wght400_GRAD0_opsz24.png";
            usersTab.Location = new Point(4, 42);
            usersTab.Name = "usersTab";
            usersTab.Size = new Size(1013, 508);
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
            ClientSize = new Size(1027, 621);
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
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
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
    }
}
