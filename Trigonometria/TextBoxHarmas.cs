using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trigonometria
{
    class TextBoxHarmas
    {
        private TextBox textBoxA;

        public TextBox TextBoxA
        {
            get { return textBoxA; }
        }

        private TextBox textBoxB;

        public TextBox TextBoxB
        {
            get { return textBoxB; }
        }

        private TextBox textBoxC;

        public TextBox TextBoxC
        {
            get { return textBoxC; }
        }

        public TextBoxHarmas(TextBox textBoxA, TextBox textBoxB, TextBox textBoxC)
        {
            this.textBoxA = textBoxA;
            this.textBoxB = textBoxB;
            this.textBoxC = textBoxC;
        }
    }
}
