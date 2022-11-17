using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörselP
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        int mov;
        int movx;
        int movy;
        public FrmMain()
        {
            InitializeComponent();
        }

        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Point p = this.Location;
            p.Offset(this.Width / 2, this.Height / 2);
            radialMenu1.ShowPopup(p);
            //      barLargeButtonItem1.Enabled = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void barLargeButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu1.HidePopup();
            FrmKullanicilar frmm = new FrmKullanicilar();
            frmm.ShowDialog();
            
        }

        private void barLargeButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barLargeButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu1.HidePopup();
            FormMenu1 frmm = new FormMenu1();
            frmm.ShowDialog();  
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void barLargeButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu1.HidePopup();
            FrmPersonal frmp = new FrmPersonal();
            frmp.ShowDialog();
           

        }

        private void barLargeButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu1.HidePopup();
            FrmRezirvasiyon frmR = new FrmRezirvasiyon();
            frmR.ShowDialog();
            
        }

        private void barLargeButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu1.HidePopup();
            Frmfatura frmR = new Frmfatura();
            frmR.ShowDialog();
            
        }

        private void barLargeButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu1.HidePopup();
            frmsipariis frmR = new frmsipariis();
            frmR.ShowDialog();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int widh = this.Width;
            if(resim.Location.X>widh- resim.Width)
            {
                resim.Location = new Point(1, resim.Location.Y);
            }
            else
            {
                resim.Location = new Point(resim.Location.X +100, resim.Location.Y);
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmgiris frm = new Frmgiris();
            frm.Show();
            
        }
    }
}