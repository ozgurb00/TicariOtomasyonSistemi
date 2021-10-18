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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void BtnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblCari
                                       select new
                                       {
                                           x.CariId,
                                           x.Ad,
                                           x.Soyad,
                                           x.Il,
                                           x.Ilce,
                                           x.Adres,
                                           x.Mail,
                                           x.Tc,
                                           x.Telefon,
                                           x.VergiDairesi
                                       }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblCari t = new TblCari();
            t.Ad = TxtAd.Text;
            t.Soyad = TxtSoyad.Text;
            t.Il = LookUpEditIl.Text;
            t.Ilce = LookUpEditIlce.Text;
            t.Telefon = TxtTelefon.Text;
            t.Adres = TxtAdres.Text;
            t.Mail = TxtMail.Text;
            t.Tc = TxtTC.Text;
            t.VergiDairesi = TxtVergiDairesi.Text;
            db.TblCari.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Cari sisteme başarılı bir şekilde eklendi",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            LookUpEditIl.Properties.DataSource = (from x in db.TblIller
                                                  select new
                                                  {
                                                      x.Id,
                                                      x.Sehir
                                                  }).ToList();
        }

        private void LookUpEditIl_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(LookUpEditIl.EditValue.ToString());
            LookUpEditIlce.Properties.DataSource = (from y in db.TblIlceler
                                                    select new
                                                    {
                                                        y.Id,
                                                        y.Ilce,
                                                        y.Sehir
                                                    }).Where(z => z.Sehir == secilen).ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtCariID.Text = gridView1.GetFocusedRowCellValue("CariId").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            TxtTC.Text = gridView1.GetFocusedRowCellValue("Tc").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            TxtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VergiDairesi").ToString();
            LookUpEditIl.Text = gridView1.GetFocusedRowCellValue("Il").ToString();
            LookUpEditIlce.Text = gridView1.GetFocusedRowCellValue("Ilce").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if(TxtCariID.Text != "")
            {
                int id = int.Parse(TxtCariID.Text);
                var x = db.TblCari.Find(id);
                db.TblCari.Remove(x);
                XtraMessageBox.Show("Cari başarılı bir şekilde silindi",
                    "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                XtraMessageBox.Show("Lütfen verileri listeledikten sonra bir satıra " +
                    "tıklayıp silmek istediğiniz kaydı seçiniz",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtCariID.Text);
            var x = db.TblCari.Find(id);
            x.Ad = TxtAd.Text;
            x.Soyad = TxtSoyad.Text;
            x.Il = LookUpEditIl.Text;
            x.Ilce = LookUpEditIlce.Text;
            x.Telefon = TxtTelefon.Text;
            x.Adres = TxtAdres.Text;
            x.Tc = TxtTC.Text;
            x.VergiDairesi = TxtVergiDairesi.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Güncellendi", "Güncelleme Bilgisi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnYeniSayfaCariListe_Click(object sender, EventArgs e)
        {
            FrmCariFormListesi fr = new FrmCariFormListesi();
            fr.Show();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblCari
                                       select new
                                       {
                                           x.CariId,
                                           x.Ad,
                                           x.Soyad,
                                           x.Il,
                                           x.Ilce,
                                           x.Adres,
                                           x.Mail,
                                           x.Tc,
                                           x.Telefon,
                                           x.VergiDairesi
                                       }).Where(x => x.Ad == TxtAd.Text ||
                                       x.Il == LookUpEditIl.Text).ToList();
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
