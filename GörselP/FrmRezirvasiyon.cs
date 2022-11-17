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
    public partial class FrmRezirvasiyon : DevExpress.XtraEditors.XtraForm
    {
        int mov;
        int movx;
        int movy;
        public FrmRezirvasiyon()
        {
            InitializeComponent();
        }
        RestorantOEntities2 db = new RestorantOEntities2();
        void list()
        {
            var rez = (from x in db.Rezervasiyons
                             select new
                             {
                                 x.ID,
                                 x.MüşteriAd,
                                 x.TelefonNO,
                                 x.RezervasiyonTarihi,
                                 x.Masa.Masa_No,

                             }).ToList();

            gridControl1.DataSource = rez;
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            if(txtMA.Text==""&&txtnumara.Text=="")
            {
                MessageBox.Show("Lütfen müşterinin adını ve telefon numarasını giriniz..");
            }
           else if(txtMA.Text=="")
            {
                MessageBox.Show("Lütfen müşteri adını giriniz..");
            }
           else if (txtnumara.Text == "")
            {
                MessageBox.Show("Lütfen telefon numarasını giriniz..");
            }
            else
            {
            Rezervasiyon mi = new Rezervasiyon();
            mi.MüşteriAd = txtMA.Text;
            mi.TelefonNO = txtnumara.Text;
            mi.RezervasiyonTarihi = dTIME.DateTime;
            mi.Masa_ID = int.Parse(cbMasa.SelectedValue.ToString());
            db.Rezervasiyons.Add(mi);
            db.SaveChanges();
            MessageBox.Show("Rezervasyon Eklendi !");
            list();
            }
        }

        private void FrmRezirvasiyon_Load(object sender, EventArgs e)
        {
            var m = (from x in db.Masas
                     select new
                     {
                         x.Masa_No,
                         x.ID,
                     }).ToList();
            cbMasa.ValueMember = "ID";
            cbMasa.DisplayMember = "Masa_No";
            cbMasa.DataSource = m;
            

            list();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtMA.Text == "" && txtnumara.Text == "")
            {
                MessageBox.Show("Lütfen müşterinin adını ve telefon numarasını giriniz..");
            }
            else if (txtMA.Text == "")
            {
                MessageBox.Show("Lütfen müşteri adını giriniz..");
            }
            else if (txtnumara.Text == "")
            {
                MessageBox.Show("Lütfen telefon numarasını giriniz..");
            }
            else
            {
                int id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID").ToString());
                var rez = db.Rezervasiyons.Find(id);
                rez.MüşteriAd = txtMA.Text;
                rez.TelefonNO = txtnumara.Text;
                rez.RezervasiyonTarihi = dTIME.DateTime;
                rez.Masa_ID = int.Parse(cbMasa.SelectedValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Rezervasyon Güncellendi !");
                list();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID").ToString());
                var rez = db.Rezervasiyons.Find(id);
                db.Rezervasiyons.Remove(rez);
                db.SaveChanges();
                MessageBox.Show("Rezervasyon Silindi !");
                list();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMA.Text = gridView1.GetFocusedRowCellValue("MüşteriAd").ToString();
            txtnumara.Text = gridView1.GetFocusedRowCellValue("TelefonNO").ToString();
            dTIME.Text = gridView1.GetFocusedRowCellValue("RezervasiyonTarihi").ToString();
            cbMasa.Text = gridView1.GetFocusedRowCellValue("Masa_No").ToString();
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

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtMA.Text = "";
            txtnumara.Text = "";
            txtMA.Focus();
        }

        private void txtMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
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