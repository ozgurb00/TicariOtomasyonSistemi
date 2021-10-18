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
    public partial class Istatistikler : Form
    {
        public Istatistikler()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void Istatistikler_Load(object sender, EventArgs e)
        {
            LblUrunSayisi.Text = db.TblUrun.Count().ToString();
            LblKategoriSayisi.Text = db.TblKategori.Count().ToString();
            LblMusteriSayisi.Text = db.TblCari.Count().ToString();
            LblPersonelSayisi.Text = db.TblPersonel.Count().ToString();
            LblToplamStok.Text = db.TblUrun.Sum(x => x.Stok).ToString();
            LblToplamBeyazEsya.Text = db.TblUrun.Where(x => x.Kategori == 1).Sum(y => y.Stok).ToString();
            LblKucukEvAleti.Text = db.TblUrun.Where(x => x.Kategori == 4).Sum(y => y.Stok).ToString();
            LblKritikSeviye.Text = db.TblUrun.Count(x => x.KritikSeviye == true).ToString();
            LblEnYuksekFiyatlıUrun.Text = db.TblUrun.OrderByDescending(x => x.SatisFiyat).Select(y => y.UrunAd)
                .FirstOrDefault().ToString();
            LblEnDusukFiyatliUrun.Text = db.TblUrun.OrderBy(x => x.SatisFiyat).Select(y => y.UrunAd).FirstOrDefault()
                .ToString();
            LblEnYuksekStokUrun.Text = db.TblUrun.OrderByDescending(x => x.Stok).Select(y => y.UrunAd).FirstOrDefault()
                .ToString();
            LblEnDusukStokUrun.Text = db.TblUrun.OrderBy(x => x.Stok).Select(y => y.UrunAd)
                .FirstOrDefault().ToString();
        }
    }
}
