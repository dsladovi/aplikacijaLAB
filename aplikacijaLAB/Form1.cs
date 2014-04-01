using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacijaLAB
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            float polumjer = 0;
            float povrsina = 0;
            float opseg = 0;
            float.TryParse(txtPolumjer.Text, out polumjer);
            Izracunaj(polumjer, ref povrsina, ref opseg);
        }

        private void Izracunaj(float polumjer, ref float povrsina, ref float opseg)
        {
            if (polumjer > 0)
            {
                povrsina = polumjer * polumjer * (float)Math.PI;
                opseg = 2 * polumjer * (float)Math.PI;

                txtPovrsina.Text = povrsina.ToString();
                txtOpseg.Text = opseg.ToString();

            }
        }
        /// <summary>
       ///ova metoda sluzi za ispis rez
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstRezultati_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            float polumjer = 0;
            float.TryParse(lstRezultati.SelectedItem.ToString(),out polumjer);
            txtPolumjer.Text = polumjer.ToString();
            btnIzracunaj_Click(null,null);
        }
    }
}
