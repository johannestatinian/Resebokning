using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokning
{
    class Resa
    {
        public string kund = "";
        public string destination = "";
        public int antalDagar = 0;


        public Resa(string k, string d, int a)
        {
            kund = k;
            destination = d;
            antalDagar = a;
        }

        public string Kund
        {
            get { return kund; }
        }

        public override string ToString()
        {
            return destination+":  " + antalDagar+"   Dagar";
        }


    }



}
