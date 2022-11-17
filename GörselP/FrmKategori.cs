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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        RestorantOEntities2 db = new RestorantOEntities2();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Menü men = new Menü();
            men.kategori = txtkategori.Text;
            db.Menü.Add(men);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi !");


        }
    }
}
