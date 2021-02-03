using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MehmetFatihSahin_KatmanliMimari
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }
        Kullanici g = new Kullanici();
        private void girisyap_Click(object sender, EventArgs e)
        {
            g.Kullanicii(giriskodu,kadi,sifre);
        }
    }
}
