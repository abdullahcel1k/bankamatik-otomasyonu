namespace UBAHBANK.Formlar
{
    partial class frmTLyukle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTLyukle));
            this.comboxTLmiktar = new System.Windows.Forms.ComboBox();
            this.txtTelefonno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // comboxTLmiktar
            // 
            this.comboxTLmiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboxTLmiktar.FormattingEnabled = true;
            this.comboxTLmiktar.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30",
            "35",
            "50"});
            this.comboxTLmiktar.Location = new System.Drawing.Point(389, 218);
            this.comboxTLmiktar.Name = "comboxTLmiktar";
            this.comboxTLmiktar.Size = new System.Drawing.Size(121, 24);
            this.comboxTLmiktar.TabIndex = 0;
            // 
            // txtTelefonno
            // 
            this.txtTelefonno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTelefonno.Location = new System.Drawing.Point(389, 267);
            this.txtTelefonno.Name = "txtTelefonno";
            this.txtTelefonno.Size = new System.Drawing.Size(121, 23);
            this.txtTelefonno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(289, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefon No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(236, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yüklenecek Miktar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(216, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "LÜTFEN BİLGİLERİ GİRİNİZ";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOnayla.Appearance.Options.UseFont = true;
            this.btnOnayla.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnOnayla.Location = new System.Drawing.Point(614, 359);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 11;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // frmTLyukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UBAHBANK.Properties.Resources.ubah_background;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefonno);
            this.Controls.Add(this.comboxTLmiktar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTLyukle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TL Yükle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxTLmiktar;
        private System.Windows.Forms.TextBox txtTelefonno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
    }
}