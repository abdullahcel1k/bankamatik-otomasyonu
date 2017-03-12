using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace UBAHBANK.Sınıflar
{
    class duzenleyici
    {
        public bool devamEtmek()
        {
            DialogResult secim = MessageBox.Show("İşleminiz başarı ile sonuçlandırıldı. \n Başka bir işlem yapmak istermisiniz ?", "UYARI MESAJI", MessageBoxButtons.YesNo);
            if (secim == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
