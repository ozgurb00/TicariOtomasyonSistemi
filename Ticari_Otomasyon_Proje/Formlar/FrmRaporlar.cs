using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.Entity;

namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }


        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        
        void urunler()
        {
            gridControl1.DataSource = (from x in db.TblUrun
                                       select new
                                       {
                                           x.UrunId,
                                           x.UrunAd,
                                           x.Stok,
                                           x.AlisFiyat,
                                           x.SatisFiyat,
                                           x.TblKategori.KategoriAd
                                       }).ToList();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            urunler();
        }

        private void BtnPdfRapor_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Pdf";
            gridControl1.ExportToPdf(path);
        }

        private void BtnExcelRapor_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Xls";
            gridControl1.ExportToXls(path);
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
