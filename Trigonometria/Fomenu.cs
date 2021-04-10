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
    public partial class Fomenu : Form
    {
        DB adatbazis;
        public Fomenu(DB adatbazis, User felhasznalo)
        {
            InitializeComponent();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlapok_Click(object sender, EventArgs e)
        {
            frmAlapok formAlapok = new frmAlapok();
            formAlapok.ShowDialog();
        }

        private void btnTerulet_Click(object sender, EventArgs e)
        {
            frmTerulet formTerulet = new frmTerulet();
            formTerulet.ShowDialog();
        }

        private void btnPitagorasz_Click(object sender, EventArgs e)
        {
            frmPitagorasz formPitagorasz = new frmPitagorasz();
            formPitagorasz.ShowDialog();
        }

        private void btnSzogfuggvenyek_Click(object sender, EventArgs e)
        {
            frmSzogfuggvenyek formSzogfuggvenyek = new frmSzogfuggvenyek();
            formSzogfuggvenyek.ShowDialog();
        }
    }
}
