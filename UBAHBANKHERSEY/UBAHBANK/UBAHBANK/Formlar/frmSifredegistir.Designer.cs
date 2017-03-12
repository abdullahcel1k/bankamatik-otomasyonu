namespace UBAHBANK.Formlar
{
    partial class frmSifredegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifredegistir));
            this.label3 = new System.Windows.Forms.Label();
            this.txtYenisifretekrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYenisifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEskisifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "LÜTFEN BİLGİLERİ GİRİNİZ";
            // 
            // txtYenisifretekrar
            // 
            this.txtYenisifretekrar.Location = new System.Drawing.Point(352, 305);
            this.txtYenisifretekrar.Name = "txtYenisifretekrar";
            this.txtYenisifretekrar.PasswordChar = '*';
            this.txtYenisifretekrar.Size = new System.Drawing.Size(100, 20);
            this.txtYenisifretekrar.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(211, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yeni Şifre Tekrar :";
            // 
            // txtYenisifre
            // 
            this.txtYenisifre.Location = new System.Drawing.Point(352, 267);
            this.txtYenisifre.Name = "txtYenisifre";
            this.txtYenisifre.PasswordChar = '*';
            this.txtYenisifre.Size = new System.Drawing.Size(100, 20);
            this.txtYenisifre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(260, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Şifre :";
            // 
            // txtEskisifre
            // 
            this.txtEskisifre.Location = new System.Drawing.Point(352, 224);
            this.txtEskisifre.Name = "txtEskisifre";
            this.txtEskisifre.PasswordChar = '*';
            this.txtEskisifre.Size = new System.Drawing.Size(100, 20);
            this.txtEskisifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eski Şifre :";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOnayla.Appearance.Options.UseFont = true;
            this.btnOnayla.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnOnayla.Location = new System.Drawing.Point(609, 362);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // frmSifredegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UBAHBANK.Properties.Resources.ubah_background;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYenisifretekrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYenisifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEskisifre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSifredegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYenisifretekrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYenisifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEskisifre;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
    }
}