using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace labolatorium2
{
    public partial class Form1 : Form
    {
        private List<string> koszyk = new List<string>();
        private decimal suma = 0;
        private string transport = "Brak";
        private decimal kosztTransportu = 0;
        private string platnosc = "Nie wybrano";
        private decimal rabat = 0;
        private string wpisanyKod = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void OdswiezKoszyk()
        {
            listViewKoszyk.Items.Clear();

            foreach (string item in koszyk)
            {
                string[] dane = item.Split('-');
                ListViewItem lvi = new ListViewItem(dane[0].Trim());
                lvi.SubItems.Add(dane[1].Trim() + " z³");
                listViewKoszyk.Items.Add(lvi);
            }

            decimal calosc = suma + kosztTransportu - rabat;
            labelCena.Text = $"Cena: {calosc} z³";
        }

        private void buttonWybierz_Click(object sender, EventArgs e)
        {
            wybierz formProdukty = new wybierz();

            if (formProdukty.ShowDialog() == DialogResult.OK)
            {
                koszyk.Add($"{formProdukty.WybranyProdukt} - {formProdukty.WybranaCena}");
                suma += formProdukty.WybranaCena;
                OdswiezKoszyk();
            }
        }

        private void buttonTransport_Click(object sender, EventArgs e)
        {
            transport formDostawa = new transport();

            if (formDostawa.ShowDialog() == DialogResult.OK)
            {
                transport = formDostawa.WybranyTransport;
                kosztTransportu = formDostawa.CenaTransportu;
                OdswiezKoszyk();
            }
        }

        private void buttonZaplac_Click(object sender, EventArgs e)
        {
            zaplac formPlatnosc = new zaplac();
            formPlatnosc.ShowDialog();
        }

        private void buttonRabat_Click(object sender, EventArgs e)
        {
            rabat formRabat = new rabat();

            if (formRabat.ShowDialog() == DialogResult.OK)
            {
                wpisanyKod = formRabat.KodRabatu;

                if (wpisanyKod == "STUDENT")
                {
                    rabat = 10;
                    MessageBox.Show("Kod poprawny! Przyznano rabat 10 z³.");
                }
                else if (wpisanyKod == "PIZZA")
                {
                    rabat = 5;
                    MessageBox.Show("Kod poprawny! Przyznano rabat 5 z³.");
                }
                else
                {
                    rabat = 0;
                    MessageBox.Show("Niepoprawny kod rabatowy.");
                }

                OdswiezKoszyk();
            }
        }
    }
}