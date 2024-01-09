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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            dataGridView1 = new DataGridView();
            materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            CategoryIDbind = new MaterialSkin.Controls.MaterialLabel();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            imageList1 = new ImageList(components);
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            txtPrice = new MaterialSkin.Controls.MaterialTextBox2();
            txtSKU = new MaterialSkin.Controls.MaterialTextBox2();
            txtProductDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            txtProductName = new MaterialSkin.Controls.MaterialTextBox2();
            checkBoxIsAvailable = new MaterialSkin.Controls.MaterialCheckbox();
            categorycb = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            salesTab = new TabPage();
            miscTab = new TabPage();
            darkModeswitch = new MaterialSkin.Controls.MaterialSwitch();
            usersTab = new TabPage();
            DashboardTabControl.SuspendLayout();
            homeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalesChart).BeginInit();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            inventoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            materialCard3.SuspendLayout();
            miscTab.SuspendLayout();
            SuspendLayout();
            // 
            // DashboardTabControl
            // 
            DashboardTabControl.Appearance = TabAppearance.Buttons;
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
            DashboardTabControl.Size = new Size(1362, 741);
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
            homeTab.Size = new Size(1354, 695);
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
            materialDivider1.Size = new Size(1126, 11);
            materialDivider1.TabIndex = 3;
            materialDivider1.Text = "materialDivider1";
            // 
            // SalesChart
            // 
            chartArea2.Name = "ChartArea1";
            SalesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            SalesChart.Legends.Add(legend2);
            SalesChart.Location = new Point(27, 181);
            SalesChart.Name = "SalesChart";
            SalesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            SalesChart.Series.Add(series2);
            SalesChart.Size = new Size(795, 371);
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
            materialCard2.Location = new Point(439, 27);
            materialCard2.Margin = new Padding(14, 13, 14, 13);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14, 13, 14, 13);
            materialCard2.Size = new Size(384, 139);
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
            materialLabel1.Location = new Point(17, 13);
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
            materialCard1.Location = new Point(27, 27);
            materialCard1.Margin = new Padding(14, 13, 14, 13);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14, 13, 14, 13);
            materialCard1.Size = new Size(384, 139);
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
            lblSalesToday.Location = new Point(17, 13);
            lblSalesToday.MouseState = MaterialSkin.MouseState.HOVER;
            lblSalesToday.Name = "lblSalesToday";
            lblSalesToday.Size = new Size(280, 58);
            lblSalesToday.TabIndex = 0;
            lblSalesToday.Text = "Php 1,000.00";
            // 
            // inventoryTab
            // 
            inventoryTab.Controls.Add(dataGridView1);
            inventoryTab.Controls.Add(materialMaskedTextBox1);
            inventoryTab.Controls.Add(materialCard3);
            inventoryTab.ImageKey = "store_FILL0_wght400_GRAD0_opsz24.png";
            inventoryTab.Location = new Point(4, 42);
            inventoryTab.Name = "inventoryTab";
            inventoryTab.Padding = new Padding(3);
            inventoryTab.Size = new Size(1354, 695);
            inventoryTab.TabIndex = 1;
            inventoryTab.Text = "Inventory";
            inventoryTab.ToolTipText = "Inventory";
            inventoryTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(526, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(806, 509);
            dataGridView1.TabIndex = 2;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = null;
            materialMaskedTextBox1.Location = new Point(526, 21);
            materialMaskedTextBox1.Mask = "";
            materialMaskedTextBox1.MaxLength = 32767;
            materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            materialMaskedTextBox1.PasswordChar = '●';
            materialMaskedTextBox1.PrefixSuffixText = null;
            materialMaskedTextBox1.PromptChar = '_';
            materialMaskedTextBox1.ReadOnly = false;
            materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            materialMaskedTextBox1.ResetOnPrompt = true;
            materialMaskedTextBox1.ResetOnSpace = true;
            materialMaskedTextBox1.RightToLeft = RightToLeft.No;
            materialMaskedTextBox1.SelectedText = "";
            materialMaskedTextBox1.SelectionLength = 0;
            materialMaskedTextBox1.SelectionStart = 0;
            materialMaskedTextBox1.ShortcutsEnabled = true;
            materialMaskedTextBox1.Size = new Size(312, 36);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 1;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.Text = "password";
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = true;
            materialMaskedTextBox1.UseTallSize = false;
            materialMaskedTextBox1.ValidatingType = null;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(CategoryIDbind);
            materialCard3.Controls.Add(materialFloatingActionButton1);
            materialCard3.Controls.Add(materialButton2);
            materialCard3.Controls.Add(materialButton1);
            materialCard3.Controls.Add(txtPrice);
            materialCard3.Controls.Add(txtSKU);
            materialCard3.Controls.Add(txtProductDescription);
            materialCard3.Controls.Add(txtProductName);
            materialCard3.Controls.Add(checkBoxIsAvailable);
            materialCard3.Controls.Add(categorycb);
            materialCard3.Controls.Add(materialLabel2);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(11, 15);
            materialCard3.Margin = new Padding(14, 13, 14, 13);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14, 13, 14, 13);
            materialCard3.Size = new Size(483, 577);
            materialCard3.TabIndex = 0;
            // 
            // CategoryIDbind
            // 
            CategoryIDbind.AutoSize = true;
            CategoryIDbind.Depth = 0;
            CategoryIDbind.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            CategoryIDbind.Location = new Point(114, 9);
            CategoryIDbind.MouseState = MaterialSkin.MouseState.HOVER;
            CategoryIDbind.Name = "CategoryIDbind";
            CategoryIDbind.Size = new Size(107, 19);
            CategoryIDbind.TabIndex = 11;
            CategoryIDbind.Text = "materialLabel3";
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.Icon = null;
            materialFloatingActionButton1.ImageKey = "shopping_cart_FILL0_wght400_GRAD0_opsz24.png";
            materialFloatingActionButton1.ImageList = imageList1;
            materialFloatingActionButton1.Location = new Point(61, 491);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(56, 56);
            materialFloatingActionButton1.TabIndex = 10;
            materialFloatingActionButton1.UseVisualStyleBackColor = true;
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
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(159, 511);
            materialButton2.Margin = new Padding(5);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(147, 36);
            materialButton2.TabIndex = 9;
            materialButton2.Text = "Update Product";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(321, 511);
            materialButton1.Margin = new Padding(5);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(121, 36);
            materialButton1.TabIndex = 8;
            materialButton1.Text = "Add Product";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = true;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // txtPrice
            // 
            txtPrice.AnimateReadOnly = false;
            txtPrice.BackgroundImageLayout = ImageLayout.None;
            txtPrice.CharacterCasing = CharacterCasing.Normal;
            txtPrice.Depth = 0;
            txtPrice.ErrorMessage = "Price are invalid";
            txtPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrice.HelperText = "Please enter the products price, for example: 232.19";
            txtPrice.HideSelection = true;
            txtPrice.Hint = "Price";
            txtPrice.LeadingIcon = null;
            txtPrice.Location = new Point(34, 376);
            txtPrice.MaxLength = 32767;
            txtPrice.MouseState = MaterialSkin.MouseState.OUT;
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PrefixSuffixText = null;
            txtPrice.ReadOnly = false;
            txtPrice.RightToLeft = RightToLeft.No;
            txtPrice.SelectedText = "";
            txtPrice.SelectionLength = 0;
            txtPrice.SelectionStart = 0;
            txtPrice.ShortcutsEnabled = true;
            txtPrice.ShowAssistiveText = true;
            txtPrice.Size = new Size(216, 52);
            txtPrice.TabIndex = 7;
            txtPrice.TabStop = false;
            txtPrice.TextAlign = HorizontalAlignment.Left;
            txtPrice.TrailingIcon = null;
            txtPrice.UseSystemPasswordChar = false;
            txtPrice.UseTallSize = false;
            // 
            // txtSKU
            // 
            txtSKU.AnimateReadOnly = false;
            txtSKU.BackgroundImageLayout = ImageLayout.None;
            txtSKU.CharacterCasing = CharacterCasing.Normal;
            txtSKU.Depth = 0;
            txtSKU.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSKU.HideSelection = true;
            txtSKU.Hint = "SKU";
            txtSKU.LeadingIcon = null;
            txtSKU.Location = new Point(34, 131);
            txtSKU.MaxLength = 32767;
            txtSKU.MouseState = MaterialSkin.MouseState.OUT;
            txtSKU.Name = "txtSKU";
            txtSKU.PasswordChar = '\0';
            txtSKU.PrefixSuffixText = null;
            txtSKU.ReadOnly = false;
            txtSKU.RightToLeft = RightToLeft.No;
            txtSKU.SelectedText = "";
            txtSKU.SelectionLength = 0;
            txtSKU.SelectionStart = 0;
            txtSKU.ShortcutsEnabled = true;
            txtSKU.Size = new Size(216, 36);
            txtSKU.TabIndex = 6;
            txtSKU.TabStop = false;
            txtSKU.TextAlign = HorizontalAlignment.Left;
            txtSKU.TrailingIcon = null;
            txtSKU.UseSystemPasswordChar = false;
            txtSKU.UseTallSize = false;
            // 
            // txtProductDescription
            // 
            txtProductDescription.AnimateReadOnly = false;
            txtProductDescription.BackgroundImageLayout = ImageLayout.None;
            txtProductDescription.CharacterCasing = CharacterCasing.Normal;
            txtProductDescription.Depth = 0;
            txtProductDescription.HideSelection = true;
            txtProductDescription.Hint = "Product Description";
            txtProductDescription.Location = new Point(34, 232);
            txtProductDescription.MaxLength = 32767;
            txtProductDescription.MouseState = MaterialSkin.MouseState.OUT;
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.PasswordChar = '\0';
            txtProductDescription.ReadOnly = false;
            txtProductDescription.ScrollBars = ScrollBars.Vertical;
            txtProductDescription.SelectedText = "";
            txtProductDescription.SelectionLength = 0;
            txtProductDescription.SelectionStart = 0;
            txtProductDescription.ShortcutsEnabled = true;
            txtProductDescription.Size = new Size(433, 125);
            txtProductDescription.TabIndex = 5;
            txtProductDescription.TabStop = false;
            txtProductDescription.TextAlign = HorizontalAlignment.Left;
            txtProductDescription.UseSystemPasswordChar = false;
            // 
            // txtProductName
            // 
            txtProductName.AnimateReadOnly = false;
            txtProductName.BackgroundImageLayout = ImageLayout.None;
            txtProductName.CharacterCasing = CharacterCasing.Normal;
            txtProductName.Depth = 0;
            txtProductName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProductName.HideSelection = true;
            txtProductName.Hint = "Product Name";
            txtProductName.LeadingIcon = null;
            txtProductName.Location = new Point(34, 173);
            txtProductName.MaxLength = 32767;
            txtProductName.MouseState = MaterialSkin.MouseState.OUT;
            txtProductName.Name = "txtProductName";
            txtProductName.PasswordChar = '\0';
            txtProductName.PrefixSuffixText = null;
            txtProductName.ReadOnly = false;
            txtProductName.RightToLeft = RightToLeft.No;
            txtProductName.SelectedText = "";
            txtProductName.SelectionLength = 0;
            txtProductName.SelectionStart = 0;
            txtProductName.ShortcutsEnabled = true;
            txtProductName.Size = new Size(433, 36);
            txtProductName.TabIndex = 4;
            txtProductName.TabStop = false;
            txtProductName.TextAlign = HorizontalAlignment.Left;
            txtProductName.TrailingIcon = null;
            txtProductName.UseSystemPasswordChar = false;
            txtProductName.UseTallSize = false;
            // 
            // checkBoxIsAvailable
            // 
            checkBoxIsAvailable.AutoSize = true;
            checkBoxIsAvailable.Checked = true;
            checkBoxIsAvailable.CheckState = CheckState.Checked;
            checkBoxIsAvailable.Depth = 0;
            checkBoxIsAvailable.FlatStyle = FlatStyle.Flat;
            checkBoxIsAvailable.Location = new Point(342, 56);
            checkBoxIsAvailable.Margin = new Padding(0);
            checkBoxIsAvailable.MouseLocation = new Point(-1, -1);
            checkBoxIsAvailable.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxIsAvailable.Name = "checkBoxIsAvailable";
            checkBoxIsAvailable.ReadOnly = false;
            checkBoxIsAvailable.Ripple = true;
            checkBoxIsAvailable.Size = new Size(100, 37);
            checkBoxIsAvailable.TabIndex = 3;
            checkBoxIsAvailable.Text = "Available";
            checkBoxIsAvailable.UseVisualStyleBackColor = true;
            // 
            // categorycb
            // 
            categorycb.AutoResize = false;
            categorycb.BackColor = Color.FromArgb(255, 255, 255);
            categorycb.Depth = 0;
            categorycb.DrawMode = DrawMode.OwnerDrawVariable;
            categorycb.DropDownHeight = 118;
            categorycb.DropDownStyle = ComboBoxStyle.DropDownList;
            categorycb.DropDownWidth = 121;
            categorycb.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            categorycb.ForeColor = Color.FromArgb(222, 0, 0, 0);
            categorycb.FormattingEnabled = true;
            categorycb.Hint = "Category";
            categorycb.IntegralHeight = false;
            categorycb.ItemHeight = 29;
            categorycb.Items.AddRange(new object[] { "Category" });
            categorycb.Location = new Point(34, 56);
            categorycb.MaxDropDownItems = 4;
            categorycb.MouseState = MaterialSkin.MouseState.OUT;
            categorycb.Name = "categorycb";
            categorycb.Size = new Size(246, 35);
            categorycb.StartIndex = 0;
            categorycb.TabIndex = 2;
            categorycb.UseTallSize = false;
            categorycb.SelectedIndexChanged += categorycb_SelectedIndexChanged;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(10, 9);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(56, 19);
            materialLabel2.TabIndex = 0;
            materialLabel2.Text = "Product";
            // 
            // salesTab
            // 
            salesTab.ImageKey = "payments_FILL0_wght400_GRAD0_opsz24.png";
            salesTab.Location = new Point(4, 42);
            salesTab.Name = "salesTab";
            salesTab.Size = new Size(1354, 695);
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
            miscTab.Size = new Size(1354, 695);
            miscTab.TabIndex = 3;
            miscTab.Text = "Miscellenous";
            miscTab.UseVisualStyleBackColor = true;
            // 
            // darkModeswitch
            // 
            darkModeswitch.AutoSize = true;
            darkModeswitch.BackgroundImage = (Image)resources.GetObject("darkModeswitch.BackgroundImage");
            darkModeswitch.Depth = 0;
            darkModeswitch.Location = new Point(24, 21);
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
            usersTab.Size = new Size(1354, 695);
            usersTab.TabIndex = 4;
            usersTab.Text = "Users";
            usersTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1368, 808);
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
            inventoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
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
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox categorycb;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxIsAvailable;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtProductDescription;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductName;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrice;
        private MaterialSkin.Controls.MaterialTextBox2 txtSKU;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel CategoryIDbind;
    }
}
