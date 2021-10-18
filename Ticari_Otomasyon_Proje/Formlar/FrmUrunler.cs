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

namespace Ticari_Otomasyon_Proje
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

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

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TblKategori
                                                 select new
                                                 {
                                                     x.KategoriID,
                                                     x.KategoriAd
                                                 }).ToList();
            urunler();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            TblUrun t = new TblUrun();
            t.UrunAd = TxtAd.Text;
            t.Stok = short.Parse(TxtStok.Text);
            t.AlisFiyat = decimal.Parse(TxtAlisFiyat.Text);
            t.SatisFiyat = decimal.Parse(TxtSatisFiyat.Text);
            t.Kategori = int.Parse(lookUpEdit1.EditValue.ToString());
            db.TblUrun.Add(t);
            db.SaveChanges();

            XtraMessageBox.Show("Ürün ekleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunler();
        }

        

        private void BtnListele_Click(object sender, EventArgs e)
        {
            urunler();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if(TxtID.Text != "")
            {
                int id = int.Parse(TxtID.Text);
                var x = db.TblUrun.Find(id);db.TblUrun.Remove(x);
                db.SaveChanges();
                XtraMessageBox.Show("Ürün başarılı bir şekilde silindi",
                    "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                XtraMessageBox.Show("Lütfen verileri listeledikten sonra bir satıra tıklayıp silmek " +
                    "istediğiniz kaydı seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("UrunId").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("UrunAd").ToString();
            TxtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("AlisFiyat").ToString();
            TxtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SatisFiyat").ToString();
            TxtStok.Text = gridView1.GetFocusedRowCellValue("Stok").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("KategoriAd").ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var x = db.TblUrun.Find(id);
            x.UrunAd = TxtAd.Text;
            x.AlisFiyat = decimal.Parse(TxtSatisFiyat.Text);
            x.SatisFiyat = decimal.Parse(TxtSatisFiyat.Text);
            x.Stok = short.Parse(TxtStok.Text);
            x.Kategori = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Verileriniz başarılı bir şekilde güncellendi",
                "Güncelleme Bilgisi", MessageBoxButtons.OK);
        }
    }
}
