
namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmRaporlar
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
            this.BtnPdfRapor = new DevExpress.XtraEditors.SimpleButton();
            this.BtnExcelRapor = new DevExpress.XtraEditors.SimpleButton();
            this.BtnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPdfRapor
            // 
            this.BtnPdfRapor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPdfRapor.Appearance.Options.UseFont = true;
            this.BtnPdfRapor.Location = new System.Drawing.Point(13, 22);
            this.BtnPdfRapor.Name = "BtnPdfRapor";
            this.BtnPdfRapor.Size = new System.Drawing.Size(285, 48);
            this.BtnPdfRapor.TabIndex = 0;
            this.BtnPdfRapor.Text = "PDF Raporu";
            this.BtnPdfRapor.Click += new System.EventHandler(this.BtnPdfRapor_Click);
            // 
            // BtnExcelRapor
            // 
            this.BtnExcelRapor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnExcelRapor.Appearance.Options.UseFont = true;
            this.BtnExcelRapor.Location = new System.Drawing.Point(304, 22);
            this.BtnExcelRapor.Name = "BtnExcelRapor";
            this.BtnExcelRapor.Size = new System.Drawing.Size(285, 48);
            this.BtnExcelRapor.TabIndex = 1;
            this.BtnExcelRapor.Text = "Excel Raporu";
            this.BtnExcelRapor.Click += new System.EventHandler(this.BtnExcelRapor_Click);
            // 
            // BtnIptal
            // 
            this.BtnIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIptal.Appearance.Options.UseFont = true;
            this.BtnIptal.Location = new System.Drawing.Point(595, 22);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(285, 48);
            this.BtnIptal.TabIndex = 2;
            this.BtnIptal.Text = "İptal";
            this.BtnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 92);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(888, 281);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 373);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.BtnIptal);
            this.Controls.Add(this.BtnExcelRapor);
            this.Controls.Add(this.BtnPdfRapor);
            this.Name = "FrmRaporlar";
            this.Text = "FrmRaporlar";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnPdfRapor;
        private DevExpress.XtraEditors.SimpleButton BtnExcelRapor;
        private DevExpress.XtraEditors.SimpleButton BtnIptal;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}