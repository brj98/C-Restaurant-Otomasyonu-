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
    public partial class FrmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        int mov;
        int movx;
        int movy;
        public FrmKullanicilar()
        {
            InitializeComponent();
        }
        RestorantOEntities2 db = new RestorantOEntities2();
        void list()
        {
            List<Kullanicilar> kullanicilars = db.Kullanicilars.ToList();
            gridControl1.DataSource = kullanicilars;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (cekullanicilar.Checked == false && cefatura.Checked == false && cemenuitem.Checked == false
               && chpersonal.Checked == false && cerezervasiyon.Checked == false && cesiparis.Checked == false)
            {
                MessageBox.Show("En Az Bir Yetki Vermelisiniz..");
            }
            else if (txtkullaniciad.Text == "" && txtsifre.Text == "")
            {
                MessageBox.Show("Lütfen KullaıcıAdı Ve Şifre Giriniz..");
            }
           else if (txtkullaniciad.Text == "")
            {
                MessageBox.Show("KullaıcıAdı Alanı Boş..");
            }
            else if (txtsifre.Text == "")
            {
                MessageBox.Show("Şifre Alanı Boş..");
            }
            else
            {
                Kullanicilar mi = new Kullanicilar();
                mi.KullanciAd = txtkullaniciad.Text;
                mi.Şifre = txtsifre.Text;
                ////////kullanıcılar////////

                if (cekullanicilar.Checked == true)
                {
                    mi.kullanıcılar = true;
                }
                else
                {
                    mi.kullanıcılar = false;
                }
                //////menüitem//////////
                if (cemenuitem.Checked == true)
                {
                    mi.menüitem = true;
                }
                else
                {
                    mi.menüitem = false;
                }
                ////////sipariş//////////////
                if (cesiparis.Checked == true)
                {
                    mi.sipariş = true;
                }
                else
                {
                    mi.sipariş = false;
                }
                //////////personal////////////
                if (chpersonal.Checked == true)
                {
                    mi.personal = true;
                }
                else
                {
                    mi.personal = false;
                }
                ///////////rezirvasiyon///////////
                if (cerezervasiyon.Checked == true)
                {
                    mi.rezirvasiyon = true;
                }
                else
                {
                    mi.rezirvasiyon = false;
                }
                ///////////fatura///////////
                if (cefatura.Checked == true)
                {
                    mi.fatura = true;
                }
                else
                {
                    mi.fatura = false;
                }

                db.Kullanicilars.Add(mi);
                db.SaveChanges();
                MessageBox.Show("Kullanici Eklendi !");
                list();
            }
        }

        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {
            list();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if(cekullanicilar.Checked == false && cefatura.Checked == false && cemenuitem.Checked == false
                && chpersonal.Checked == false && cerezervasiyon.Checked == false && cesiparis.Checked == false)
            {
                MessageBox.Show("En Az Bir Yetki Vermelisiniz..");
            }
          else if(txtkullaniciad.Text == ""&& txtsifre.Text == "")
            {
                MessageBox.Show("Lütfen KullaıcıAdı Ve Şifre Giriniz..");
            }
           else if (txtkullaniciad.Text == "")
            {
                MessageBox.Show("KullaıcıAdı Alanı Boş..");
            }
            else if (txtsifre.Text == "")
            {
                MessageBox.Show("Şifre Alanı Boş..");
            }
            else
            {
                int id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID").ToString());
                var mi = db.Kullanicilars.Find(id);
                mi.KullanciAd = txtkullaniciad.Text;
                mi.Şifre = txtsifre.Text;
                ////////kullanıcılar////////

                if (cekullanicilar.Checked == true)
                {
                    mi.kullanıcılar = true;
                }
                else
                {
                    mi.kullanıcılar = false;
                }
                //////menüitem//////////
                if (cemenuitem.Checked == true)
                {
                    mi.menüitem = true;
                }
                else
                {
                    mi.menüitem = false;
                }

                ////////sipariş//////////////
                if (cesiparis.Checked == true)
                {
                    mi.sipariş = true;
                }
                else
                {
                    mi.sipariş = false;
                }
                //////////personal////////////
                if (chpersonal.Checked == true)
                {
                    mi.personal = true;
                }
                else
                {
                    mi.personal = false;
                }
                ///////////rezirvasiyon///////////
                if (cerezervasiyon.Checked == true)
                {
                    mi.rezirvasiyon = true;
                }
                else
                {
                    mi.rezirvasiyon = false;
                }
                ///////////fatura///////////
                if (cefatura.Checked == true)
                {
                    mi.fatura = true;
                }
                else
                {
                    mi.fatura = false;
                }

                db.SaveChanges();
                MessageBox.Show("Kullanici Guncellendi !");
                list();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID").ToString());
                var rez = db.Kullanicilars.Find(id);
                db.Kullanicilars.Remove(rez);
                db.SaveChanges();
                MessageBox.Show("Kullanici Silindi !");
                list();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtkullaniciad.Text = gridView1.GetFocusedRowCellValue("KullanciAd").ToString();
            txtsifre.Text = gridView1.GetFocusedRowCellValue("Şifre").ToString();
            if (gridView1.GetFocusedRowCellValue("personal").ToString() == "True")
            {
                chpersonal.Checked = true;
            }
            else
            {
                chpersonal.Checked = false;
            }
            //////////////
            if (gridView1.GetFocusedRowCellValue("rezirvasiyon").ToString() == "True")
            {
                cerezervasiyon.Checked = true;
            }
            else
            {
                cerezervasiyon.Checked = false;
            }
            //////////////
            if (gridView1.GetFocusedRowCellValue("sipariş").ToString() == "True")
            {
                cesiparis.Checked = true;
            }
            else
            {
                cesiparis.Checked = false;
            }
            //////////////
            if (gridView1.GetFocusedRowCellValue("menüitem").ToString() == "True")
            {
                cemenuitem.Checked = true;
            }
            else
            {
                cemenuitem.Checked = false;
            }
            //////////////
            if (gridView1.GetFocusedRowCellValue("kullanıcılar").ToString() == "True")
            {
                cekullanicilar.Checked = true;
            }
            else
            {
                cekullanicilar.Checked = false;
            }
            //////////////
            if (gridView1.GetFocusedRowCellValue("fatura").ToString() == "True")
            {
                cefatura.Checked = true;
            }
            else
            {
                cefatura.Checked = false;
            }


        }

       

     

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtkullaniciad.Text = "";
            txtsifre.Text = "";
            cefatura.Checked = false;
            cekullanicilar.Checked = false;
            cemenuitem.Checked = false;
            cerezervasiyon.Checked = false;
            cesiparis.Checked = false;
            chpersonal.Checked = false;
        }

        private void lbanasayfa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}