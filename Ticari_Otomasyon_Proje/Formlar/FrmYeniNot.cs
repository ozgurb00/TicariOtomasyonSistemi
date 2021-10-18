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
    public partial class FrmYeniNot : Form
    {
        public FrmYeniNot()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblNotlar t = new TblNotlar();
            t.Baslik = TxtBaslik.Text;
            t.Tarih = DateTime.Parse(TxtTarih.Text);
            t.Saat = TimeSpan.Parse(TxtSaat.Text);
            db.TblNotlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Not bilgisi sisteme kaydedildi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
