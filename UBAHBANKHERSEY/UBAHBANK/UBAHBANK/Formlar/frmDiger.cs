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
    public partial class frmDiger : Form
    {
        public string Kartno;
        public frmDiger(string kartno)
        {
            InitializeComponent();
            Kartno = kartno;
        }

        private void frmDiger_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSifredegis_Click(object sender, EventArgs e)
        {
            frmSifredegistir frm = new frmSifredegistir(Kartno);
            this.Close();
            frm.Show();
        }

        private void btnTelefonupdate_Click(object sender, EventArgs e)
        {
            frmTelefonguncelle frm = new frmTelefonguncelle();
            this.Close();
            frm.Show();
        }
    }
}
