using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        int brojIndeksa;
        public int BrojIndeksa
        {
            get { return brojIndeksa; }
            set { brojIndeksa = value; }
        }

        string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        List<Predmet> listaPredmeta = new List<Predmet>();
        public List<Predmet> ListaPredmeta
        {
            get { return listaPredmeta; }
            set { listaPredmeta = value; }
        }

        public override string ToString()
        {
            return ime + " " + prezime;
        }

    }
}
