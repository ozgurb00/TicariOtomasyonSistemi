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
    public partial class FrmKategorilerİstatistik : Form
    {
        public FrmKategorilerİstatistik()
        {
            InitializeComponent();
        }

        private void FrmKategorilerİstatistik_Load(object sender, EventArgs e)
        {
            DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
            gridControl1.DataSource = (from x in db.TblKategori
                                       select new
                                       {
                                           x.KategoriID,
                                           x.KategoriAd
                                       }).ToList();
            LblKategoriSayisi.Text = db.TblKategori.Count().ToString();
            LblSonEklenenKategori.Text = db.TblKategori.OrderByDescending(x => x.KategoriID)
                .Select(y => y.KategoriAd).FirstOrDefault().ToString();
            var deger = db.TblUrun.GroupBy(x => x.Kategori).OrderByDescending(z => z.Count()).
                Select(y => y.Key).FirstOrDefault();
            LblEnFazlaUrunKategori.Text = db.TblKategori.Where(x => x.KategoriID == deger)
                .Select(y => y.KategoriAd).FirstOrDefault().ToString();
            var degerler = db.TblUrun.ToList();
            foreach(var x in degerler)
            {
                chartControl1.Series["urun-stok"].Points.AddPoint(x.UrunAd,
                    short.Parse(x.Stok.ToString()));
            }
        }
    }
}
