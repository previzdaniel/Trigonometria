using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Trigonometria
{
    public class User
    {
        private string nev;
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        private string jelszo;
        public string Jelszo
        {
            get { return jelszo; }
            set { jelszo = value; }
        }        

        private string teljesNev;
        public string TeljesNev
        {
            get { return teljesNev; }
            set { teljesNev = value; }
        }
        
        private string jogkor;
        public string Jogkor
        {
            get { return jogkor; }
            set { jogkor = value; }
        }

        public User(string nev, string jelszo, string teljesNev, string jogkor)
        {
            this.nev = nev;
            this.jelszo = jelszo;
            this.teljesNev = teljesNev;
            this.jogkor = jogkor;
        }
    }
}
