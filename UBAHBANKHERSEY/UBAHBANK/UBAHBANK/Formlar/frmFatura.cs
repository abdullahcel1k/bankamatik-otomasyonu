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
    public partial class frmFatura : Form
    {
        public string Kartno;
        public frmFatura(string kartno)
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

        private void btnTelekom_Click(object sender, EventArgs e)
        {
            this.Close();
            frmFaturasorgu frm = new frmFaturasorgu(Kartno);
            frm.Show();
        }

        private void btnElektrik_Click(object sender, EventArgs e)
        {
            this.Close();
            frmFaturasorgu frm = new frmFaturasorgu(Kartno);
            frm.Show();
        }
    }
}
