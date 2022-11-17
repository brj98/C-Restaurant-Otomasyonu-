
namespace GörselP
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem4 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem5 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem6 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem7 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.radialMenu1 = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resim = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
            this.barLargeButtonItem3,
            this.barLargeButtonItem4,
            this.barLargeButtonItem5,
            this.barLargeButtonItem6,
            this.barLargeButtonItem7});
            this.barManager1.LargeImages = this.imageCollection1;
            this.barManager1.MaxItemId = 7;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(839, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 550);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(839, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 550);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(839, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 550);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Kullanıcılar";
            this.barLargeButtonItem1.Id = 0;
            this.barLargeButtonItem1.ImageOptions.LargeImageIndex = 0;
            this.barLargeButtonItem1.ItemInMenuAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.barLargeButtonItem1.ItemInMenuAppearance.Normal.Options.UseForeColor = true;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            this.barLargeButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem1_ItemClick);
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "Menü";
            this.barLargeButtonItem2.Id = 1;
            this.barLargeButtonItem2.ImageOptions.LargeImageIndex = 1;
            this.barLargeButtonItem2.ItemInMenuAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.barLargeButtonItem2.ItemInMenuAppearance.Normal.Options.UseForeColor = true;
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            this.barLargeButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem2_ItemClick);
            // 
            // barLargeButtonItem3
            // 
            this.barLargeButtonItem3.Caption = "Personel";
            this.barLargeButtonItem3.Id = 2;
            this.barLargeButtonItem3.ImageOptions.LargeImageIndex = 2;
            this.barLargeButtonItem3.ItemInMenuAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.barLargeButtonItem3.ItemInMenuAppearance.Normal.Options.UseForeColor = true;
            this.barLargeButtonItem3.Name = "barLargeButtonItem3";
            this.barLargeButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem3_ItemClick);
            // 
            // barLargeButtonItem4
            // 
            this.barLargeButtonItem4.Caption = "Rezervasyonlar";
            this.barLargeButtonItem4.Id = 3;
            this.barLargeButtonItem4.ImageOptions.LargeImageIndex = 3;
            this.barLargeButtonItem4.ItemInMenuAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.barLargeButtonItem4.ItemInMenuAppearance.Normal.Options.UseForeColor = true;
            this.barLargeButtonItem4.Name = "barLargeButtonItem4";
            this.barLargeButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem4_ItemClick);
            // 
            // barLargeButtonItem5
            // 
            this.barLargeButtonItem5.Caption = "Çıkış";
            this.barLargeButtonItem5.Id = 4;
            this.barLargeButtonItem5.ImageOptions.LargeImageIndex = 4;
            this.barLargeButtonItem5.Name = "barLargeButtonItem5";
            this.barLargeButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem5_ItemClick);
            // 
            // barLargeButtonItem6
            // 
            this.barLargeButtonItem6.Caption = "Sipariş";
            this.barLargeButtonItem6.Id = 5;
            this.barLargeButtonItem6.ImageOptions.LargeImageIndex = 5;
            this.barLargeButtonItem6.Name = "barLargeButtonItem6";
            this.barLargeButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem6_ItemClick);
            // 
            // barLargeButtonItem7
            // 
            this.barLargeButtonItem7.Caption = "Faturalar";
            this.barLargeButtonItem7.Id = 6;
            this.barLargeButtonItem7.ImageOptions.LargeImageIndex = 6;
            this.barLargeButtonItem7.Name = "barLargeButtonItem7";
            this.barLargeButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem7_ItemClick);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "icons8_user_shield_32.png");
            this.imageCollection1.Images.SetKeyName(1, "icons8_dining_32.png");
            this.imageCollection1.Images.SetKeyName(2, "icons8_name_tag_32.png");
            this.imageCollection1.Images.SetKeyName(3, "icons8_purchase_order_32.png");
            this.imageCollection1.Images.SetKeyName(4, "icons8_shutdown_32.png");
            this.imageCollection1.Images.SetKeyName(5, "icons8_give_32.png");
            this.imageCollection1.Images.SetKeyName(6, "icons8_pos_terminal_32.png");
            // 
            // radialMenu1
            // 
            this.radialMenu1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.radialMenu1.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radialMenu1.ButtonRadius = 30;
            this.radialMenu1.Glyph = ((System.Drawing.Image)(resources.GetObject("radialMenu1.Glyph")));
            this.radialMenu1.InnerRadius = 90;
            this.radialMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem7)});
            this.radialMenu1.Manager = this.barManager1;
            this.radialMenu1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radialMenu1.Name = "radialMenu1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton1.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton1.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton1.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton1.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton1.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(377, 375);
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(67, 59);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resim
            // 
            this.resim.FillColor = System.Drawing.Color.Empty;
            this.resim.Image = ((System.Drawing.Image)(resources.GetObject("resim.Image")));
            this.resim.ImageRotate = 0F;
            this.resim.Location = new System.Drawing.Point(22, 159);
            this.resim.Name = "resim";
            this.resim.ShadowDecoration.Parent = this.resim;
            this.resim.Size = new System.Drawing.Size(217, 177);
            this.resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim.TabIndex = 15;
            this.resim.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(180, 61);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(470, 92);
            this.labelControl5.TabIndex = 83;
            this.labelControl5.Text = "🍕 Hoş Geldiniz 🍔";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 16.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(293, 456);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(221, 42);
            this.labelControl1.TabIndex = 84;
            this.labelControl1.Text = "Hadi Başlayalım";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel1.Controls.Add(this.simpleButton2);
            this.Panel1.Controls.Add(this.simpleButton3);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(839, 38);
            this.Panel1.TabIndex = 126;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton2.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton2.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton2.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton2.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton2.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(734, 0);
            this.simpleButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(40, 40);
            this.simpleButton2.TabIndex = 83;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton3.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton3.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton3.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton3.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton3.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton3.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton3.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(799, 0);
            this.simpleButton3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.simpleButton3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(40, 40);
            this.simpleButton3.TabIndex = 82;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton4.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton4.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton4.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton4.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton4.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.simpleButton4.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton4.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(12, 465);
            this.simpleButton4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.simpleButton4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.Size = new System.Drawing.Size(83, 73);
            this.simpleButton4.TabIndex = 127;
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // FrmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 550);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.resim);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem5;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2PictureBox resim;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        public DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        public DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem3;
        public DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem4;
        public DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem6;
        public DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem7;
        internal System.Windows.Forms.Panel Panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}