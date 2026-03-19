using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labolatorium2
{

    public partial class transport : Form
    {
        public string WybranyTransport { get; set; }
        public decimal CenaTransportu { get; set; }
        public transport()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            WybranyTransport = "";
            CenaTransportu = 0;

            if (checkBoxOdbiorOsobisty.Checked)
            {
                WybranyTransport = "Odbiór osobisty";
                CenaTransportu = 0;
            }
            else
            {
                if (checkBoxDowoz.Checked)
                {
                    WybranyTransport += "Dowóz ";
                    CenaTransportu += 8;
                }

                if (checkBoxEkspres.Checked)
                {
                    WybranyTransport += "Ekspres ";
                    CenaTransportu += 5;
                }
            }

            if (WybranyTransport == "")
            {
                WybranyTransport = "Brak";
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
