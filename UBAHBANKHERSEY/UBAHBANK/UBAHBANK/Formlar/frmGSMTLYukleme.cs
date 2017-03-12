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
    public partial class frmGSMTLYukleme : Form
    {
        public string Kartno;
        public frmGSMTLYukleme(string kartno)
        {
            InitializeComponent();
            Kartno = kartno;
        }

        private void btnAnamenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAnamenu frm = new frmAnamenu(Kartno);
            frm.Show();
        }

        private void btnTurkcel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTLyukle frm = new frmTLyukle(Kartno);
            frm.Show();
        }

        private void btnVodafone_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTLyukle frm = new frmTLyukle(Kartno);
            frm.Show();
        }

        private void btnTurktelekom_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTLyukle frm = new frmTLyukle(Kartno);
            frm.Show();
        }
    }
}
