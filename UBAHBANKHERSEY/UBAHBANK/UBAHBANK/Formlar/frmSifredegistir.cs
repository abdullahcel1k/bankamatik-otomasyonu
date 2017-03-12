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
    public partial class frmSifredegistir : Form
    {
        Sınıflar.duzenleyici duzen = new Sınıflar.duzenleyici();
        Sınıflar.VTBaglanti mysqlim = new Sınıflar.VTBaglanti();
        int hata = 0;
        public string Kartno;
        public frmSifredegistir(string kartno)
        {
            InitializeComponent();
            Kartno = kartno;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            bool cevap;
            string sorgu = "select *from TBLKART where K_No=" + Kartno;
            string mevcutsifre = mysqlim.sqlKelime(sorgu,"K_Sifre");
            string yenisifre = txtYenisifre.Text;

            // HATA VAR ŞİFRE DEĞİŞMİYOR
            // şuanki VT'mızdeki şifresi ve girdiği şifrenin uyumlu olup olmadığını kontrol ettik uyumlu değilse işlem gerçekleşemez ve kişinin kartı bloke olur
            if (mevcutsifre==txtEskisifre.Text)
            {
                if (txtYenisifre.Text == txtYenisifretekrar.Text)
                {
                    string komut = "update  tblkart set K_Sifre=" + yenisifre + " where  K_No=" + Kartno;
                    mysqlim.kaydet(komut);
                    cevap = duzen.devamEtmek();
                    // başka bir işlem yapmak istiyorsa cevap true dönecek ve kullanıcı anasayfaaya yönlendirilecek
                    if (cevap == true)
                    {
                        frmAnamenu frm = new frmAnamenu(Kartno);
                        this.Close();
                        frm.Show();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                // yeni şifreler uyumlu değil ise ve bu 3 defa olmuş ise kart bloke
                else
                {
                    hataHesapla();
                }
            }else
            {
                hataHesapla();
            }
        }

        void hataHesapla()
        {
            hata++;
            if (hata == 3)
            {
                MessageBox.Show("HESABINIZ BLOKE EDİLMİŞTİR.", "UYARI MESAJI");
                string komut = "delete from tblhesap where H_Kartno=" + Kartno + "";
                mysqlim.kaydet(komut);
                this.Close();
            }
            else
            {
                MessageBox.Show(hata + ". yanlış giriş 3. defa hatalı girmeniz durumunda kartınız bloke olacaktır!", "UYARI MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
