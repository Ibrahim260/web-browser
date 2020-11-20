namespace new_browser
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SettingBox = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnNewTab = new System.Windows.Forms.Button();
            this.Spanel = new System.Windows.Forms.Panel();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnMaps = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxMail = new System.Windows.Forms.GroupBox();
            this.btnAol = new System.Windows.Forms.Button();
            this.btnIcould = new System.Windows.Forms.Button();
            this.btnGMX = new System.Windows.Forms.Button();
            this.btnOutlook = new System.Windows.Forms.Button();
            this.btnYahoo = new System.Windows.Forms.Button();
            this.btnGmail = new System.Windows.Forms.Button();
            this.srtcut1 = new System.Windows.Forms.Button();
            this.srtcut3 = new System.Windows.Forms.Button();
            this.srtcut4 = new System.Windows.Forms.Button();
            this.srtcut2 = new System.Windows.Forms.Button();
            this.srtcut5 = new System.Windows.Forms.Button();
            this.srtcut6 = new System.Windows.Forms.Button();
            this.srtcut7 = new System.Windows.Forms.Button();
            this.bttnBookmark = new System.Windows.Forms.Button();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.apps = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.btngo = new System.Windows.Forms.Button();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnforward = new System.Windows.Forms.Button();
            this.srtcutgrpbox = new System.Windows.Forms.GroupBox();
            this.clrsrtcut7 = new System.Windows.Forms.Button();
            this.clrsrtcut6 = new System.Windows.Forms.Button();
            this.clrsrtcut5 = new System.Windows.Forms.Button();
            this.clrsrtcut4 = new System.Windows.Forms.Button();
            this.clrsrtcut3 = new System.Windows.Forms.Button();
            this.clrsrtcut2 = new System.Windows.Forms.Button();
            this.clrsrtcut1 = new System.Windows.Forms.Button();
            this.SettingBox.SuspendLayout();
            this.Spanel.SuspendLayout();
            this.groupBoxMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.srtcutgrpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 75);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1364, 658);
            this.webBrowser.TabIndex = 8;
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "         "});
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.Font = new System.Drawing.Font("Minion Pro Med", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(940, 34);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "Search here";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // SettingBox
            // 
            this.SettingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingBox.BackColor = System.Drawing.SystemColors.Window;
            this.SettingBox.Controls.Add(this.btnExit);
            this.SettingBox.Controls.Add(this.button7);
            this.SettingBox.Controls.Add(this.button6);
            this.SettingBox.Controls.Add(this.button5);
            this.SettingBox.Controls.Add(this.button4);
            this.SettingBox.Controls.Add(this.button3);
            this.SettingBox.Controls.Add(this.btnNewTab);
            this.SettingBox.Location = new System.Drawing.Point(1152, 44);
            this.SettingBox.Name = "SettingBox";
            this.SettingBox.Size = new System.Drawing.Size(170, 249);
            this.SettingBox.TabIndex = 18;
            this.SettingBox.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Window;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnExit.Location = new System.Drawing.Point(1, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Window;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button7.Location = new System.Drawing.Point(1, 177);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 35);
            this.button7.TabIndex = 5;
            this.button7.Text = "Help";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Window;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button6.Location = new System.Drawing.Point(1, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 35);
            this.button6.TabIndex = 4;
            this.button6.Text = "about";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button5.Location = new System.Drawing.Point(1, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 35);
            this.button5.TabIndex = 3;
            this.button5.Text = "Downloads";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Window;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button4.Location = new System.Drawing.Point(1, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 35);
            this.button4.TabIndex = 2;
            this.button4.Text = "History";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button3.Location = new System.Drawing.Point(1, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "New window";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnNewTab
            // 
            this.btnNewTab.BackColor = System.Drawing.SystemColors.Window;
            this.btnNewTab.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnNewTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTab.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnNewTab.Location = new System.Drawing.Point(2, 2);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(168, 35);
            this.btnNewTab.TabIndex = 0;
            this.btnNewTab.Text = "New tab";
            this.btnNewTab.UseVisualStyleBackColor = false;
            this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);
            // 
            // Spanel
            // 
            this.Spanel.BackColor = System.Drawing.Color.MediumPurple;
            this.Spanel.Controls.Add(this.btnImage);
            this.Spanel.Controls.Add(this.btnMaps);
            this.Spanel.Controls.Add(this.btnPaint);
            this.Spanel.Controls.Add(this.btnTranslate);
            this.Spanel.Controls.Add(this.btnEmail);
            this.Spanel.Location = new System.Drawing.Point(0, 75);
            this.Spanel.Name = "Spanel";
            this.Spanel.Size = new System.Drawing.Size(130, 657);
            this.Spanel.TabIndex = 19;
            // 
            // btnImage
            // 
            this.btnImage.BackgroundImage = global::new_browser.Properties.Resources.if_21_g_suit_google_pack_service_image_2109109;
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImage.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Location = new System.Drawing.Point(22, 538);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(82, 73);
            this.btnImage.TabIndex = 4;
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // btnMaps
            // 
            this.btnMaps.BackgroundImage = global::new_browser.Properties.Resources.if_logo_brand_brands_logos_maps_google_1916065;
            this.btnMaps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaps.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaps.Location = new System.Drawing.Point(22, 415);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(82, 73);
            this.btnMaps.TabIndex = 3;
            this.btnMaps.UseVisualStyleBackColor = true;
            this.btnMaps.Click += new System.EventHandler(this.btnMaps_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.BackgroundImage = global::new_browser.Properties.Resources.if_Draw_2290864;
            this.btnPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaint.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaint.Location = new System.Drawing.Point(22, 288);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(82, 73);
            this.btnPaint.TabIndex = 2;
            this.btnPaint.UseVisualStyleBackColor = true;
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackgroundImage = global::new_browser.Properties.Resources.if_Translate_692155;
            this.btnTranslate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTranslate.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate.Location = new System.Drawing.Point(21, 163);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(82, 73);
            this.btnTranslate.TabIndex = 1;
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmail.BackgroundImage")));
            this.btnEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmail.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Location = new System.Drawing.Point(20, 43);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(82, 73);
            this.btnEmail.TabIndex = 0;
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // groupBoxMail
            // 
            this.groupBoxMail.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxMail.Controls.Add(this.btnAol);
            this.groupBoxMail.Controls.Add(this.btnIcould);
            this.groupBoxMail.Controls.Add(this.btnGMX);
            this.groupBoxMail.Controls.Add(this.btnOutlook);
            this.groupBoxMail.Controls.Add(this.btnYahoo);
            this.groupBoxMail.Controls.Add(this.btnGmail);
            this.groupBoxMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMail.Location = new System.Drawing.Point(141, 77);
            this.groupBoxMail.Name = "groupBoxMail";
            this.groupBoxMail.Size = new System.Drawing.Size(218, 132);
            this.groupBoxMail.TabIndex = 21;
            this.groupBoxMail.TabStop = false;
            // 
            // btnAol
            // 
            this.btnAol.BackgroundImage = global::new_browser.Properties.Resources.if_logo_brand_brands_logos_aol_3215570;
            this.btnAol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAol.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnAol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAol.Location = new System.Drawing.Point(150, 74);
            this.btnAol.Name = "btnAol";
            this.btnAol.Size = new System.Drawing.Size(55, 50);
            this.btnAol.TabIndex = 5;
            this.btnAol.UseVisualStyleBackColor = true;
            this.btnAol.Click += new System.EventHandler(this.btnAol_Click);
            // 
            // btnIcould
            // 
            this.btnIcould.BackgroundImage = global::new_browser.Properties.Resources.if_icloud_3069721;
            this.btnIcould.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIcould.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnIcould.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcould.Location = new System.Drawing.Point(77, 74);
            this.btnIcould.Name = "btnIcould";
            this.btnIcould.Size = new System.Drawing.Size(55, 50);
            this.btnIcould.TabIndex = 4;
            this.btnIcould.UseVisualStyleBackColor = true;
            this.btnIcould.Click += new System.EventHandler(this.btnIcould_Click);
            // 
            // btnGMX
            // 
            this.btnGMX.BackgroundImage = global::new_browser.Properties.Resources.if_gmx_1175604;
            this.btnGMX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGMX.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnGMX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGMX.Location = new System.Drawing.Point(10, 74);
            this.btnGMX.Name = "btnGMX";
            this.btnGMX.Size = new System.Drawing.Size(55, 50);
            this.btnGMX.TabIndex = 3;
            this.btnGMX.UseVisualStyleBackColor = true;
            this.btnGMX.Click += new System.EventHandler(this.btnGMX_Click);
            // 
            // btnOutlook
            // 
            this.btnOutlook.BackgroundImage = global::new_browser.Properties.Resources.if_microsoft_office_outlook_1784857;
            this.btnOutlook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutlook.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnOutlook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutlook.Location = new System.Drawing.Point(147, 9);
            this.btnOutlook.Name = "btnOutlook";
            this.btnOutlook.Size = new System.Drawing.Size(55, 50);
            this.btnOutlook.TabIndex = 2;
            this.btnOutlook.UseVisualStyleBackColor = true;
            this.btnOutlook.Click += new System.EventHandler(this.btnOutlook_Click);
            // 
            // btnYahoo
            // 
            this.btnYahoo.BackgroundImage = global::new_browser.Properties.Resources.if_yahoo_1632536;
            this.btnYahoo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYahoo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnYahoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYahoo.Location = new System.Drawing.Point(76, 9);
            this.btnYahoo.Name = "btnYahoo";
            this.btnYahoo.Size = new System.Drawing.Size(55, 50);
            this.btnYahoo.TabIndex = 1;
            this.btnYahoo.UseVisualStyleBackColor = true;
            this.btnYahoo.Click += new System.EventHandler(this.btnYahoo_Click);
            // 
            // btnGmail
            // 
            this.btnGmail.BackgroundImage = global::new_browser.Properties.Resources.if_gmail_1220367;
            this.btnGmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGmail.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnGmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGmail.Location = new System.Drawing.Point(9, 9);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(55, 50);
            this.btnGmail.TabIndex = 0;
            this.btnGmail.UseVisualStyleBackColor = true;
            this.btnGmail.Click += new System.EventHandler(this.button9_Click);
            // 
            // srtcut1
            // 
            this.srtcut1.BackColor = System.Drawing.SystemColors.Window;
            this.srtcut1.Location = new System.Drawing.Point(0, 1);
            this.srtcut1.Name = "srtcut1";
            this.srtcut1.Size = new System.Drawing.Size(138, 122);
            this.srtcut1.TabIndex = 23;
            this.srtcut1.UseVisualStyleBackColor = false;
            // 
            // srtcut3
            // 
            this.srtcut3.BackColor = System.Drawing.SystemColors.Window;
            this.srtcut3.Location = new System.Drawing.Point(144, 129);
            this.srtcut3.Name = "srtcut3";
            this.srtcut3.Size = new System.Drawing.Size(138, 122);
            this.srtcut3.TabIndex = 24;
            this.srtcut3.UseVisualStyleBackColor = false;
            // 
            // srtcut4
            // 
            this.srtcut4.BackColor = System.Drawing.SystemColors.Window;
            this.srtcut4.Location = new System.Drawing.Point(288, 129);
            this.srtcut4.Name = "srtcut4";
            this.srtcut4.Size = new System.Drawing.Size(138, 122);
            this.srtcut4.TabIndex = 25;
            this.srtcut4.UseVisualStyleBackColor = false;
            // 
            // srtcut2
            // 
            this.srtcut2.BackColor = System.Drawing.SystemColors.Window;
            this.srtcut2.Location = new System.Drawing.Point(0, 129);
            this.srtcut2.Name = "srtcut2";
            this.srtcut2.Size = new System.Drawing.Size(138, 122);
            this.srtcut2.TabIndex = 26;
            this.srtcut2.UseVisualStyleBackColor = false;
            // 
            // srtcut5
            // 
            this.srtcut5.BackColor = System.Drawing.SystemColors.Window;
            this.srtcut5.Location = new System.Drawing.Point(432, 129);
            this.srtcut5.Name = "srtcut5";
            this.srtcut5.Size = new System.Drawing.Size(138, 122);
            this.srtcut5.TabIndex = 27;
            this.srtcut5.UseVisualStyleBackColor = false;
            // 
            // srtcut6
            // 
            this.srtcut6.BackColor = System.Drawing.SystemColors.Window;
            this.srtcut6.Location = new System.Drawing.Point(576, 129);
            this.srtcut6.Name = "srtcut6";
            this.srtcut6.Size = new System.Drawing.Size(138, 122);
            this.srtcut6.TabIndex = 28;
            this.srtcut6.UseVisualStyleBackColor = false;
            // 
            // srtcut7
            // 
            this.srtcut7.BackColor = System.Drawing.SystemColors.Window;
            this.srtcut7.Location = new System.Drawing.Point(576, 1);
            this.srtcut7.Name = "srtcut7";
            this.srtcut7.Size = new System.Drawing.Size(138, 122);
            this.srtcut7.TabIndex = 29;
            this.srtcut7.UseVisualStyleBackColor = false;
            // 
            // bttnBookmark
            // 
            this.bttnBookmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnBookmark.BackColor = System.Drawing.SystemColors.Window;
            this.bttnBookmark.BackgroundImage = global::new_browser.Properties.Resources.if_star_134222;
            this.bttnBookmark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnBookmark.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.bttnBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBookmark.Location = new System.Drawing.Point(1099, 13);
            this.bttnBookmark.Name = "bttnBookmark";
            this.bttnBookmark.Size = new System.Drawing.Size(29, 27);
            this.bttnBookmark.TabIndex = 22;
            this.bttnBookmark.UseVisualStyleBackColor = false;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxSearch.BackgroundImage = global::new_browser.Properties.Resources.if_search_01_186388;
            this.pictureBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxSearch.Location = new System.Drawing.Point(151, 10);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(37, 34);
            this.pictureBoxSearch.TabIndex = 20;
            this.pictureBoxSearch.TabStop = false;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.backbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbtn.BackgroundImage")));
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Location = new System.Drawing.Point(2, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(30, 29);
            this.backbtn.TabIndex = 17;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(137, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 112);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // apps
            // 
            this.apps.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apps.BackgroundImage")));
            this.apps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.apps.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.apps.Location = new System.Drawing.Point(2, 43);
            this.apps.Name = "apps";
            this.apps.Size = new System.Drawing.Size(31, 29);
            this.apps.TabIndex = 9;
            this.apps.UseVisualStyleBackColor = true;
            this.apps.Click += new System.EventHandler(this.apps_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(100, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(41, 28);
            this.btnHome.TabIndex = 7;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsetting.BackgroundImage")));
            this.btnsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsetting.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.Location = new System.Drawing.Point(1281, 12);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(38, 29);
            this.btnsetting.TabIndex = 5;
            this.btnsetting.UseVisualStyleBackColor = true;
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // btngo
            // 
            this.btngo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btngo.BackgroundImage = global::new_browser.Properties.Resources.go__1_;
            this.btngo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btngo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngo.Location = new System.Drawing.Point(1131, 11);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(42, 32);
            this.btngo.TabIndex = 4;
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // btnreload
            // 
            this.btnreload.BackgroundImage = global::new_browser.Properties.Resources.if_icons_reload_1564525__1_;
            this.btnreload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreload.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnreload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreload.Location = new System.Drawing.Point(65, 12);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(30, 28);
            this.btnreload.TabIndex = 2;
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnforward
            // 
            this.btnforward.BackgroundImage = global::new_browser.Properties.Resources.if_arrow_forward_216442__1_;
            this.btnforward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnforward.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnforward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnforward.Location = new System.Drawing.Point(33, 12);
            this.btnforward.Name = "btnforward";
            this.btnforward.Size = new System.Drawing.Size(31, 28);
            this.btnforward.TabIndex = 1;
            this.btnforward.UseVisualStyleBackColor = true;
            this.btnforward.Click += new System.EventHandler(this.btnforward_Click);
            // 
            // srtcutgrpbox
            // 
            this.srtcutgrpbox.BackColor = System.Drawing.SystemColors.Window;
            this.srtcutgrpbox.Controls.Add(this.clrsrtcut7);
            this.srtcutgrpbox.Controls.Add(this.clrsrtcut6);
            this.srtcutgrpbox.Controls.Add(this.clrsrtcut5);
            this.srtcutgrpbox.Controls.Add(this.clrsrtcut4);
            this.srtcutgrpbox.Controls.Add(this.clrsrtcut3);
            this.srtcutgrpbox.Controls.Add(this.clrsrtcut2);
            this.srtcutgrpbox.Controls.Add(this.clrsrtcut1);
            this.srtcutgrpbox.Controls.Add(this.srtcut1);
            this.srtcutgrpbox.Controls.Add(this.srtcut7);
            this.srtcutgrpbox.Controls.Add(this.pictureBox1);
            this.srtcutgrpbox.Controls.Add(this.srtcut6);
            this.srtcutgrpbox.Controls.Add(this.srtcut2);
            this.srtcutgrpbox.Controls.Add(this.srtcut5);
            this.srtcutgrpbox.Controls.Add(this.srtcut3);
            this.srtcutgrpbox.Controls.Add(this.srtcut4);
            this.srtcutgrpbox.Location = new System.Drawing.Point(306, 256);
            this.srtcutgrpbox.Name = "srtcutgrpbox";
            this.srtcutgrpbox.Size = new System.Drawing.Size(715, 251);
            this.srtcutgrpbox.TabIndex = 37;
            this.srtcutgrpbox.TabStop = false;
            // 
            // clrsrtcut7
            // 
            this.clrsrtcut7.BackgroundImage = global::new_browser.Properties.Resources.if_gtk_close_30632;
            this.clrsrtcut7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clrsrtcut7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.clrsrtcut7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrsrtcut7.Location = new System.Drawing.Point(680, 5);
            this.clrsrtcut7.Name = "clrsrtcut7";
            this.clrsrtcut7.Size = new System.Drawing.Size(29, 27);
            this.clrsrtcut7.TabIndex = 36;
            this.clrsrtcut7.UseVisualStyleBackColor = true;
            // 
            // clrsrtcut6
            // 
            this.clrsrtcut6.BackgroundImage = global::new_browser.Properties.Resources.if_gtk_close_30632;
            this.clrsrtcut6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clrsrtcut6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.clrsrtcut6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrsrtcut6.Location = new System.Drawing.Point(680, 133);
            this.clrsrtcut6.Name = "clrsrtcut6";
            this.clrsrtcut6.Size = new System.Drawing.Size(29, 27);
            this.clrsrtcut6.TabIndex = 35;
            this.clrsrtcut6.UseVisualStyleBackColor = true;
            // 
            // clrsrtcut5
            // 
            this.clrsrtcut5.BackgroundImage = global::new_browser.Properties.Resources.if_gtk_close_30632;
            this.clrsrtcut5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clrsrtcut5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.clrsrtcut5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrsrtcut5.Location = new System.Drawing.Point(537, 133);
            this.clrsrtcut5.Name = "clrsrtcut5";
            this.clrsrtcut5.Size = new System.Drawing.Size(29, 27);
            this.clrsrtcut5.TabIndex = 34;
            this.clrsrtcut5.UseVisualStyleBackColor = true;
            // 
            // clrsrtcut4
            // 
            this.clrsrtcut4.BackgroundImage = global::new_browser.Properties.Resources.if_gtk_close_30632;
            this.clrsrtcut4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clrsrtcut4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.clrsrtcut4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrsrtcut4.Location = new System.Drawing.Point(391, 133);
            this.clrsrtcut4.Name = "clrsrtcut4";
            this.clrsrtcut4.Size = new System.Drawing.Size(29, 27);
            this.clrsrtcut4.TabIndex = 33;
            this.clrsrtcut4.UseVisualStyleBackColor = true;
            // 
            // clrsrtcut3
            // 
            this.clrsrtcut3.BackgroundImage = global::new_browser.Properties.Resources.if_gtk_close_30632;
            this.clrsrtcut3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clrsrtcut3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.clrsrtcut3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrsrtcut3.Location = new System.Drawing.Point(250, 134);
            this.clrsrtcut3.Name = "clrsrtcut3";
            this.clrsrtcut3.Size = new System.Drawing.Size(29, 27);
            this.clrsrtcut3.TabIndex = 32;
            this.clrsrtcut3.UseVisualStyleBackColor = true;
            // 
            // clrsrtcut2
            // 
            this.clrsrtcut2.BackgroundImage = global::new_browser.Properties.Resources.if_gtk_close_30632;
            this.clrsrtcut2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clrsrtcut2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.clrsrtcut2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrsrtcut2.Location = new System.Drawing.Point(103, 133);
            this.clrsrtcut2.Name = "clrsrtcut2";
            this.clrsrtcut2.Size = new System.Drawing.Size(29, 27);
            this.clrsrtcut2.TabIndex = 31;
            this.clrsrtcut2.UseVisualStyleBackColor = true;
            // 
            // clrsrtcut1
            // 
            this.clrsrtcut1.BackgroundImage = global::new_browser.Properties.Resources.if_gtk_close_30632;
            this.clrsrtcut1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clrsrtcut1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.clrsrtcut1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrsrtcut1.Location = new System.Drawing.Point(103, 5);
            this.clrsrtcut1.Name = "clrsrtcut1";
            this.clrsrtcut1.Size = new System.Drawing.Size(29, 27);
            this.clrsrtcut1.TabIndex = 30;
            this.clrsrtcut1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1322, 726);
            this.Controls.Add(this.srtcutgrpbox);
            this.Controls.Add(this.bttnBookmark);
            this.Controls.Add(this.groupBoxMail);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.Spanel);
            this.Controls.Add(this.SettingBox);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.apps);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnsetting);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnforward);
            this.Name = "Form1";
            this.Text = "New browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SettingBox.ResumeLayout(false);
            this.Spanel.ResumeLayout(false);
            this.groupBoxMail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.srtcutgrpbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnforward;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button apps;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.GroupBox SettingBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnNewTab;
        private System.Windows.Forms.Panel Spanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnMaps;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.GroupBox groupBoxMail;
        private System.Windows.Forms.Button btnIcould;
        private System.Windows.Forms.Button btnGMX;
        private System.Windows.Forms.Button btnOutlook;
        private System.Windows.Forms.Button btnYahoo;
        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Button btnAol;
        private System.Windows.Forms.Button bttnBookmark;
        private System.Windows.Forms.Button srtcut1;
        private System.Windows.Forms.Button srtcut3;
        private System.Windows.Forms.Button srtcut4;
        private System.Windows.Forms.Button srtcut2;
        private System.Windows.Forms.Button srtcut5;
        private System.Windows.Forms.Button srtcut6;
        private System.Windows.Forms.Button srtcut7;
        private System.Windows.Forms.GroupBox srtcutgrpbox;
        private System.Windows.Forms.Button clrsrtcut1;
        private System.Windows.Forms.Button clrsrtcut7;
        private System.Windows.Forms.Button clrsrtcut6;
        private System.Windows.Forms.Button clrsrtcut5;
        private System.Windows.Forms.Button clrsrtcut4;
        private System.Windows.Forms.Button clrsrtcut3;
        private System.Windows.Forms.Button clrsrtcut2;
    }
}

