using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Predmet
    {
        int predmetID;
        public int PredmetID
        {
            get { return predmetID; }
            set { predmetID = value; }
        }

        string naziv;
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public override string ToString()
        {
            return naziv;
        }
    }
}
