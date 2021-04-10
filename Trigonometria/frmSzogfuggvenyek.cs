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
    public partial class frmSzogfuggvenyek : Form
    {
        public frmSzogfuggvenyek()
        {
            InitializeComponent();
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGyakorlas_Click(object sender, EventArgs e)
        {
            SzogfuggvenyekGyakorlas formSzogfuggvenyekGyakorlas = new SzogfuggvenyekGyakorlas();
            formSzogfuggvenyekGyakorlas.ShowDialog();
        }
    }
}
