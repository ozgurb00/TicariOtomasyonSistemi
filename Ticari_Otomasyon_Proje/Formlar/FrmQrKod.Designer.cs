
namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmQrKod
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.BtnQrOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.BtnQrCoz = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Metni Giriniz:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(106, 13);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(193, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(12, 56);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(287, 230);
            this.pictureEdit1.TabIndex = 2;
            // 
            // BtnQrOlustur
            // 
            this.BtnQrOlustur.Location = new System.Drawing.Point(12, 307);
            this.BtnQrOlustur.Name = "BtnQrOlustur";
            this.BtnQrOlustur.Size = new System.Drawing.Size(141, 37);
            this.BtnQrOlustur.TabIndex = 3;
            this.BtnQrOlustur.Text = "QR Oluştur";
            this.BtnQrOlustur.Click += new System.EventHandler(this.BtnQrOlustur_Click);
            // 
            // BtnQrCoz
            // 
            this.BtnQrCoz.Location = new System.Drawing.Point(159, 307);
            this.BtnQrCoz.Name = "BtnQrCoz";
            this.BtnQrCoz.Size = new System.Drawing.Size(141, 37);
            this.BtnQrCoz.TabIndex = 4;
            this.BtnQrCoz.Text = "QR Çöz";
            this.BtnQrCoz.Click += new System.EventHandler(this.BtnQrCoz_Click);
            // 
            // FrmQrKod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 356);
            this.Controls.Add(this.BtnQrCoz);
            this.Controls.Add(this.BtnQrOlustur);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmQrKod";
            this.Text = "FrmQrKod";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnQrOlustur;
        private DevExpress.XtraEditors.SimpleButton BtnQrCoz;
    }
}