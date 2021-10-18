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
    public partial class FrmCariIstatistik : Form
    {
        public FrmCariIstatistik()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void FrmCariIstatistik_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TblCari.OrderBy(x => x.Il).
                GroupBy(y => y.Il).Select(z => new { IL = z.Key, TOPLAM = z.Count() }).ToList();
            var degerler = db.TblCari.OrderBy(x => x.Il).GroupBy(y => y.Il).Select(z =>
            new { IL = z.Key, TOPLAM = z.Count() }).ToList();
            foreach(var x in degerler)
            {
                chartControl1.Series["Iller"].Points.AddPoint(x.IL, short.Parse(x.TOPLAM.ToString()));
            }
        }
    }
}
