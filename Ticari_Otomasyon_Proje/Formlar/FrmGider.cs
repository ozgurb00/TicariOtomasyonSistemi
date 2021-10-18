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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblGiderler t = new TblGiderler();
            t.Tutar = decimal.Parse(TxtTutar.Text);
            t.Aciklama = TxtAciklama.Text;
            t.Tarih = DateTime.Parse(TxtTarih.Text);
            db.TblGiderler.Add(t);
            db.SaveChanges();

            TblKasa t2 = new TblKasa();
            t2.Tutar = decimal.Parse(TxtTutar.Text);
            t2.Aciklama = TxtAciklama.Text;
            t2.Tarih = DateTime.Parse(TxtTarih.Text);
            t2.Tur = "Çıkış";
            db.SaveChanges();

            XtraMessageBox.Show("Gider sisteme başarılı bir şekilde eklendi",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
