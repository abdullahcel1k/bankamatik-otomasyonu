namespace UBAHBANK.Formlar
{
    partial class frmParacekdiger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParacekdiger));
            this.lblBakiye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDigerparacek = new DevExpress.XtraEditors.SimpleButton();
            this.txtParamiktar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.BackColor = System.Drawing.Color.Transparent;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblBakiye.ForeColor = System.Drawing.Color.White;
            this.lblBakiye.Location = new System.Drawing.Point(370, 230);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(53, 29);
            this.lblBakiye.TabIndex = 3;
            this.lblBakiye.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "BAKİYE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(192, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "LÜTFEN TUTARI BELİRTİNİZ";
            // 
            // btnDigerparacek
            // 
            this.btnDigerparacek.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDigerparacek.Appearance.Options.UseFont = true;
            this.btnDigerparacek.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDigerparacek.Location = new System.Drawing.Point(375, 335);
            this.btnDigerparacek.Name = "btnDigerparacek";
            this.btnDigerparacek.Size = new System.Drawing.Size(82, 29);
            this.btnDigerparacek.TabIndex = 6;
            this.btnDigerparacek.Text = "ONAYLA";
            this.btnDigerparacek.Click += new System.EventHandler(this.btnDigerparacek_Click);
            // 
            // txtParamiktar
            // 
            this.txtParamiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtParamiktar.Location = new System.Drawing.Point(375, 291);
            this.txtParamiktar.Name = "txtParamiktar";
            this.txtParamiktar.Size = new System.Drawing.Size(82, 24);
            this.txtParamiktar.TabIndex = 7;
            // 
            // frmParacekdiger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UBAHBANK.Properties.Resources.ubah_background;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.txtParamiktar);
            this.Controls.Add(this.btnDigerparacek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParacekdiger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PARA ÇEK";
            this.Load += new System.EventHandler(this.frmParacekdiger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnDigerparacek;
        private System.Windows.Forms.TextBox txtParamiktar;
    }
}