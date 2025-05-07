using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparazioneTest.Models
{
    internal class Archivio
    {
        public List<Videogame> Videogames { get; set; }

        public Archivio() 
        {
            Videogames = new List<Videogame>();
        }

        public void AggiungiVideogame(Videogame videogame )
        {
            if (!Videogames.Contains( videogame ))
            {
                Videogames.Add(videogame);
            }
            else
            {
                throw new Exception ("Videogioco Esistente");
            }
        }
    }
}
