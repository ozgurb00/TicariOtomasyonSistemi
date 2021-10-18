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
    public partial class FrmCariFormListesi : Form
    {
        public FrmCariFormListesi()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void FrmCariFormListesi_Load(object sender, EventArgs e)
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
    }
}
