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
    public partial class zaplac : Form
    {
        public zaplac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var potwierdzenie = MessageBox.Show("potwierdzenie zapłaty");
        }
    }
}
