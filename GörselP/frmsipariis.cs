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
    public partial class frmsipariis : DevExpress.XtraEditors.XtraForm
    {
        int mov;
        int movx;
        int movy;
        public frmsipariis()
        {
            InitializeComponent();
        }
        RestorantOEntities2 db = new RestorantOEntities2();
        void list()
        {
            var menüİtems = (from x in db.Menüİtem
                             select new
                             {
                                 x.ID,
                                 x.ÜrünAd,
                                 x.Menü.kategori,
                                 x.Fiyat,
                             }).ToList();

            gridControl1.DataSource = menüİtems;

        }
        void list2()
        {
            var sip = (from x in db.Sipariş
                       select new
                       {
                           x.ID,
                           x.Masa.Masa_No,
                           x.Menüİtem.ÜrünAd,
                           x.Menüİtem.Fiyat,
                           x.Adet,
                           x.Toplam,
                           x.Sipariş_No
                       }).ToList();

            gridControl2.DataSource = sip;
        }
        private void frmsipariis_Load(object sender, EventArgs e)
        {
            list();
            list2();
            var m = (from x in db.Masas
                     select new
                     {
                         x.Masa_No,
                         x.ID,
                     }).ToList();
            cbmasa.ValueMember = "ID";
            cbmasa.DisplayMember = "Masa_No";
            cbmasa.DataSource = m;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtfiyat.Text = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
            txturun.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if(txtSNO.Text=="")
            {
                MessageBox.Show("Lütfen sipariş numarası giriniz..");
            }
            else
            {
            Sipariş mi = new Sipariş();
            mi.ID_Menüitem = int.Parse(txturun.Text);
            mi.ID_Masa = int.Parse(cbmasa.SelectedValue.ToString());
            mi.Sipariş_No = int.Parse(txtSNO.Text);
            mi.Adet = int.Parse(tadet.Text);
            mi.Toplam = Convert.ToDouble(tadet.Text) * Convert.ToDouble(txtfiyat.Text);
            db.Sipariş.Add(mi);
            db.SaveChanges();
            MessageBox.Show("Sipariş Eklendi !");
            list2();
            }
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt16(gridView2.GetFocusedRowCellValue("ID").ToString());
                var mi = db.Sipariş.Find(id);
                db.Sipariş.Remove(mi);
                db.SaveChanges();
                MessageBox.Show("Sipariş Silindi !");
                list2();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void lbanasayfa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}