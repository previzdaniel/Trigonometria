using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trigonometria
{
    public partial class frmTeruletGyakorlas : Form
    {
        Dictionary<string, double> adatok = new Dictionary<string, double>();
        List<TextBox> textboxok = new List<TextBox>();

        public frmTeruletGyakorlas()
        {
            InitializeComponent();
            TextboxokListaba();
            AltalanosHaromszogGeneralas();
            FeladatKiadasa();
        }
        void TextboxokListaba()
        {
            textboxok.Add(tba);
            textboxok.Add(tbb);
            textboxok.Add(tbc);
            textboxok.Add(tbAlfa);
            textboxok.Add(tbBeta);
            textboxok.Add(tbGamma);
            textboxok.Add(tbm);
            textboxok.Add(tbt);
        }

        void AltalanosHaromszogGeneralas()
        {
            Random rnd = new Random();
            double a1 = 0;
            double a2 = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double alfa = 0;
            double beta = 0;
            double gamma = 0;
            double m = 0;
            double t = 0;

            c = rnd.Next(5, 30);
            beta = rnd.Next(15, 65);
            gamma = rnd.Next(15, 65);

            a1 = Math.Round(Math.Cos(beta * (Math.PI / 180)) * c,2);
            m = Math.Round(Math.Sin(beta * (Math.PI / 180)) * c,2);

            b = Math.Round(m / Math.Sin(gamma * (Math.PI / 180)),2);
            a2 = Math.Round(Math.Cos(gamma * (Math.PI / 180)) * b,2);

            a = a1 + a2;
            alfa = 180 - beta - gamma;

            t = Math.Round((a * m) / 2,2);

            adatok.Add("a", a);
            adatok.Add("b", b);
            adatok.Add("c", c);
            adatok.Add("alfa", alfa);
            adatok.Add("béta", beta);
            adatok.Add("gamma", gamma);
            adatok.Add("m", m);
            adatok.Add("t", t);
        }

        void FeladatKiadasa()
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                int index = rnd.Next(0, adatok.Count);
                for (int j = 0; j < adatok.Count; j++)
                {
                    if (index == j && textboxok[j].Text == "")
                    {
                        var adat = adatok.ElementAt(j);
                        var adatKulcs = adat.Key;
                        var adatErtek = adat.Value;

                        textboxok[j].Text = adatErtek.ToString();
                        textboxok[j].Enabled = false;
                    }
                }
            }
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            adatok.Clear();
            for (int i = 0; i < textboxok.Count; i++)
            {
                textboxok[i].Text = "";
                textboxok[i].Enabled = true;
                textboxok[i].BackColor = Color.White;
            }
            AltalanosHaromszogGeneralas();
            FeladatKiadasa();
        }

        private void btnEllenorzes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < adatok.Count; i++)
            {
                var adat = adatok.ElementAt(i);
                var adatKulcs = adat.Key;
                var adatErtek = adat.Value;

                double aktualisSzam = Convert.ToDouble(textboxok[i].Text);

                if (Math.Floor(adatErtek) == Math.Floor(aktualisSzam) && textboxok[i].Enabled == true)
                {
                    textboxok[i].BackColor = Color.Green;
                }
                else if(Math.Floor(adatErtek) != Math.Floor(aktualisSzam) && textboxok[i].Enabled == true)
                {
                    textboxok[i].BackColor = Color.Red;
                }
                else if(textboxok[i].Enabled == false)
                {

                }
            }
        }
    }
}
