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
    public partial class FrmCariKart : Form
    {
        public FrmCariKart()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void FrmCariKart_Load(object sender, EventArgs e)
        {
            LookUpEditIl.Properties.DataSource = (from x in db.TblIller
                                                  select new
                                                  {
                                                      x.Id,
                                                      x.Sehir
                                                  }).ToList();
        }

        private void LookUpEditIl_Properties_EditValueChanged(object sender, EventArgs e)
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
    }
}
