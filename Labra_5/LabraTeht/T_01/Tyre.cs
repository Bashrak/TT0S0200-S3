using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Rengas
    {
        public string malli { get; set; }
        public string tyyppi { get; set; }
        public string koko { get; set; }

        public Rengas(string Malli, string Typpi, string Koko)
        {
            malli = Malli;
            tyyppi = tyyppi;
            koko = Koko;
        }
    }
}


