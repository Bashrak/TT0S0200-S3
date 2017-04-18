using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Kulkuneuvo
    {
        public List<Rengas> lista = new List<Rengas>();
        string Nimi { get; set; }
        string Malli { get; set; }

        public Kulkuneuvo(string nimi, string malli)

        {
            Nimi = nimi;
            Malli = malli;

        }

        public override string ToString()
        {
            return "\nVehicle: " + Nimi + ". Model: " + Malli;
        }

        public void AddRengas(string merkki, string tyyppi, string koko)
        {
            lista.Add(new Rengas(merkki, tyyppi, koko));
            Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}.", merkki, Nimi);

        }

        public List<Rengas> Renkaat
        {
            get { return lista; }
        }

    }
}
