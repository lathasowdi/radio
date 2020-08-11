using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening4
{
    class Notities
    {
        public string Notitie { get; set; }
        public Notities( string notitie)
        {
            Notitie = notitie;
        }
        public string Bijschrijven(string bijschrift)
        {
            return Notitie += " " + bijschrift;
        }

        public string Bekijknotitie()
        {
            return Notitie;
        }
    }
}
