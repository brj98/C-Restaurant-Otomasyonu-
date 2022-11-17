
namespace GörselP
{
    partial class FrmKategori
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
            this.btnekle = new DevExpress.XtraEditors.SimpleButton();
            this.txtkategori = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkategori.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnekle
            // 
            this.btnekle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnekle.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnekle.Appearance.Options.UseBackColor = true;
            this.btnekle.Appearance.Options.UseFont = true;
            this.btnekle.Location = new System.Drawing.Point(86, 75);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(156, 36);
            this.btnekle.TabIndex = 68;
            this.btnekle.Text = "Ekle";
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(30, 23);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtkategori.Properties.Appearance.Options.UseFont = true;
            this.txtkategori.Size = new System.Drawing.Size(269, 32);
            this.txtkategori.TabIndex = 91;
            // 
            // FrmKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 140);
            this.Controls.Add(this.txtkategori);
            this.Controls.Add(this.btnekle);
            this.Name = "FrmKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtkategori.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtkategori;
        public DevExpress.XtraEditors.SimpleButton btnekle;
    }
}

