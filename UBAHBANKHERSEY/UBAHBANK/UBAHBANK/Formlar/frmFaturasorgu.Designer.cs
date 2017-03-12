namespace UBAHBANK.Formlar
{
    partial class frmFaturasorgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaturasorgu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusterino = new System.Windows.Forms.TextBox();
            this.btnDevam = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "BİLGİLERİ DOLDURUN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(238, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Müşteri No :";
            // 
            // txtMusterino
            // 
            this.txtMusterino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtMusterino.Location = new System.Drawing.Point(355, 221);
            this.txtMusterino.Name = "txtMusterino";
            this.txtMusterino.Size = new System.Drawing.Size(100, 24);
            this.txtMusterino.TabIndex = 10;
            // 
            // btnDevam
            // 
            this.btnDevam.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDevam.Appearance.Options.UseFont = true;
            this.btnDevam.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDevam.Location = new System.Drawing.Point(583, 361);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(78, 23);
            this.btnDevam.TabIndex = 11;
            this.btnDevam.Text = "Devam";
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // frmFaturasorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UBAHBANK.Properties.Resources.ubah_background;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.txtMusterino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFaturasorgu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Sorgu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusterino;
        private DevExpress.XtraEditors.SimpleButton btnDevam;
    }
}