
namespace GörselP
{
    partial class frmsipariis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsipariis));
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnekle = new DevExpress.XtraEditors.SimpleButton();
            this.tadet = new DevExpress.XtraEditors.SpinEdit();
            this.cbmasa = new System.Windows.Forms.ComboBox();
            this.txturun = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtfiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSNO = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lbanasayfa = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tadet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsil
            // 
            this.btnsil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsil.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnsil.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnsil.Appearance.Options.UseBackColor = true;
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.Appearance.Options.UseForeColor = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(642, 509);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(129, 47);
            this.btnsil.TabIndex = 114;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridControl1.Location = new System.Drawing.Point(3, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(485, 557);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridView1.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridView1.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridControl2.Location = new System.Drawing.Point(3, 37);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(581, 560);
            this.gridControl2.TabIndex = 114;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridView2.Appearance.OddRow.Options.UseFont = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridView2.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridView2.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.Location = new System.Drawing.Point(531, 157);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 25);
            this.labelControl6.TabIndex = 113;
            this.labelControl6.Text = "Fiyat";
            // 
            // btnekle
            // 
            this.btnekle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnekle.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnekle.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnekle.Appearance.Options.UseBackColor = true;
            this.btnekle.Appearance.Options.UseFont = true;
            this.btnekle.Appearance.Options.UseForeColor = true;
            this.btnekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnekle.ImageOptions.Image")));
            this.btnekle.Location = new System.Drawing.Point(642, 445);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(129, 47);
            this.btnekle.TabIndex = 110;
            this.btnekle.Text = "Kaydet";
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // tadet
            // 
            this.tadet.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tadet.Location = new System.Drawing.Point(642, 291);
            this.tadet.Name = "tadet";
            this.tadet.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tadet.Properties.Appearance.Options.UseFont = true;
            this.tadet.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tadet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tadet.Properties.MaxValue = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.tadet.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tadet.Size = new System.Drawing.Size(129, 32);
            this.tadet.TabIndex = 91;
            // 
            // cbmasa
            // 
            this.cbmasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbmasa.FormattingEnabled = true;
            this.cbmasa.Location = new System.Drawing.Point(642, 221);
            this.cbmasa.Name = "cbmasa";
            this.cbmasa.Size = new System.Drawing.Size(129, 33);
            this.cbmasa.TabIndex = 101;
            // 
            // txturun
            // 
            this.txturun.Location = new System.Drawing.Point(642, 99);
            this.txturun.Name = "txturun";
            this.txturun.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txturun.Properties.Appearance.Options.UseFont = true;
            this.txturun.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txturun.Properties.ReadOnly = true;
            this.txturun.Size = new System.Drawing.Size(129, 32);
            this.txturun.TabIndex = 112;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Location = new System.Drawing.Point(810, 48);
            this.groupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(587, 600);
            this.groupControl1.TabIndex = 116;
            this.groupControl1.Text = "Siparişler";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.Location = new System.Drawing.Point(508, 229);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 25);
            this.labelControl5.TabIndex = 102;
            this.labelControl5.Text = "Masa ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(508, 300);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 25);
            this.labelControl2.TabIndex = 104;
            this.labelControl2.Text = "Adet";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(642, 163);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtfiyat.Properties.Appearance.Options.UseFont = true;
            this.txtfiyat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtfiyat.Properties.ReadOnly = true;
            this.txtfiyat.Size = new System.Drawing.Size(129, 32);
            this.txtfiyat.TabIndex = 111;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(520, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 25);
            this.labelControl1.TabIndex = 103;
            this.labelControl1.Text = "Ürün ID";
            // 
            // txtSNO
            // 
            this.txtSNO.Location = new System.Drawing.Point(642, 363);
            this.txtSNO.Name = "txtSNO";
            this.txtSNO.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSNO.Properties.Appearance.Options.UseFont = true;
            this.txtSNO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtSNO.Size = new System.Drawing.Size(129, 32);
            this.txtSNO.TabIndex = 107;
            this.txtSNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSNO_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl4.Location = new System.Drawing.Point(508, 366);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 25);
            this.labelControl4.TabIndex = 108;
            this.labelControl4.Text = "Sipariş No";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.btnsil);
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.btnekle);
            this.groupControl2.Controls.Add(this.tadet);
            this.groupControl2.Controls.Add(this.cbmasa);
            this.groupControl2.Controls.Add(this.txturun);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txtfiyat);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtSNO);
            this.groupControl2.Location = new System.Drawing.Point(0, 48);
            this.groupControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(804, 597);
            this.groupControl2.TabIndex = 117;
            this.groupControl2.Text = "Menü";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel1.Controls.Add(this.labelControl3);
            this.Panel1.Controls.Add(this.labelControl7);
            this.Panel1.Controls.Add(this.lbanasayfa);
            this.Panel1.Controls.Add(this.simpleButton3);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1409, 41);
            this.Panel1.TabIndex = 125;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(1366, 0);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(43, 41);
            this.simpleButton3.TabIndex = 81;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl3.Location = new System.Drawing.Point(208, 0);
            this.labelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.labelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(150, 41);
            this.labelControl3.TabIndex = 102;
            this.labelControl3.Text = "Siparişler";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl7.Location = new System.Drawing.Point(185, 0);
            this.labelControl7.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.labelControl7.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(23, 41);
            this.labelControl7.TabIndex = 101;
            this.labelControl7.Text = "/";
            // 
            // lbanasayfa
            // 
            this.lbanasayfa.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbanasayfa.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbanasayfa.Appearance.Options.UseFont = true;
            this.lbanasayfa.Appearance.Options.UseForeColor = true;
            this.lbanasayfa.AppearanceHovered.BackColor = System.Drawing.Color.SlateBlue;
            this.lbanasayfa.AppearanceHovered.Options.UseBackColor = true;
            this.lbanasayfa.AppearancePressed.BackColor = System.Drawing.Color.SlateBlue;
            this.lbanasayfa.AppearancePressed.Options.UseBackColor = true;
            this.lbanasayfa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbanasayfa.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbanasayfa.Location = new System.Drawing.Point(0, 0);
            this.lbanasayfa.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.lbanasayfa.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lbanasayfa.Name = "lbanasayfa";
            this.lbanasayfa.Size = new System.Drawing.Size(185, 41);
            this.lbanasayfa.TabIndex = 100;
            this.lbanasayfa.Text = " Ana Sayfa";
            this.lbanasayfa.Click += new System.EventHandler(this.lbanasayfa_Click);
            // 
            // frmsipariis
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1409, 653);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsipariis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsipariis";
            this.Load += new System.EventHandler(this.frmsipariis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tadet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnekle;
        private DevExpress.XtraEditors.SpinEdit tadet;
        private System.Windows.Forms.ComboBox cbmasa;
        private DevExpress.XtraEditors.TextEdit txturun;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtfiyat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSNO;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        internal System.Windows.Forms.Panel Panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lbanasayfa;
    }
}