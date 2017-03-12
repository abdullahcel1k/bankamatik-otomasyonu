using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UBAHBANK.Formlar
{
    public partial class frmParacekdiger : Form
    {
        Sınıflar.VTBaglanti mysqlim = new Sınıflar.VTBaglanti();
        Sınıflar.duzenleyici duzen = new Sınıflar.duzenleyici();
        public string Kartno;
        public bool cevap;
       
        public frmParacekdiger(string kartno)
        {
            InitializeComponent();
            Kartno = kartno;
        }

        private void frmParacekdiger_Load(object sender, EventArgs e)
        {
            string sorgu = "select *from TBLHESAP where H_Kartno=" + Kartno;
            lblBakiye.Text = mysqlim.sqlSayi(sorgu, "H_Bakiye").ToString() + " TL";
        }

        private void btnDigerparacek_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from TBLHESAP where H_Kartno=" + Kartno;
            int nakit = mysqlim.sqlSayi(sorgu, "H_Bakiye");
            int kalan = nakit - Convert.ToInt32(txtParamiktar.Text);
            string komut = "update  TBLHESAP set H_Bakiye=" + kalan + " where  H_Kartno=" + Kartno;
            mysqlim.kaydet(komut);
            cevap = duzen.devamEtmek();
            if (cevap == true)
            {
                frmAnamenu frm = new frmAnamenu(Kartno);
                frm.Show();
            }
            this.Close();
        }
    }
}
