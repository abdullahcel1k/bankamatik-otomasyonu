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
    
    public partial class frmGiris : Form
    {
        public int hata=0;
        public string kartno;
        Sınıflar.VTBaglanti mysqlim = new Sınıflar.VTBaglanti();
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool sonuc = false;
            kartno = txtKartno.Text;

            if (txtKartno.Text!="" && txtSifre.Text!="")
            {
                sonuc = mysqlim.giris(txtKartno.Text, txtSifre.Text);
                if (sonuc == true)
                {
                    txtKartno.Text = "";
                    txtSifre.Text = "";
                    Formlar.frmAnamenu frm = new frmAnamenu(kartno);
                    frm.Show();
                }
                else
                {
                    hataHesapla();
                }
            }else
            {
                MessageBox.Show("Boş alanları doldurun!", "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        void hataHesapla()
        {
            txtKartno.Text = "";
            txtSifre.Text = "";
            hata++;
            if (hata == 3)
            {
                // hata 3 olduğu zaman müşterinin kartını bloke edioyoruz
                MessageBox.Show("HESABINIZ BLOKE EDİLMİŞTİR.", "UYARI MESAJI");
                string komut = "delete from tblkart where K_No=" + txtKartno.Text + "";
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
