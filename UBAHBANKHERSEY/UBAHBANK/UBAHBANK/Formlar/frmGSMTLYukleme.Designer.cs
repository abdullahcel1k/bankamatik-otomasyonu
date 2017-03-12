namespace UBAHBANK.Formlar
{
    partial class frmGSMTLYukleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGSMTLYukleme));
            this.btnTurkcel = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTurktelekom = new DevExpress.XtraEditors.SimpleButton();
            this.btnVodafone = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnamenu = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnTurkcel
            // 
            this.btnTurkcel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTurkcel.Appearance.Options.UseFont = true;
            this.btnTurkcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTurkcel.Location = new System.Drawing.Point(89, 234);
            this.btnTurkcel.Name = "btnTurkcel";
            this.btnTurkcel.Size = new System.Drawing.Size(193, 29);
            this.btnTurkcel.TabIndex = 0;
            this.btnTurkcel.Text = "Türkcell";
            this.btnTurkcel.Click += new System.EventHandler(this.btnTurkcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(198, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "LÜTFEN OPARATÖRÜ SEÇİNİZ";
            // 
            // btnTurktelekom
            // 
            this.btnTurktelekom.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTurktelekom.Appearance.Options.UseFont = true;
            this.btnTurktelekom.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTurktelekom.Location = new System.Drawing.Point(429, 234);
            this.btnTurktelekom.Name = "btnTurktelekom";
            this.btnTurktelekom.Size = new System.Drawing.Size(193, 29);
            this.btnTurktelekom.TabIndex = 0;
            this.btnTurktelekom.Text = "Türk Telekom";
            this.btnTurktelekom.Click += new System.EventHandler(this.btnTurktelekom_Click);
            // 
            // btnVodafone
            // 
            this.btnVodafone.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnVodafone.Appearance.Options.UseFont = true;
            this.btnVodafone.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnVodafone.Location = new System.Drawing.Point(89, 291);
            this.btnVodafone.Name = "btnVodafone";
            this.btnVodafone.Size = new System.Drawing.Size(193, 29);
            this.btnVodafone.TabIndex = 0;
            this.btnVodafone.Text = "Vodafone";
            this.btnVodafone.Click += new System.EventHandler(this.btnVodafone_Click);
            // 
            // btnAnamenu
            // 
            this.btnAnamenu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAnamenu.Appearance.Options.UseFont = true;
            this.btnAnamenu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAnamenu.Location = new System.Drawing.Point(429, 291);
            this.btnAnamenu.Name = "btnAnamenu";
            this.btnAnamenu.Size = new System.Drawing.Size(193, 29);
            this.btnAnamenu.TabIndex = 0;
            this.btnAnamenu.Text = "Ana Menü";
            this.btnAnamenu.Click += new System.EventHandler(this.btnAnamenu_Click);
            // 
            // frmGSMTLYukleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UBAHBANK.Properties.Resources.ubah_background;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTurktelekom);
            this.Controls.Add(this.btnAnamenu);
            this.Controls.Add(this.btnVodafone);
            this.Controls.Add(this.btnTurkcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGSMTLYukleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSM TL Yükleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTurkcel;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnTurktelekom;
        private DevExpress.XtraEditors.SimpleButton btnVodafone;
        private DevExpress.XtraEditors.SimpleButton btnAnamenu;
    }
}