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
using Ticari_Otomasyon_Proje.Entity;

namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {
            /*lookUpEdit1.Properties.DataSource = (from x in db.TblKategori
                                                 select new
                                                 {
                                                     x.KategoriID,
                                                     x.KategoriAd
                                                 }).ToList();*/
        }

        private void BtnYeniUrun_Click(object sender, EventArgs e)
        {
            TblUrun t = new TblUrun();
            t.UrunAd = TxtUrunAd.Text;
            t.Stok = short.Parse(TxtStokSayisi.Text);
            t.AlisFiyat = decimal.Parse(TxtAlisFiyat.Text);
            t.SatisFiyat = decimal.Parse(TxtSatisFiyat.Text);
            t.Kategori = int.Parse(TxtKategoriId.Text);
            //t.Kategori = int.Parse(lookUpEdit1.EditValue.ToString());
            //t.KritikSeviye = false;
            db.TblUrun.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ürün ekleme işlemi başarılı bir şekilde gerçekleşti",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
