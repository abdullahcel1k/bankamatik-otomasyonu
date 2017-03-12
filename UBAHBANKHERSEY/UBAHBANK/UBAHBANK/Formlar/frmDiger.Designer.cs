namespace UBAHBANK.Formlar
{
    partial class frmDiger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiger));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSifredegis = new DevExpress.XtraEditors.SimpleButton();
            this.btnTelefonupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnamenu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "LÜTFEN İŞLEMİNİZİ SEÇİNİZ";
            // 
            // btnSifredegis
            // 
            this.btnSifredegis.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnSifredegis.Appearance.Options.UseFont = true;
            this.btnSifredegis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSifredegis.Location = new System.Drawing.Point(84, 268);
            this.btnSifredegis.Name = "btnSifredegis";
            this.btnSifredegis.Size = new System.Drawing.Size(193, 29);
            this.btnSifredegis.TabIndex = 3;
            this.btnSifredegis.Text = "Şifre Değiştir";
            this.btnSifredegis.Click += new System.EventHandler(this.btnSifredegis_Click);
            // 
            // btnTelefonupdate
            // 
            this.btnTelefonupdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnTelefonupdate.Appearance.Options.UseFont = true;
            this.btnTelefonupdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTelefonupdate.Location = new System.Drawing.Point(453, 219);
            this.btnTelefonupdate.Name = "btnTelefonupdate";
            this.btnTelefonupdate.Size = new System.Drawing.Size(193, 29);
            this.btnTelefonupdate.TabIndex = 3;
            this.btnTelefonupdate.Text = "Telefon Güncelle";
            this.btnTelefonupdate.Click += new System.EventHandler(this.btnTelefonupdate_Click);
            // 
            // btnAnamenu
            // 
            this.btnAnamenu.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnAnamenu.Appearance.Options.UseFont = true;
            this.btnAnamenu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAnamenu.Location = new System.Drawing.Point(84, 347);
            this.btnAnamenu.Name = "btnAnamenu";
            this.btnAnamenu.Size = new System.Drawing.Size(193, 29);
            this.btnAnamenu.TabIndex = 3;
            this.btnAnamenu.Text = "Ana Menü";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.Location = new System.Drawing.Point(453, 268);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(193, 29);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Banka Bilgilerini Görüntüle";
            // 
            // frmDiger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UBAHBANK.Properties.Resources.ubah_background;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.btnTelefonupdate);
            this.Controls.Add(this.btnAnamenu);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnSifredegis);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDiger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diğer Kart İşlemleri";
            this.Load += new System.EventHandler(this.frmDiger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSifredegis;
        private DevExpress.XtraEditors.SimpleButton btnTelefonupdate;
        private DevExpress.XtraEditors.SimpleButton btnAnamenu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}