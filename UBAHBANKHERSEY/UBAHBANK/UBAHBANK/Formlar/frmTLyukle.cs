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
    public partial class frmTLyukle : Form
    {
        Sınıflar.VTBaglanti mysqlim = new Sınıflar.VTBaglanti();
        Sınıflar.duzenleyici duzen = new Sınıflar.duzenleyici();

        public bool cevap;
        public string Kartno;
        public frmTLyukle(string kartno)
        {
            InitializeComponent();
            Kartno = kartno;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            //sorgu1 ile kişinin telefonundaki TL miktarını öğrendik
            string sorgu1 = "select *from TBLGSM where G_No=" + txtTelefonno.Text;
            int yuklenecekTL = Convert.ToInt32(comboxTLmiktar.Text);
            int suankiTL =mysqlim.sqlSayi(sorgu1,"G_Bakiye");

            //sorgu2 ile kişinin kredi kartındaki bakiye miktarını öğrendik yuklenilecek miktarı bakiyeden eksilttim
            string sorgu2 = "select *from TBLHESAP where H_Kartno=" + Kartno;
            int nakit = mysqlim.sqlSayi(sorgu2, "H_Bakiye");
            int kalan = nakit - yuklenecekTL;
            string komut1 = "update  TBLHESAP set H_Bakiye=" + kalan + " where  H_Kartno=" + Kartno;
            mysqlim.kaydet(komut1);

            // yüklenilen miktar ve varolan miktarı toplayıp müşterinin TL miktarını güncelledim
            string komut2 = "update tblgsm set G_Bakiye="+(suankiTL+yuklenecekTL)+" where G_No="+txtTelefonno.Text;
            mysqlim.kaydet(komut2);
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
