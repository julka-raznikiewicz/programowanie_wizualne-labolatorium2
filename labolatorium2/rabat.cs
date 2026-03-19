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
    public partial class rabat : Form
    {
        public string KodRabatu { get; set; }
        public rabat()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            KodRabatu = textBoxKod.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
