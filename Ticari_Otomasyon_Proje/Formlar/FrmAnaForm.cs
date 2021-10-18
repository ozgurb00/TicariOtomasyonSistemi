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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            var urun_stok = from x in db.TblUrun
                            select new
                            {
                                x.UrunAd,
                                x.Stok
                            };
            GrdUrunStok.DataSource = urun_stok.ToList();

            var sonSatis = from x in db.TblCariHareket
                           select new
                           {
                               x.TblUrun.UrunAd,
                               x.Adet,
                               x.Toplam,
                               x.SatisId
                           };
            GrdSonBesSatis.DataSource = sonSatis.OrderByDescending(x => x.SatisId).Take(5).ToList();

            DateTime bugun = DateTime.Today;
            var bugunYapilacaklar = (from x in db.TblNotlar
                                     select new
                                     {
                                         x.Baslik,
                                         x.Saat,
                                         x.Tarih
                                     }).Where(x => x.Tarih == bugun).ToList();
            GrdBugunYapilacaklar.DataSource = bugunYapilacaklar;

            var carifihrist = (from x in db.TblCari
                               select new
                               {
                                   x.Ad,
                                   x.Soyad,
                                   x.Telefon
                               }).ToList();
            GrdPersoneller.DataSource = carifihrist;

            WbKurlar.Navigate("https://tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
        }
    }
}
