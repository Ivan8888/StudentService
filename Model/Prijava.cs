using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Prijava
    {
        int brojPrijave;
        public int BrojPrijave
        {
            get { return brojPrijave; }
            set { brojPrijave = value; }
        }

        Rok rok;
        public Rok Rok
        {
            get { return rok; }
            set { rok = value; }
        }

        Student student;
        public Student Student
        {
            get { return student; }
            set { student = value; }
        }

        Predmet predmet;
        public Predmet Predmet
        {
            get { return predmet; }
            set { predmet = value; }
        }

        DateTime datum;
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        int ocena;
        public int Ocena
        {
            get { return ocena; }
            set { ocena = value; }
        }
    }
}
