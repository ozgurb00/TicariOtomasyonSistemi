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
    public partial class FrmYeniSatis : Form
    {
        public FrmYeniSatis()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void FrmYeniSatis_Load(object sender, EventArgs e)
        {
            LookUpUrun.Properties.DataSource = (from x in db.TblUrun
                                                select new
                                                {
                                                    x.UrunId,
                                                    x.UrunAd
                                                }).ToList();

            LookUpPersonel.Properties.DataSource = (from x in db.TblPersonel
                                                    select new
                                                    {
                                                        x.PersonelId,
                                                        PERSONEL = x.PersonelAd + " " + x.PersonelSoyad
                                                    }).ToList();

            LookUpCari.Properties.DataSource = (from x in db.TblCari
                                                select new
                                                {
                                                    x.CariId,
                                                    CARI = x.Ad + " " + x.Soyad
                                                }).ToList();
        }

        private void LookUpUrun_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(LookUpUrun.EditValue.ToString());
            var birimfiyat = db.TblUrun.Where(x => x.UrunId == secilen).Select(y =>
            y.SatisFiyat).FirstOrDefault();
            TxtBirimFiyat.Text = birimfiyat.ToString();
        }

        private void TxtAdet_EditValueChanged(object sender, EventArgs e)
        {
            int adet = int.Parse(TxtAdet.Text);
            double birimfiyat = double.Parse(TxtBirimFiyat.Text);
            double toplam = adet * birimfiyat;
            TxtToplamFiyat.Text = toplam.ToString();
        }

        private void BtnSatışYap_Click(object sender, EventArgs e)
        {
            TblCariHareket t = new TblCariHareket();
            t.Urun = int.Parse(LookUpUrun.EditValue.ToString());
            t.Personel = int.Parse(LookUpPersonel.EditValue.ToString());
            t.Cari = int.Parse(LookUpCari.EditValue.ToString());
            t.Tarih = DateTime.Parse(DateEditTarih.Text);
            t.Adet = short.Parse(TxtAdet.Text);
            t.BirimFiyat = decimal.Parse(TxtBirimFiyat.Text);
            t.Toplam = decimal.Parse(TxtToplamFiyat.Text);
            t.Aciklama = MemoEditAciklama.Text;
            XtraMessageBox.Show("Mesaj", "Cari Satış İşlemi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
