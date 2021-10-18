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
    public partial class FrmCariHareket : Form
    {
        public FrmCariHareket()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblCariHareket
                                       select new
                                       {
                                           x.SatisId,
                                           x.TblUrun.UrunAd,
                                           Cari = x.TblCari.Ad + x.TblCari.Soyad,
                                           Personel = x.TblPersonel.PersonelAd + x.TblPersonel.PersonelSoyad,
                                           x.Tarih,
                                           x.BirimFiyat,
                                           x.Adet,
                                           x.Toplam
                                       }).ToList();

            LblToplamSatis.Text = db.TblCariHareket.Count().ToString();
            DateTime bugun = new DateTime();
            LblBugunSatis.Text = db.TblCariHareket.Where(x => x.Tarih == bugun).Count().ToString();
            var deger = db.TblCariHareket.GroupBy(x => x.Urun).OrderByDescending(z =>
            z.Count()).Select(y => y.Key).FirstOrDefault();
            LblEnFazlaSatilanUrun.Text = db.TblUrun.Where(x => x.UrunId == deger).Select(
                y => y.UrunAd).FirstOrDefault().ToString();
            var deger2 = db.TblCariHareket.GroupBy(x => x.Cari).OrderByDescending(z
                => z.Count()).Select(y => y.Key).FirstOrDefault();
            LblEnFazlaAlimCari.Text = db.TblCari.Where(x => x.CariId == deger2).Select(y =>
            y.Ad + " " + y.Soyad).FirstOrDefault().ToString();
        }
    }
}
