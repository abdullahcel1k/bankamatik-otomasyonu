namespace UBAHBANK.Formlar
{
    partial class frmFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFatura));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTelekom = new DevExpress.XtraEditors.SimpleButton();
            this.btnElektrik = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnamenu = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "LÜTFEN İŞLEMİNİZİ SEÇİNİZ";
            // 
            // btnTelekom
            // 
            this.btnTelekom.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnTelekom.Appearance.Options.UseFont = true;
            this.btnTelekom.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTelekom.Location = new System.Drawing.Point(100, 207);
            this.btnTelekom.Name = "btnTelekom";
            this.btnTelekom.Size = new System.Drawing.Size(193, 29);
            this.btnTelekom.TabIndex = 7;
            this.btnTelekom.Text = "Türk Telekom";
            this.btnTelekom.Click += new System.EventHandler(this.btnTelekom_Click);
            // 
            // btnElektrik
            // 
            this.btnElektrik.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnElektrik.Appearance.Options.UseFont = true;
            this.btnElektrik.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnElektrik.Location = new System.Drawing.Point(448, 207);
            this.btnElektrik.Name = "btnElektrik";
            this.btnElektrik.Size = new System.Drawing.Size(193, 29);
            this.btnElektrik.TabIndex = 7;
            this.btnElektrik.Text = "Elektrik";
            this.btnElektrik.Click += new System.EventHandler(this.btnElektrik_Click);
            // 
            // btnAnamenu
            // 
            this.btnAnamenu.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnAnamenu.Appearance.Options.UseFont = true;
            this.btnAnamenu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAnamenu.Location = new System.Drawing.Point(448, 345);
            this.btnAnamenu.Name = "btnAnamenu";
            this.btnAnamenu.Size = new System.Drawing.Size(193, 29);
            this.btnAnamenu.TabIndex = 7;
            this.btnAnamenu.Text = "Ana Menü";
            this.btnAnamenu.Click += new System.EventHandler(this.btnAnamenu_Click);
            // 
            // frmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UBAHBANK.Properties.Resources.ubah_background;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.btnAnamenu);
            this.Controls.Add(this.btnElektrik);
            this.Controls.Add(this.btnTelekom);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Ödeme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnTelekom;
        private DevExpress.XtraEditors.SimpleButton btnElektrik;
        private DevExpress.XtraEditors.SimpleButton btnAnamenu;
    }
}