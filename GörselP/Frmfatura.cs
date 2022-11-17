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
using DGVPrinterHelper;

namespace GörselP
{
    public partial class Frmfatura : DevExpress.XtraEditors.XtraForm
    {
        int mov;
        int movx;
        int movy;
        public Frmfatura()
        {
            InitializeComponent();
        }
       RestorantOEntities2 db = new RestorantOEntities2();
        DataTable tb = new DataTable();

        void list()
        {
            var sip = (from x in db.Sipariş.OrderByDescending(x=>x.Sipariş_No)
                       select new
                       {
                           x.Sipariş_No,
                           x.Masa.Masa_No,
                           x.Menüİtem.ÜrünAd,
                           x.Menüİtem.Fiyat,
                           x.Adet,
                           x.Toplam  
                       }).ToList();

            gridControl2.DataSource = sip;
        }
        int No = 0;
        int Fiyat, Adet, Toplam ;
        string ÜrünAd;
        int flag = 0;
        
        private void btnekle_Click(object sender, EventArgs e)
        {
             
            if (flag == 0)
            {
                MessageBox.Show("Sipariş seç ");
            }
           
            tb.Rows.Add(No, ÜrünAd, Fiyat, Adet, Toplam);
         
            guna2DataGridView1.DataSource = tb;
            flag = 0;

           guna2DataGridView1[0, guna2DataGridView1.Rows.Count - 1].Value = "-";
            guna2DataGridView1[1, guna2DataGridView1.Rows.Count - 1].Value = "-";
            guna2DataGridView1[2, guna2DataGridView1.Rows.Count - 1].Value = "-";
           guna2DataGridView1[3, guna2DataGridView1.Rows.Count - 1].Value = "TOPLAM";
            decimal tot = 0;
            for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
            {
                var value = guna2DataGridView1.Rows[i].Cells[4].Value;
                if (value != DBNull.Value)
                {
                    tot += Convert.ToDecimal(value);
                }
            }
            if (tot == 0)
            {
            }

            guna2DataGridView1.Rows[guna2DataGridView1.Rows.Count - 1].Cells[4].Value = tot.ToString();
        }

        int rowindex = 0;
        private void guna2DataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
          if (e.Button==MouseButtons.Right)
            {
                this.guna2DataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowindex = e.RowIndex;
                this.guna2DataGridView1.CurrentCell = this.guna2DataGridView1.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.guna2DataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!this.guna2DataGridView1.Rows[this.rowindex].IsNewRow)
            {
                this.guna2DataGridView1.Rows.RemoveAt(this.rowindex);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            decimal tot = 0;
            for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
            {
                var value = guna2DataGridView1.Rows[i].Cells[4].Value;
                if (value != DBNull.Value)
                {
                    tot += Convert.ToDecimal(value);
                }
            }
            if (tot == 0)
            {
            }

            DGVPrinter yazdir = new DGVPrinter();
            yazdir.Title = "FATURA";
            //yazdir.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            yazdir.SubTitle= string.Format("Fatura Tarihi: {0}", DateTime.Now.ToString("dd.MM.yyyy HH:mm")) + "" +
                "       TOPLAM =   " + tot.ToString()+" TL"; 
            yazdir.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            yazdir.PageNumbers = true;
            yazdir.PageNumberInHeader = false;
            yazdir.PorportionalColumns = true;
            yazdir.HeaderCellAlignment = StringAlignment.Near;
            yazdir.Footer = "AFIYET OLSUN";
            yazdir.FooterSpacing = 15;
            yazdir.printDocument.DefaultPageSettings.Landscape = true;
            yazdir.PrintPreviewDataGridView(guna2DataGridView1);
           
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
            this.Close();
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

        private void lbanasayfa_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            No =Convert.ToInt32(gridView2.GetFocusedRowCellValue("Sipariş_No").ToString());
            ÜrünAd = gridView2.GetFocusedRowCellValue("ÜrünAd").ToString();
            Fiyat = Convert.ToInt32(gridView2.GetFocusedRowCellValue("Fiyat").ToString());
            Adet= Convert.ToInt32(gridView2.GetFocusedRowCellValue("Adet").ToString());
            Toplam = Convert.ToInt32(gridView2.GetFocusedRowCellValue("Toplam").ToString());
            flag = 1;
        }

        
        private void Frmfatura_Load(object sender, EventArgs e)
        {
          list();
            tb.Columns.Add("No",typeof(int)) ;
            tb.Columns.Add("ÜrünAd", typeof(string));
            tb.Columns.Add("Fiyat", typeof(int));
            tb.Columns.Add("Adet", typeof(int));
            tb.Columns.Add("Toplam", typeof(int));
            guna2DataGridView1.DataSource = tb;

        }
    }
}