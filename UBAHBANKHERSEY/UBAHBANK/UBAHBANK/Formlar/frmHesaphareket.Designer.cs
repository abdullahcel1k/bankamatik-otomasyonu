namespace UBAHBANK.Formlar
{
    partial class frmHesaphareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHesaphareket));
            this.label2 = new System.Windows.Forms.Label();
            this.btnKartiade = new DevExpress.XtraEditors.SimpleButton();
            this.btnMakbuz = new DevExpress.XtraEditors.SimpleButton();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "HESAP HAREKETLERİ";
            // 
            // btnKartiade
            // 
            this.btnKartiade.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnKartiade.Appearance.Options.UseFont = true;
            this.btnKartiade.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnKartiade.Location = new System.Drawing.Point(43, 376);
            this.btnKartiade.Name = "btnKartiade";
            this.btnKartiade.Size = new System.Drawing.Size(75, 23);
            this.btnKartiade.TabIndex = 7;
            this.btnKartiade.Text = "Kart İade";
            // 
            // btnMakbuz
            // 
            this.btnMakbuz.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnMakbuz.Appearance.Options.UseFont = true;
            this.btnMakbuz.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnMakbuz.Location = new System.Drawing.Point(620, 376);
            this.btnMakbuz.Name = "btnMakbuz";
            this.btnMakbuz.Size = new System.Drawing.Size(75, 23);
            this.btnMakbuz.TabIndex = 7;
            this.btnMakbuz.Text = "Makbuz";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(12, 176);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(710, 194);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TARİH";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AÇIKLAMA";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TUTAR";
            // 
            // frmHesaphareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UBAHBANK.Properties.Resources.ubah_background;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnMakbuz);
            this.Controls.Add(this.btnKartiade);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHesaphareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Hareketleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnKartiade;
        private DevExpress.XtraEditors.SimpleButton btnMakbuz;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}