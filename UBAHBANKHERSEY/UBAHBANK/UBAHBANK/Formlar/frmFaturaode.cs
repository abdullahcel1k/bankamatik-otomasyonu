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
    public partial class frmFaturaode : Form
    {
        Sınıflar.VTBaglanti mysqlim = new Sınıflar.VTBaglanti();
        Sınıflar.duzenleyici duzen = new Sınıflar.duzenleyici();

        public bool cevap;
        public string Kartno;
        public string Hesapno;
        public int borc;
        public frmFaturaode(string kartno,string hesapno)
        {
            InitializeComponent();
            Kartno = kartno;
            Hesapno = hesapno;
        }

        private void btnAnamenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAnamenu frm = new frmAnamenu(Kartno);
            frm.Show();
        }

        private void frmFaturaode_Load(object sender, EventArgs e)
        { 
            string sorgu = "select * from tblfatura where M_No="+Hesapno;
            lblMusterino.Text = Hesapno.ToString();
            lblMusteriadi.Text =mysqlim.sqlKelime(sorgu,"M_Adi");
            borc = mysqlim.sqlSayi(sorgu, "M_Borc");
            lblSonfatura.Text = mysqlim.sqlSayi(sorgu,"M_Borc").ToString()+" TL";
        }

        private void btnHesaptanode_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from TBLHESAP where H_Kartno=" + Kartno;

            int nakit = mysqlim.sqlSayi(sorgu, "H_Bakiye");
            int kalan = nakit - borc;
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
