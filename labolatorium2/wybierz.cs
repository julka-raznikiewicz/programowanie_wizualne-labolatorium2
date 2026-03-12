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
    public partial class wybierz : Form
    {
        public wybierz()
        {
            InitializeComponent();
            listBox1.Items.Add("Pizza - 25 zł");
            listBox1.Items.Add("Burger - 18 zł");
            listBox1.Items.Add("Frytki - 10 zł");
            listBox1.Items.Add("Kebab - 22 zł");
            listBox1.Items.Add("Cola - 7 zł");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
