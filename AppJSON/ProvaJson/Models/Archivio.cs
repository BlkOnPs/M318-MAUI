using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaJson.Models
{
    internal class Archivio
    {
        public List<Videogame> Videogames = new List<Videogame>();

        public void AggiungiVideogioco(Videogame gioco )
        {
            Videogames.Add( gioco );
        }
    }
}
