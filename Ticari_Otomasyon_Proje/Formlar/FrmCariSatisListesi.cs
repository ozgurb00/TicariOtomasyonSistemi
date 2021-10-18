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
    public partial class FrmCariSatisListesi : Form
    {
        public FrmCariSatisListesi()
        {
            InitializeComponent();
        }


        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmCariSatisListesi_Load(object sender, EventArgs e)
        {
            var satis_listesi = from x in db.TblCariHareket
                                select new
                                {
                                    x.SatisId,
                                    x.TblUrun,
                                    x.Adet,
                                    x.BirimFiyat,
                                    x.Toplam,
                                    Cari = x.TblCari.Ad + " " + x.TblCari.Soyad,
                                    Personel = x.TblPersonel.PersonelAd + " " + x.TblPersonel.PersonelSoyad,
                                    x.Tarih
                                };
            gridControl1.DataSource = satis_listesi.ToList();
        }
    }
}
