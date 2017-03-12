namespace UBAHBANK.Formlar
{
    partial class frmAnlasmalibank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnlasmalibank));
            this.btnBireyselkredi = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnamenu = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnBireyselkredi
            // 
            this.btnBireyselkredi.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnBireyselkredi.Appearance.Options.UseFont = true;
            this.btnBireyselkredi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnBireyselkredi.Location = new System.Drawing.Point(80, 207);
            this.btnBireyselkredi.Name = "btnBireyselkredi";
            this.btnBireyselkredi.Size = new System.Drawing.Size(193, 29);
            this.btnBireyselkredi.TabIndex = 5;
            this.btnBireyselkredi.Text = "Bireysel Kredi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "LÜTFEN İŞLEMİNİZİ SEÇİNİZ";
            // 
            // btnAnamenu
            // 
            this.btnAnamenu.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnAnamenu.Appearance.Options.UseFont = true;
            this.btnAnamenu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAnamenu.Location = new System.Drawing.Point(80, 370);
            this.btnAnamenu.Name = "btnAnamenu";
            this.btnAnamenu.Size = new System.Drawing.Size(193, 29);
            this.btnAnamenu.TabIndex = 5;
            this.btnAnamenu.Text = "Ana Menü";
            // 
            // frmAnlasmalibank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UBAHBANK.Properties.Resources.ubah_background;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnamenu);
            this.Controls.Add(this.btnBireyselkredi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnlasmalibank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anlaşmalı Banka İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBireyselkredi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnAnamenu;
    }
}