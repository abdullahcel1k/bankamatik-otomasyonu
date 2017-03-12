namespace UBAHBANK.Formlar
{
    partial class frmBakiye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBakiye));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEvet = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHayır = new DevExpress.XtraEditors.SimpleButton();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblHesapno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "BİLGİLERİ KONTROL EDİNİZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(271, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bakiye :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hesap No :";
            // 
            // btnEvet
            // 
            this.btnEvet.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnEvet.Appearance.Options.UseFont = true;
            this.btnEvet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEvet.Location = new System.Drawing.Point(93, 361);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(193, 29);
            this.btnEvet.TabIndex = 9;
            this.btnEvet.Text = "Evet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(201, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "MAKBUZ ALMAK İSTERMİSİNİZ?";
            // 
            // btnHayır
            // 
            this.btnHayır.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHayır.Appearance.Options.UseFont = true;
            this.btnHayır.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnHayır.Location = new System.Drawing.Point(448, 361);
            this.btnHayır.Name = "btnHayır";
            this.btnHayır.Size = new System.Drawing.Size(193, 29);
            this.btnHayır.TabIndex = 9;
            this.btnHayır.Text = "Hayır";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.BackColor = System.Drawing.Color.Transparent;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBakiye.ForeColor = System.Drawing.Color.White;
            this.lblBakiye.Location = new System.Drawing.Point(341, 236);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(35, 20);
            this.lblBakiye.TabIndex = 11;
            this.lblBakiye.Text = "N/A";
            // 
            // lblHesapno
            // 
            this.lblHesapno.AutoSize = true;
            this.lblHesapno.BackColor = System.Drawing.Color.Transparent;
            this.lblHesapno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHesapno.ForeColor = System.Drawing.Color.White;
            this.lblHesapno.Location = new System.Drawing.Point(341, 207);
            this.lblHesapno.Name = "lblHesapno";
            this.lblHesapno.Size = new System.Drawing.Size(35, 20);
            this.lblHesapno.TabIndex = 12;
            this.lblHesapno.Text = "N/A";
            // 
            // frmBakiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UBAHBANK.Properties.Resources.ubah_background;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.lblHesapno);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHayır);
            this.Controls.Add(this.btnEvet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBakiye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakiye Sorgulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnEvet;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnHayır;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblHesapno;
    }
}