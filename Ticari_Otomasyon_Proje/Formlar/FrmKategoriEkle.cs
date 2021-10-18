﻿using DevExpress.XtraEditors;
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
    public partial class FrmKategoriEkle : Form
    {
        public FrmKategoriEkle()
        {
            InitializeComponent();
        }

        private void FrmKategoriEkle_Load(object sender, EventArgs e)
        {

        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TblKategori t = new TblKategori();
                t.KategoriAd = TxtKategoriAd.Text;
                db.TblKategori.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Kategori Ekleme İşlemi Başarılı Bir Şekilde " +
                    "Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                XtraMessageBox.Show("Hata, lütfen kategori adını boş bırakmayınız veya " +
                    "20 karakterden uzun kategori adı girişi yapmayınız", "Uyarı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
