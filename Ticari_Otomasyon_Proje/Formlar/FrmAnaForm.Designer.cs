
namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmAnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrdUrunStok = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdSonBesSatis = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdPersoneller = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdBugunYapilacaklar = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.WbKurlar = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUrunStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSonBesSatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdBugunYapilacaklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdUrunStok
            // 
            this.GrdUrunStok.Location = new System.Drawing.Point(1, 0);
            this.GrdUrunStok.MainView = this.gridView1;
            this.GrdUrunStok.Name = "GrdUrunStok";
            this.GrdUrunStok.Size = new System.Drawing.Size(280, 187);
            this.GrdUrunStok.TabIndex = 0;
            this.GrdUrunStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdUrunStok;
            this.gridView1.Name = "gridView1";
            // 
            // GrdSonBesSatis
            // 
            this.GrdSonBesSatis.Location = new System.Drawing.Point(1, 193);
            this.GrdSonBesSatis.MainView = this.gridView2;
            this.GrdSonBesSatis.Name = "GrdSonBesSatis";
            this.GrdSonBesSatis.Size = new System.Drawing.Size(280, 187);
            this.GrdSonBesSatis.TabIndex = 1;
            this.GrdSonBesSatis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.GrdSonBesSatis;
            this.gridView2.Name = "gridView2";
            // 
            // GrdPersoneller
            // 
            this.GrdPersoneller.Location = new System.Drawing.Point(287, 193);
            this.GrdPersoneller.MainView = this.gridView3;
            this.GrdPersoneller.Name = "GrdPersoneller";
            this.GrdPersoneller.Size = new System.Drawing.Size(280, 187);
            this.GrdPersoneller.TabIndex = 3;
            this.GrdPersoneller.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.GrdPersoneller;
            this.gridView3.Name = "gridView3";
            // 
            // GrdBugunYapilacaklar
            // 
            this.GrdBugunYapilacaklar.Location = new System.Drawing.Point(287, 0);
            this.GrdBugunYapilacaklar.MainView = this.gridView4;
            this.GrdBugunYapilacaklar.Name = "GrdBugunYapilacaklar";
            this.GrdBugunYapilacaklar.Size = new System.Drawing.Size(280, 187);
            this.GrdBugunYapilacaklar.TabIndex = 2;
            this.GrdBugunYapilacaklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.GrdBugunYapilacaklar;
            this.gridView4.Name = "gridView4";
            // 
            // WbKurlar
            // 
            this.WbKurlar.Location = new System.Drawing.Point(582, 0);
            this.WbKurlar.MinimumSize = new System.Drawing.Size(20, 20);
            this.WbKurlar.Name = "WbKurlar";
            this.WbKurlar.Size = new System.Drawing.Size(290, 380);
            this.WbKurlar.TabIndex = 4;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 373);
            this.Controls.Add(this.WbKurlar);
            this.Controls.Add(this.GrdPersoneller);
            this.Controls.Add(this.GrdBugunYapilacaklar);
            this.Controls.Add(this.GrdSonBesSatis);
            this.Controls.Add(this.GrdUrunStok);
            this.Name = "FrmAnaForm";
            this.Text = "FrmAnaForm";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdUrunStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSonBesSatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdBugunYapilacaklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdUrunStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl GrdSonBesSatis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl GrdPersoneller;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl GrdBugunYapilacaklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.WebBrowser WbKurlar;
    }
}