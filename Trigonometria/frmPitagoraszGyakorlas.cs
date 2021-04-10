using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Trigonometria
{
    public partial class frmPitagoraszGyakorlas : Form
    {
        List<PitagorasziSzamharmasok> szamharmasok = new List<PitagorasziSzamharmasok>();
        List<PitagorasziSzamharmasok> ideiglenes = new List<PitagorasziSzamharmasok>();
        List<TextBox> textboxok = new List<TextBox>();
        public frmPitagoraszGyakorlas()
        {
            InitializeComponent();
            Beolvasas();
            TextBoxokListaba();
            SzamharmasokKivalogatasa();
            TextBoxokFeltoltese();
            FeladatKiadasa();
        }

        void Beolvasas()
        {
            StreamReader be = new StreamReader("szamharmasok.txt");
            be.ReadLine();
            while (!be.EndOfStream)
            {
                string[] a = be.ReadLine().Split(';');
                szamharmasok.Add(new PitagorasziSzamharmasok(double.Parse(a[0]), double.Parse(a[1]), double.Parse(a[2])));
            }
            be.Close();
        }

        void TextBoxokListaba()
        {
            textboxok.Add(tbA1);
            textboxok.Add(tbB1);
            textboxok.Add(tbC1);

            textboxok.Add(tbA2);
            textboxok.Add(tbB2);
            textboxok.Add(tbC2);

            textboxok.Add(tbA3);
            textboxok.Add(tbB3);
            textboxok.Add(tbC3);

            textboxok.Add(tbA4);
            textboxok.Add(tbB4);
            textboxok.Add(tbC4);

            textboxok.Add(tbA5);
            textboxok.Add(tbB5);
            textboxok.Add(tbC5);

            textboxok.Add(tbA6);
            textboxok.Add(tbB6);
            textboxok.Add(tbC6);

            textboxok.Add(tbA7);
            textboxok.Add(tbB7);
            textboxok.Add(tbC7);

            textboxok.Add(tbA8);
            textboxok.Add(tbB8);
            textboxok.Add(tbC8);

            textboxok.Add(tbA9);
            textboxok.Add(tbB9);
            textboxok.Add(tbC9);
        }

        void SzamharmasokKivalogatasa()
        {
            Random rnd = new Random();
            for (int j = 0; j < 9; j++)
            {
                int veletlenSor = rnd.Next(0, szamharmasok.Count);
                for (int i = 0; i < szamharmasok.Count; i++)
                {
                    if (veletlenSor == i && !ideiglenes.Contains(szamharmasok[i]))
                    {
                        ideiglenes.Add(new PitagorasziSzamharmasok(szamharmasok[i].A, szamharmasok[i].B, szamharmasok[i].C));
                    }
                }
            }
        }

        void TextBoxokFeltoltese()
        {
            int index = 0;
            int szamharmasokIndex = 0;
            int sorAzonosito = 0;
            for (int i = 0; i < ideiglenes.Count; i++)
            {   
                for (int j = 0; j < 3; j++)
                {
                    if (index - sorAzonosito == 0)
                    {
                        textboxok[index].Text = ideiglenes[szamharmasokIndex].A.ToString();
                    }
                    else if (index - sorAzonosito == 1)
                    {
                        textboxok[index].Text = ideiglenes[szamharmasokIndex].B.ToString();
                    }
                    else if (index - sorAzonosito == 2)
                    {
                        textboxok[index].Text = ideiglenes[szamharmasokIndex].C.ToString();
                    }
                    index++;
                }
                sorAzonosito += 3;
                szamharmasokIndex++;
            }
        }

        void FeladatKiadasa()
        {
            Random rnd = new Random();
            for (int i = 0; i < textboxok.Count; i++)
            {
                if (i % 3 == 0)
                {
                    int egyik = rnd.Next(0, 3);
                    for (int j = 0; j < 3; j++)
                    {
                        if (j == egyik)
                        {
                            textboxok[i+j].Text = "";
                        }
                        else
                        {
                            textboxok[i + j].Enabled = false;
                        }
                    }
                }
            }
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEllenorzes_Click(object sender, EventArgs e)
        {
            int index = 0;
            int szamharmasokIndex = 0;
            int sorAzonosito = 0;
            for (int i = 0; i < ideiglenes.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (index - sorAzonosito == 0)
                    {
                        if (textboxok[index].Text == ideiglenes[szamharmasokIndex].A.ToString() && textboxok[index].Enabled == true)
                        {
                            textboxok[index].BackColor = Color.Green;
                        }
                        else if(textboxok[index].Enabled == true)
                        {
                            textboxok[index].BackColor = Color.Red;
                        }
                    }
                    else if (index - sorAzonosito == 1)
                    {
                        if (textboxok[index].Text == ideiglenes[szamharmasokIndex].B.ToString() && textboxok[index].Enabled == true)
                        {
                            textboxok[index].BackColor = Color.Green;
                        }
                        else if(textboxok[index].Enabled == true)
                        {
                            textboxok[index].BackColor = Color.Red;
                        }
                    }
                    else if (index - sorAzonosito == 2)
                    {
                        if (textboxok[index].Text == ideiglenes[szamharmasokIndex].C.ToString() && textboxok[index].Enabled == true)
                        {
                            textboxok[index].BackColor = Color.Green;
                        }
                        else if(textboxok[index].Enabled == true)
                        {
                            textboxok[index].BackColor = Color.Red;
                        }
                    }
                    index++;
                }
                sorAzonosito += 3;
                szamharmasokIndex++;
            }
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            ideiglenes.Clear();
            for (int i = 0; i < textboxok.Count; i++)
            {
                textboxok[i].Enabled = true;
                textboxok[i].BackColor = Color.White;
            }
            SzamharmasokKivalogatasa();
            TextBoxokFeltoltese();
            FeladatKiadasa();
        }
    }
}
