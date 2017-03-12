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
    public partial class frmAnamenu : Form
    {
        public string Kartno;
        public frmAnamenu(string kartno)
        {
            Kartno = kartno;
            InitializeComponent();
        }

        private void btnParacek_Click(object sender, EventArgs e)
        {
            this.Close();
            frmParacek frm = new frmParacek(Kartno);
            frm.Show();
        }

        private void frmAnamenu_Load(object sender, EventArgs e)
        {

        }

        private void btnDiger_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDiger frm = new frmDiger(Kartno);
            frm.Show();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            this.Close();
            frmFatura frm = new frmFatura(Kartno);
            frm.Show();
        }

        private void btnGSMTL_Click(object sender, EventArgs e)
        {
            this.Close();
            frmGSMTLYukleme frm = new frmGSMTLYukleme(Kartno);
            frm.Show();
        }
    }
}
