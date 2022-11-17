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
    public partial class FrmPersonal : DevExpress.XtraEditors.XtraForm
    {
        int mov;
        int movx;
        int movy;
        public FrmPersonal()
        {
            InitializeComponent();
        }
        RestorantOEntities2 db = new RestorantOEntities2();

        void list()
        {
            List<Personal> personals = db.Personals.ToList();
            gridControl1.DataSource = personals;
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            if(txtad.Text==""&&txtmaas.Text==""&&txtsoyad.Text==""&&txtrol.Text=="")
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if(txtad.Text == "")
            {
                MessageBox.Show("Ad alanı boş..!!");
            }
            else if (txtsoyad.Text == "")
            {
                MessageBox.Show("SoyAd alanı boş..!!");
            }
            else if (txtmaas.Text == "")
            {
                MessageBox.Show("Maaş alanı boş..!!");
            }
            else if (txtrol.Text == "")
            {
                MessageBox.Show("Rol alanı boş..!!");
            }
            
            else
            {
            Personal personal = new Personal();
            personal.Ad = txtad.Text;
            personal.SoyAd = txtsoyad.Text;
            personal.Maaş = float.Parse(txtmaas.Text); 
            personal.Rol = txtrol.Text;
            db.Personals.Add(personal);
            db.SaveChanges();
            MessageBox.Show("Personel Eklendi !");
            list();
            }

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" && txtmaas.Text == "" && txtsoyad.Text == "" && txtrol.Text == "")
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (txtad.Text == "")
            {
                MessageBox.Show("Ad alanı boş..!!");
            }
            else if (txtsoyad.Text == "")
            {
                MessageBox.Show("SoyAd alanı boş..!!");
            }
            else if (txtmaas.Text == "")
            {
                MessageBox.Show("Maaş alanı boş..!!");
            }
            else if (txtrol.Text == "")
            {
                MessageBox.Show("Rol alanı boş..!!");
            }
            else
            {
                int id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID").ToString());
                var personal = db.Personals.Find(id);
                personal.Ad = txtad.Text;
                personal.SoyAd = txtsoyad.Text;
                personal.Maaş = float.Parse(txtmaas.Text);
                personal.Rol = txtrol.Text;
                db.SaveChanges();
                MessageBox.Show("Personel Güncellendi !");
                list();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID").ToString());
                var personal = db.Personals.Find(id);
                db.Personals.Remove(personal);
                db.SaveChanges();
                MessageBox.Show("Personel Silindi !");
                list();
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            txtad.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtsoyad.Text = gridView1.GetFocusedRowCellValue("SoyAd").ToString();
            txtmaas.Text = gridView1.GetFocusedRowCellValue("Maaş").ToString();
            txtrol.Text = gridView1.GetFocusedRowCellValue("Rol").ToString();

        }

        private void lbHome_Click(object sender, EventArgs e)
        {
            FrmMain frmm = new FrmMain();
            frmm.Show();
            this.Close();
            
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            list();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtmaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

          if(ch==46&&txtmaas.Text.IndexOf('.')!=-1)
            {
                e.Handled = true;
                return;
            }
          if(!char.IsDigit(ch) && ch !=  8 && ch != 46)
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
            txtad.Text = "";
            txtsoyad.Text = "";
            txtmaas.Text = "";
            txtrol.Text = "";
        }

        private void txtad_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtrol_KeyPress(object sender, KeyPressEventArgs e)
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