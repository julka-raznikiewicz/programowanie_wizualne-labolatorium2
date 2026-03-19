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
        public string WybranyProdukt { get; set; }
        public decimal WybranaCena { get; set; }
        public wybierz()
        {
            InitializeComponent();
            listViewProdukty.View = View.Details;
            listViewProdukty.FullRowSelect = true;
            listViewProdukty.Columns.Add("Produkt", 120);
            listViewProdukty.Columns.Add("Cena", 80);

            listViewProdukty.Items.Add(new ListViewItem(new string[] { "Pizza", "30" }));
            listViewProdukty.Items.Add(new ListViewItem(new string[] { "Burger", "25" }));
            listViewProdukty.Items.Add(new ListViewItem(new string[] { "Frytki", "10" }));
            listViewProdukty.Items.Add(new ListViewItem(new string[] { "Kebab", "22" }));
        }
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (listViewProdukty.SelectedItems.Count > 0)
            {
                WybranyProdukt = listViewProdukty.SelectedItems[0].SubItems[0].Text;
                WybranaCena = decimal.Parse(listViewProdukty.SelectedItems[0].SubItems[1].Text);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
