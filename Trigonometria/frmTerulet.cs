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
    public partial class frmTerulet : Form
    {
        public frmTerulet()
        {
            InitializeComponent();
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGyakorlas_Click(object sender, EventArgs e)
        {
            frmTeruletGyakorlas formTeruletGyakorlas = new frmTeruletGyakorlas();
            formTeruletGyakorlas.ShowDialog();
        }
    }
}
