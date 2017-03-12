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
    public partial class frmFaturasorgu : Form
    {
        Sınıflar.VTBaglanti mysqlim = new Sınıflar.VTBaglanti();

        public string Kartno;
        public string Musterino;
        public frmFaturasorgu(string kartno)
        {
            InitializeComponent();
            Kartno = kartno;
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            bool sonuc;
            Musterino = txtMusterino.Text;
            string sorgu = "select * from tblfatura where M_No="+txtMusterino.Text;
            sonuc=mysqlim.sqlVarlik(sorgu);
            if (sonuc == true)
            {
                this.Close();
                frmFaturaode frm = new frmFaturaode(Kartno,Musterino);
                frm.Show();
            }else
            {
                DialogResult secim = MessageBox.Show("Bu hesap numarasına ait müşteri bulunamamıştır. \n Tekrar denemek istermisiniz ?", "UYARI MESAJI", MessageBoxButtons.YesNo);
                if (secim == DialogResult.Yes)
                {
                    
                }
                else
                {
                    this.Close();
                    frmAnamenu frm = new frmAnamenu(Kartno);
                    frm.Show();
                }
            }
        }
    }
}
