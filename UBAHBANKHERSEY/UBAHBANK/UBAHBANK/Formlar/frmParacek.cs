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
    public partial class frmParacek : Form
    {
        /*NOT PARA ÇEKME TEK METOT ÜZERİNDEN YÜRÜTÜLECEK*/
        Sınıflar.VTBaglanti mysqlim = new Sınıflar.VTBaglanti();
        Sınıflar.duzenleyici duzen = new Sınıflar.duzenleyici();

        public string Kartno;
        public bool cevap; //devam etme işlemi için geri gönderilen cevap
        public frmParacek(String kartno)
        {
            Kartno = kartno;
            InitializeComponent();
        }

        private void frmParacek_Load(object sender, EventArgs e)
        {
            string sorgu = "select *from TBLHESAP where H_Kartno=" + Kartno;
            lblBakiye.Text = mysqlim.sqlSayi(sorgu, "H_Bakiye").ToString()+" TL";
        }

        private void btn10TL_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from TBLHESAP where H_Kartno=" + Kartno;
            int nakit = mysqlim.sqlSayi(sorgu, "H_Bakiye");
            int kalan = nakit - 10;
            string komut = "update  TBLHESAP set H_Bakiye="+kalan+" where  H_Kartno="+Kartno;
            mysqlim.kaydet(komut);
            cevap = duzen.devamEtmek();
            if (cevap == true)
            {
                frmAnamenu frm = new frmAnamenu(Kartno);
                frm.Show();
            }
            this.Close();
        }

        private void btn20TL_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from TBLHESAP where H_Kartno=" + Kartno;
            int nakit = mysqlim.sqlSayi(sorgu, "H_Bakiye");
            int kalan = nakit - 20;
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

        private void btn50TL_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from TBLHESAP where H_Kartno=" + Kartno;
            int nakit = mysqlim.sqlSayi(sorgu, "H_Bakiye");
            int kalan = nakit - 50;
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

        private void btn100TL_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from TBLHESAP where H_Kartno=" + Kartno;
            int nakit = mysqlim.sqlSayi(sorgu, "H_Bakiye");
            int kalan = nakit - 100;
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

        private void btn200TL_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from TBLHESAP where H_Kartno=" + Kartno;
            int nakit = mysqlim.sqlSayi(sorgu, "H_Bakiye");
            int kalan = nakit - 200;
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

        private void btn300TL_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from TBLHESAP where H_Kartno=" + Kartno;
            int nakit = mysqlim.sqlSayi(sorgu, "H_Bakiye");
            int kalan = nakit - 300;
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

        private void btn400TL_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from TBLHESAP where H_Kartno=" + Kartno;
            int nakit = mysqlim.sqlSayi(sorgu, "H_Bakiye");
            int kalan = nakit - 400;
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

        private void btnDiger_Click(object sender, EventArgs e)
        {
            frmParacekdiger frm = new frmParacekdiger(Kartno);
            frm.Show();
        }
    }
}
