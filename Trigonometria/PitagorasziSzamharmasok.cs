using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigonometria
{
    class PitagorasziSzamharmasok
    {
        private double a;
        public double A
        {
            get { return a; }
        }

        private double b;
        public double B
        {
            get { return b; }
        }

        private double c;
        public double C
        {
            get { return c; }
        }

        public PitagorasziSzamharmasok(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
}
