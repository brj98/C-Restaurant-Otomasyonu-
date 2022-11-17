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
    public partial class FormMenu1 : DevExpress.XtraEditors.XtraForm
    {
        int mov;
        int movx;
        int movy;
        public FormMenu1()
        {
            InitializeComponent();
        }
        RestorantOEntities2 db = new RestorantOEntities2();

        void listele()
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
       

       

        private void FormMenu1_Load(object sender, EventArgs e)
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

            var m = (from x in db.Menü
                     select new
                     {
                         x.kategori,
                         x.ID,
                     }).ToList();
            cbk.ValueMember = "ID";
            cbk.DisplayMember = "kategori";
            cbk.DataSource = m;
            
        }

        private void lbekle_Click(object sender, EventArgs e)
        {
            FrmKategori frmk = new FrmKategori();
            frmk.Show();
           
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if(txtur.Text==""&&txtf.Text=="")
            {
                MessageBox.Show("Lütfen ürün adını ve fiyatını giriniz..");
            }
            else if(txtur.Text=="")
            {
                MessageBox.Show("Lütfen ürün adını yazınız..");
            }
             else if(txtf.Text =="")
            {
                MessageBox.Show("Lütfen ürün fiyatını giriniz..");
            }
            else
            {

                Menüİtem mi = new Menüİtem();
                mi.ÜrünAd = txtur.Text;
                mi.Fiyat = float.Parse(txtf.Text);
                mi.ID_Menü = int.Parse(cbk.SelectedValue.ToString());
                db.Menüİtem.Add(mi);
                db.SaveChanges();
                MessageBox.Show("Ürün Eklendi !");
                listele();
            }
          

           
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtur.Text == "" && txtf.Text == "")
            {
                MessageBox.Show("Lütfen ürün adını ve fiyatını giriniz..");
            }
            else if (txtur.Text == "")
            {
                MessageBox.Show("Lütfen ürün adını yazınız..");
            }
            else if (txtf.Text == "")
            {
                MessageBox.Show("Lütfen ürün fiyatını giriniz..");
            }
            else
            {
                int id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID").ToString());
                var mi = db.Menüİtem.Find(id);
                mi.ÜrünAd = txtur.Text;
                mi.Fiyat = float.Parse(txtf.Text);
                mi.ID_Menü = int.Parse(cbk.SelectedValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Ürün Güncelendi !");
                listele();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Sipariş sr = new Sipariş();

            Menüİtem me = new Menüİtem();

            if (me.ID==sr.ID_Menüitem)
            {
                MessageBox.Show("Kayit silemezsiniz iliski");
            }
           
          else if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
    
                int id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID").ToString());
                var mi = db.Menüİtem.Find(id);
                db.Menüİtem.Remove(mi);
                db.SaveChanges();
                MessageBox.Show("Ürün Silindi !");
                listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
                txtf.Text = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
                txtur.Text = gridView1.GetFocusedRowCellValue("ÜrünAd").ToString();
                cbk.Text = gridView1.GetFocusedRowCellValue("kategori").ToString();

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void txtf_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtf.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
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
            if(mov==1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
            

        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtf.Text = "";
            txtur.Text = "";
         
        }

        private void txtur_KeyPress(object sender, KeyPressEventArgs e)
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