using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rok
    {
        int rokID;
        public int RokID
        {
            get { return rokID; }
            set { rokID = value; }
        }

        string naziv;
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        bool aktivanRok;
        public bool AktivanRok
        {
            get { return aktivanRok; }
            set { aktivanRok = value; }
        }

        public override string ToString()
        {
            return naziv;
        }
    }
}

