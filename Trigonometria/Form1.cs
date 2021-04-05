using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Trigonometria
{
    public partial class Form1 : Form
    {
        DB adatbazis;
        User felhasznalo;
        public Form1()
        {
            InitializeComponent();
            tbFelhasznalo.Focus();
            adatbazis = new DB("localhost", "trigonometria", "root");
        }

        private void btnBejelentkezes_Click(object sender, EventArgs e)
        {
            string nev = tbFelhasznalo.Text;
            string jelszo = tbJelszo.Text;

            if (nev != "" && jelszo != "")
            {
                try
                {
                    adatbazis.MysqlKapcsolat.Open();

                    string lekerdezes = "SELECT felhasznalonev, jelszo, teljesNev, jogosultsag_id  FROM felhasznalok " +
                                        "WHERE felhasznalonev = '" + nev + "' and jelszo = '" + jelszo + "';";

                    MySqlDataReader sorok;
                    MySqlCommand parancs = new MySqlCommand(lekerdezes, adatbazis.MysqlKapcsolat);
                    sorok = parancs.ExecuteReader();

                    if (sorok.HasRows)
                    {
                        while (sorok.Read())
                        {
                            string felhasznaloNev = sorok["felhasznalonev"].ToString();
                            string felhasznaloJelszo = sorok["jelszo"].ToString();
                            string teljesNev = sorok["teljesNev"].ToString();
                            string jogosultsag = sorok["jogosultsag_id"].ToString();

                            felhasznalo = new User(felhasznaloNev, felhasznaloJelszo, jogosultsag, teljesNev);
                        }

                        MessageBox.Show("Köszöntelek: " + felhasznalo.Nev);
                        this.Hide();
                        adatbazis.MysqlKapcsolat.Close();
                        Fomenu formFo = new Fomenu(adatbazis, felhasznalo);
                        formFo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Felhasználónév vagy jelszó nem jó!", "Hiba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        adatbazis.MysqlKapcsolat.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Number + ":" + ex.Message, "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adatbazis.MysqlKapcsolat.Close();
                }
            }
            else
            {
                MessageBox.Show("Felhasználónév vagy jelszó nem lehet üres!", "Hiba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
