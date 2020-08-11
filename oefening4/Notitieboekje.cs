using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening4
{
    class Notitieboekje
    {
        public List<Notities> MijnNotities { get; set; }
        public Notitieboekje()
        {
            MijnNotities = new List<Notities>();
        }
        public void Aanmaken(string notitie)
        {
            Notities newNote = new Notities(notitie);
            MijnNotities.Add(newNote);
        }
        public string BekijkNotitie(int index)
        {
            return MijnNotities[index].Bekijknotitie();

        }
        public string NotitieBijschrijven(int index, string bijschrift)
        {
            return MijnNotities[index].Bijschrijven(bijschrift);

        }
    }
}
