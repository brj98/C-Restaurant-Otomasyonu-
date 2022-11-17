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
    public partial class Frmgiris : DevExpress.XtraEditors.XtraForm
    {

        int mov;
        int movx;
        int movy;

        public Frmgiris()
        {
            InitializeComponent();
        }
        RestorantOEntities2 db = new RestorantOEntities2();

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btngiris_Click(object sender, EventArgs e)
        {

            Kullanicilar user = db.Kullanicilars.Where(x => x.KullanciAd == txtk.Text && x.Şifre == txts.Text).FirstOrDefault();
            if (txtk.Text != null && txts.Text != null && user != null)
            {
                FrmMain frm = new FrmMain();
                frm.Show();
                this.Hide();
                /////kullanıcılar///////
                if (user.kullanıcılar == true)
                {

                    frm.barLargeButtonItem1.Enabled = true;

                }
                else
                {
                    frm.barLargeButtonItem1.Enabled = false;
                }
                /////menüitem//////
                if (user.menüitem == true)
                {
                    frm.barLargeButtonItem2.Enabled = true;

                }
                else
                {
                    frm.barLargeButtonItem2.Enabled = false;
                }
                ////personal///////
                if (user.personal == true)
                {
                    frm.barLargeButtonItem3.Enabled = true;

                }
                else
                {
                    frm.barLargeButtonItem3.Enabled = false;
                }
                /////rezirvasiyon//////
                if (user.rezirvasiyon == true)
                {
                    frm.barLargeButtonItem4.Enabled = true;

                }
                else
                {
                    frm.barLargeButtonItem4.Enabled = false;
                }
                /////sipariş//////
                if (user.sipariş == true)
                {
                    frm.barLargeButtonItem6.Enabled = true;

                }
                else
                {
                    frm.barLargeButtonItem6.Enabled = false;
                }
                ////fatura///////
                if (user.fatura == true)
                {
                    frm.barLargeButtonItem7.Enabled = true;

                }
                else
                {
                    frm.barLargeButtonItem7.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEdit1.Checked==false)
            {
                txts.Properties.UseSystemPasswordChar = true;

            }
            else
            {
                txts.Properties.UseSystemPasswordChar = false;

            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}