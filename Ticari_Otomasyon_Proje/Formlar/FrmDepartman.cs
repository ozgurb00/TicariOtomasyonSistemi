using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.Entity;

namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            db.TblDepartman.Load();
            bindingSource1.DataSource = db.TblDepartman.Local;
            var degerler = db.TblPersonel.OrderBy(x => x.TblDepartman.DepartmanAd).
                GroupBy(y => y.TblDepartman.DepartmanAd).
                Select(z => new { Ad = z.Key, Toplam = z.Count() }).ToList();
            foreach(var x in degerler)
            {
                chartControl1.Series["Departmanlar"].Points.AddPoint(x.Ad,
                    short.Parse(x.Toplam.ToString()));
            }
            foreach (var x in degerler)
            {
                chartControl2.Series["Departmanlar"].Points.AddPoint(x.Ad,
                    short.Parse(x.Toplam.ToString()));
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
