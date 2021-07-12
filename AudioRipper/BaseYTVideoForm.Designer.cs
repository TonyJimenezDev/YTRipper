
namespace YTRipper
{
    partial class BaseYTVideoForm
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
            this.httpsInput_TextBox = new System.Windows.Forms.TextBox();
            this.topBar_Panel = new System.Windows.Forms.Panel();
            this.minimize_Btn = new System.Windows.Forms.Button();
            this.maximize_Btn = new System.Windows.Forms.Button();
            this.close_Btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.url_Label = new System.Windows.Forms.Label();
            this.home_Btn = new System.Windows.Forms.Button();
            this.mux_Btn = new System.Windows.Forms.Button();
            this.audio_Btn = new System.Windows.Forms.Button();
            this.video_Btn = new System.Windows.Forms.Button();
            this.Media_Btn = new System.Windows.Forms.Button();
            this.menuStrip_LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.settings_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_Panel = new System.Windows.Forms.Panel();
            this.welcome_RichBox = new System.Windows.Forms.RichTextBox();
            this.welcome_Label = new System.Windows.Forms.Label();
            this.mux_Panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.downloadInfo_Btn = new System.Windows.Forms.Button();
            this.download_Btn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.info_LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.loading_Label = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.info_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.rating_Label = new System.Windows.Forms.Label();
            this.videoImg_PictureBox = new System.Windows.Forms.PictureBox();
            this.audio_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.video_Panel = new System.Windows.Forms.Panel();
            this.video_Label = new System.Windows.Forms.Label();
            this.media_Panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.settings_Panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.topBar_Panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip_LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.home_Panel.SuspendLayout();
            this.mux_Panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.info_LayoutPanel.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoImg_PictureBox)).BeginInit();
            this.audio_Panel.SuspendLayout();
            this.video_Panel.SuspendLayout();
            this.media_Panel.SuspendLayout();
            this.settings_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // httpsInput_TextBox
            // 
            this.httpsInput_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.httpsInput_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.httpsInput_TextBox.Location = new System.Drawing.Point(57, 3);
            this.httpsInput_TextBox.Name = "httpsInput_TextBox";
            this.httpsInput_TextBox.Size = new System.Drawing.Size(566, 13);
            this.httpsInput_TextBox.TabIndex = 0;
            this.httpsInput_TextBox.TextChanged += new System.EventHandler(this.HttpsInput_TextBox_TextChanged);
            // 
            // topBar_Panel
            // 
            this.topBar_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topBar_Panel.BackColor = System.Drawing.Color.Black;
            this.topBar_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topBar_Panel.Controls.Add(this.minimize_Btn);
            this.topBar_Panel.Controls.Add(this.maximize_Btn);
            this.topBar_Panel.Controls.Add(this.close_Btn);
            this.topBar_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar_Panel.Location = new System.Drawing.Point(0, 0);
            this.topBar_Panel.Name = "topBar_Panel";
            this.topBar_Panel.Size = new System.Drawing.Size(681, 22);
            this.topBar_Panel.TabIndex = 5;
            this.topBar_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // minimize_Btn
            // 
            this.minimize_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minimize_Btn.BackColor = System.Drawing.Color.Khaki;
            this.minimize_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize_Btn.Location = new System.Drawing.Point(614, 3);
            this.minimize_Btn.Name = "minimize_Btn";
            this.minimize_Btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minimize_Btn.Size = new System.Drawing.Size(14, 14);
            this.minimize_Btn.TabIndex = 2;
            this.minimize_Btn.UseVisualStyleBackColor = false;
            this.minimize_Btn.Click += new System.EventHandler(this.Minimize_Btn_Click);
            // 
            // maximize_Btn
            // 
            this.maximize_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maximize_Btn.BackColor = System.Drawing.Color.Aqua;
            this.maximize_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.maximize_Btn.Location = new System.Drawing.Point(634, 3);
            this.maximize_Btn.Name = "maximize_Btn";
            this.maximize_Btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maximize_Btn.Size = new System.Drawing.Size(14, 14);
            this.maximize_Btn.TabIndex = 1;
            this.maximize_Btn.UseVisualStyleBackColor = false;
            this.maximize_Btn.Click += new System.EventHandler(this.Maximize_Btn_Click);
            // 
            // close_Btn
            // 
            this.close_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close_Btn.BackColor = System.Drawing.Color.Red;
            this.close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_Btn.Location = new System.Drawing.Point(654, 3);
            this.close_Btn.Name = "close_Btn";
            this.close_Btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.close_Btn.Size = new System.Drawing.Size(14, 14);
            this.close_Btn.TabIndex = 0;
            this.close_Btn.UseVisualStyleBackColor = false;
            this.close_Btn.Click += new System.EventHandler(this.close_Btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.httpsInput_TextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.url_Label, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 19);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // url_Label
            // 
            this.url_Label.AutoSize = true;
            this.url_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.url_Label.Font = new System.Drawing.Font("Linux Libertine Display G", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_Label.Location = new System.Drawing.Point(3, 0);
            this.url_Label.Name = "url_Label";
            this.url_Label.Size = new System.Drawing.Size(48, 19);
            this.url_Label.TabIndex = 1;
            this.url_Label.Text = "URL:";
            this.url_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // home_Btn
            // 
            this.home_Btn.AutoSize = true;
            this.home_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.home_Btn.BackColor = System.Drawing.Color.Transparent;
            this.home_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_Btn.FlatAppearance.BorderSize = 0;
            this.home_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home_Btn.Font = new System.Drawing.Font("Reem Kufi", 8.25F);
            this.home_Btn.ForeColor = System.Drawing.Color.YellowGreen;
            this.home_Btn.Location = new System.Drawing.Point(3, 53);
            this.home_Btn.Name = "home_Btn";
            this.home_Btn.Size = new System.Drawing.Size(80, 44);
            this.home_Btn.TabIndex = 8;
            this.home_Btn.Text = "Home";
            this.home_Btn.UseVisualStyleBackColor = false;
            this.home_Btn.Click += new System.EventHandler(this.HomeBtn_Clicked);
            // 
            // mux_Btn
            // 
            this.mux_Btn.AutoSize = true;
            this.mux_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mux_Btn.BackColor = System.Drawing.Color.Transparent;
            this.mux_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mux_Btn.FlatAppearance.BorderSize = 0;
            this.mux_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mux_Btn.ForeColor = System.Drawing.Color.YellowGreen;
            this.mux_Btn.Location = new System.Drawing.Point(3, 103);
            this.mux_Btn.Name = "mux_Btn";
            this.mux_Btn.Size = new System.Drawing.Size(80, 44);
            this.mux_Btn.TabIndex = 9;
            this.mux_Btn.Text = "Mux";
            this.mux_Btn.UseVisualStyleBackColor = false;
            this.mux_Btn.Click += new System.EventHandler(this.MuxBtn_Clicked);
            // 
            // audio_Btn
            // 
            this.audio_Btn.AutoSize = true;
            this.audio_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.audio_Btn.BackColor = System.Drawing.Color.Transparent;
            this.audio_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audio_Btn.FlatAppearance.BorderSize = 0;
            this.audio_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.audio_Btn.ForeColor = System.Drawing.Color.YellowGreen;
            this.audio_Btn.Location = new System.Drawing.Point(3, 153);
            this.audio_Btn.Name = "audio_Btn";
            this.audio_Btn.Size = new System.Drawing.Size(80, 44);
            this.audio_Btn.TabIndex = 10;
            this.audio_Btn.Text = "Audio";
            this.audio_Btn.UseVisualStyleBackColor = false;
            this.audio_Btn.Click += new System.EventHandler(this.AudioBtn_Clicked);
            // 
            // video_Btn
            // 
            this.video_Btn.AutoSize = true;
            this.video_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.video_Btn.BackColor = System.Drawing.Color.Transparent;
            this.video_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.video_Btn.FlatAppearance.BorderSize = 0;
            this.video_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.video_Btn.ForeColor = System.Drawing.Color.YellowGreen;
            this.video_Btn.Location = new System.Drawing.Point(3, 203);
            this.video_Btn.Name = "video_Btn";
            this.video_Btn.Size = new System.Drawing.Size(80, 44);
            this.video_Btn.TabIndex = 11;
            this.video_Btn.Text = "Video";
            this.video_Btn.UseVisualStyleBackColor = false;
            this.video_Btn.Click += new System.EventHandler(this.VideoBtn_Clicked);
            // 
            // Media_Btn
            // 
            this.Media_Btn.AutoSize = true;
            this.Media_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Media_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Media_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Media_Btn.FlatAppearance.BorderSize = 0;
            this.Media_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Media_Btn.ForeColor = System.Drawing.Color.YellowGreen;
            this.Media_Btn.Location = new System.Drawing.Point(3, 253);
            this.Media_Btn.Name = "Media_Btn";
            this.Media_Btn.Size = new System.Drawing.Size(80, 44);
            this.Media_Btn.TabIndex = 12;
            this.Media_Btn.Text = "Media";
            this.Media_Btn.UseVisualStyleBackColor = false;
            this.Media_Btn.Click += new System.EventHandler(this.MediaBtn_Clicked);
            // 
            // menuStrip_LayoutPanel
            // 
            this.menuStrip_LayoutPanel.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip_LayoutPanel.ColumnCount = 1;
            this.menuStrip_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuStrip_LayoutPanel.Controls.Add(this.settings_Btn, 0, 6);
            this.menuStrip_LayoutPanel.Controls.Add(this.Media_Btn, 0, 5);
            this.menuStrip_LayoutPanel.Controls.Add(this.video_Btn, 0, 4);
            this.menuStrip_LayoutPanel.Controls.Add(this.audio_Btn, 0, 3);
            this.menuStrip_LayoutPanel.Controls.Add(this.mux_Btn, 0, 2);
            this.menuStrip_LayoutPanel.Controls.Add(this.home_Btn, 0, 1);
            this.menuStrip_LayoutPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.menuStrip_LayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip_LayoutPanel.Location = new System.Drawing.Point(0, 41);
            this.menuStrip_LayoutPanel.Name = "menuStrip_LayoutPanel";
            this.menuStrip_LayoutPanel.RowCount = 8;
            this.menuStrip_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuStrip_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuStrip_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuStrip_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuStrip_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuStrip_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuStrip_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuStrip_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.menuStrip_LayoutPanel.Size = new System.Drawing.Size(86, 411);
            this.menuStrip_LayoutPanel.TabIndex = 7;
            // 
            // settings_Btn
            // 
            this.settings_Btn.AutoSize = true;
            this.settings_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settings_Btn.BackColor = System.Drawing.Color.Transparent;
            this.settings_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_Btn.FlatAppearance.BorderSize = 0;
            this.settings_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settings_Btn.ForeColor = System.Drawing.Color.YellowGreen;
            this.settings_Btn.Location = new System.Drawing.Point(3, 303);
            this.settings_Btn.Name = "settings_Btn";
            this.settings_Btn.Size = new System.Drawing.Size(80, 44);
            this.settings_Btn.TabIndex = 13;
            this.settings_Btn.Text = "Settings";
            this.settings_Btn.UseVisualStyleBackColor = false;
            this.settings_Btn.Click += new System.EventHandler(this.SettingsBtn_Clicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // home_Panel
            // 
            this.home_Panel.Controls.Add(this.welcome_RichBox);
            this.home_Panel.Controls.Add(this.welcome_Label);
            this.home_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_Panel.Location = new System.Drawing.Point(0, 0);
            this.home_Panel.Name = "home_Panel";
            this.home_Panel.Size = new System.Drawing.Size(681, 452);
            this.home_Panel.TabIndex = 8;
            // 
            // welcome_RichBox
            // 
            this.welcome_RichBox.Location = new System.Drawing.Point(57, 134);
            this.welcome_RichBox.Name = "welcome_RichBox";
            this.welcome_RichBox.ReadOnly = true;
            this.welcome_RichBox.Size = new System.Drawing.Size(430, 113);
            this.welcome_RichBox.TabIndex = 1;
            this.welcome_RichBox.Text = "";
            // 
            // welcome_Label
            // 
            this.welcome_Label.AutoSize = true;
            this.welcome_Label.Location = new System.Drawing.Point(240, 84);
            this.welcome_Label.Name = "welcome_Label";
            this.welcome_Label.Size = new System.Drawing.Size(52, 13);
            this.welcome_Label.TabIndex = 0;
            this.welcome_Label.Text = "Welcome";
            // 
            // mux_Panel
            // 
            this.mux_Panel.BackColor = System.Drawing.Color.DimGray;
            this.mux_Panel.Controls.Add(this.tableLayoutPanel2);
            this.mux_Panel.Controls.Add(this.flowLayoutPanel1);
            this.mux_Panel.Controls.Add(this.radioButton1);
            this.mux_Panel.Controls.Add(this.comboBox1);
            this.mux_Panel.Controls.Add(this.info_LayoutPanel);
            this.mux_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mux_Panel.Location = new System.Drawing.Point(86, 41);
            this.mux_Panel.Name = "mux_Panel";
            this.mux_Panel.Size = new System.Drawing.Size(595, 411);
            this.mux_Panel.TabIndex = 5;
            this.mux_Panel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.5042F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.4958F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 272);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(595, 100);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.downloadInfo_Btn);
            this.flowLayoutPanel1.Controls.Add(this.download_Btn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 379);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 29);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // downloadInfo_Btn
            // 
            this.downloadInfo_Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.downloadInfo_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadInfo_Btn.Location = new System.Drawing.Point(3, 3);
            this.downloadInfo_Btn.Name = "downloadInfo_Btn";
            this.downloadInfo_Btn.Size = new System.Drawing.Size(75, 23);
            this.downloadInfo_Btn.TabIndex = 6;
            this.downloadInfo_Btn.Text = "Load";
            this.downloadInfo_Btn.UseVisualStyleBackColor = true;
            this.downloadInfo_Btn.Click += new System.EventHandler(this.GetDownloadInfo);
            // 
            // download_Btn
            // 
            this.download_Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.download_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.download_Btn.Location = new System.Drawing.Point(84, 3);
            this.download_Btn.Name = "download_Btn";
            this.download_Btn.Size = new System.Drawing.Size(75, 23);
            this.download_Btn.TabIndex = 7;
            this.download_Btn.Text = "Download";
            this.download_Btn.UseVisualStyleBackColor = true;
            this.download_Btn.Click += new System.EventHandler(this.DownloadBtn_Clicked);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(498, 382);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(218, 381);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // info_LayoutPanel
            // 
            this.info_LayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.info_LayoutPanel.ColumnCount = 3;
            this.info_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.info_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.info_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.info_LayoutPanel.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.info_LayoutPanel.Controls.Add(this.info_RichTextBox, 0, 0);
            this.info_LayoutPanel.Controls.Add(this.rating_Label, 1, 1);
            this.info_LayoutPanel.Controls.Add(this.videoImg_PictureBox, 1, 0);
            this.info_LayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.info_LayoutPanel.Name = "info_LayoutPanel";
            this.info_LayoutPanel.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.info_LayoutPanel.RowCount = 2;
            this.info_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.10526F));
            this.info_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894737F));
            this.info_LayoutPanel.Size = new System.Drawing.Size(595, 272);
            this.info_LayoutPanel.TabIndex = 8;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.loading_Label);
            this.flowLayoutPanel3.Controls.Add(this.progressBar);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 257);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(206, 12);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // loading_Label
            // 
            this.loading_Label.AutoSize = true;
            this.loading_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loading_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.loading_Label.Location = new System.Drawing.Point(3, 0);
            this.loading_Label.Name = "loading_Label";
            this.loading_Label.Size = new System.Drawing.Size(44, 12);
            this.loading_Label.TabIndex = 11;
            this.loading_Label.Text = "Loading:  ";
            this.loading_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loading_Label.Visible = false;
            this.loading_Label.TextChanged += new System.EventHandler(this.Loading_Label_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(53, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(150, 10);
            this.progressBar.TabIndex = 10;
            this.progressBar.Visible = false;
            // 
            // info_RichTextBox
            // 
            this.info_RichTextBox.BackColor = System.Drawing.Color.DimGray;
            this.info_RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info_RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info_RichTextBox.Location = new System.Drawing.Point(3, 70);
            this.info_RichTextBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.info_RichTextBox.Name = "info_RichTextBox";
            this.info_RichTextBox.ReadOnly = true;
            this.info_RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.info_RichTextBox.Size = new System.Drawing.Size(232, 181);
            this.info_RichTextBox.TabIndex = 6;
            this.info_RichTextBox.Text = "Title:";
            // 
            // rating_Label
            // 
            this.rating_Label.AutoSize = true;
            this.rating_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rating_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.rating_Label.Location = new System.Drawing.Point(241, 254);
            this.rating_Label.Name = "rating_Label";
            this.rating_Label.Size = new System.Drawing.Size(55, 12);
            this.rating_Label.TabIndex = 7;
            this.rating_Label.Text = "Rating: 4.50";
            this.rating_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // videoImg_PictureBox
            // 
            this.videoImg_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoImg_PictureBox.ImageLocation = "";
            this.videoImg_PictureBox.Location = new System.Drawing.Point(241, 53);
            this.videoImg_PictureBox.Name = "videoImg_PictureBox";
            this.videoImg_PictureBox.Size = new System.Drawing.Size(291, 198);
            this.videoImg_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.videoImg_PictureBox.TabIndex = 0;
            this.videoImg_PictureBox.TabStop = false;
            this.videoImg_PictureBox.WaitOnLoad = true;
            // 
            // audio_Panel
            // 
            this.audio_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.audio_Panel.Controls.Add(this.label1);
            this.audio_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audio_Panel.Location = new System.Drawing.Point(0, 0);
            this.audio_Panel.Name = "audio_Panel";
            this.audio_Panel.Size = new System.Drawing.Size(681, 452);
            this.audio_Panel.TabIndex = 9;
            this.audio_Panel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Audio Panel";
            // 
            // video_Panel
            // 
            this.video_Panel.Controls.Add(this.video_Label);
            this.video_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.video_Panel.Location = new System.Drawing.Point(0, 0);
            this.video_Panel.Name = "video_Panel";
            this.video_Panel.Size = new System.Drawing.Size(681, 452);
            this.video_Panel.TabIndex = 1;
            this.video_Panel.Visible = false;
            // 
            // video_Label
            // 
            this.video_Label.AutoSize = true;
            this.video_Label.Location = new System.Drawing.Point(262, 112);
            this.video_Label.Name = "video_Label";
            this.video_Label.Size = new System.Drawing.Size(64, 13);
            this.video_Label.TabIndex = 0;
            this.video_Label.Text = "Video Panel";
            // 
            // media_Panel
            // 
            this.media_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.media_Panel.Controls.Add(this.label2);
            this.media_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.media_Panel.Location = new System.Drawing.Point(0, 0);
            this.media_Panel.Name = "media_Panel";
            this.media_Panel.Size = new System.Drawing.Size(681, 452);
            this.media_Panel.TabIndex = 1;
            this.media_Panel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Media";
            // 
            // settings_Panel
            // 
            this.settings_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settings_Panel.Controls.Add(this.label3);
            this.settings_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_Panel.Location = new System.Drawing.Point(0, 0);
            this.settings_Panel.Name = "settings_Panel";
            this.settings_Panel.Size = new System.Drawing.Size(681, 452);
            this.settings_Panel.TabIndex = 1;
            this.settings_Panel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Settings";
            // 
            // BaseYTVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 452);
            this.Controls.Add(this.mux_Panel);
            this.Controls.Add(this.menuStrip_LayoutPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.topBar_Panel);
            this.Controls.Add(this.settings_Panel);
            this.Controls.Add(this.video_Panel);
            this.Controls.Add(this.audio_Panel);
            this.Controls.Add(this.media_Panel);
            this.Controls.Add(this.home_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseYTVideoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaseYTVideoForm_Load);
            this.topBar_Panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip_LayoutPanel.ResumeLayout(false);
            this.menuStrip_LayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.home_Panel.ResumeLayout(false);
            this.home_Panel.PerformLayout();
            this.mux_Panel.ResumeLayout(false);
            this.mux_Panel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.info_LayoutPanel.ResumeLayout(false);
            this.info_LayoutPanel.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoImg_PictureBox)).EndInit();
            this.audio_Panel.ResumeLayout(false);
            this.audio_Panel.PerformLayout();
            this.video_Panel.ResumeLayout(false);
            this.video_Panel.PerformLayout();
            this.media_Panel.ResumeLayout(false);
            this.media_Panel.PerformLayout();
            this.settings_Panel.ResumeLayout(false);
            this.settings_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel topBar_Panel;
        private System.Windows.Forms.Button minimize_Btn;
        private System.Windows.Forms.Button maximize_Btn;
        private System.Windows.Forms.Button close_Btn;
        protected System.Windows.Forms.TextBox httpsInput_TextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label url_Label;
        private System.Windows.Forms.TableLayoutPanel menuStrip_LayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Button home_Btn;
        protected System.Windows.Forms.Panel home_Panel;
        public System.Windows.Forms.Panel mux_Panel;
        private System.Windows.Forms.Button downloadInfo_Btn;
        private System.Windows.Forms.Button download_Btn;
        private System.Windows.Forms.TableLayoutPanel info_LayoutPanel;
        protected System.Windows.Forms.PictureBox videoImg_PictureBox;
        protected System.Windows.Forms.RichTextBox info_RichTextBox;
        protected System.Windows.Forms.Label rating_Label;
        private System.Windows.Forms.Label welcome_Label;
        protected System.Windows.Forms.RichTextBox welcome_RichBox;
        protected System.Windows.Forms.Button mux_Btn;
        protected System.Windows.Forms.Panel audio_Panel;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button audio_Btn;
        protected System.Windows.Forms.Panel video_Panel;
        private System.Windows.Forms.Label video_Label;
        protected System.Windows.Forms.Button video_Btn;
        protected System.Windows.Forms.Panel media_Panel;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button Media_Btn;
        protected System.Windows.Forms.Panel settings_Panel;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Button settings_Btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        protected System.Windows.Forms.Label loading_Label;
        protected System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

