using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVideoGame20.Models
{
    internal class CatalogoVideogames
    {
        public List<Videogame> Videogames { get; set; }

        public CatalogoVideogames()
        {
            Videogames = new List<Videogame>();
        }

        public void AggiungiVideogame(Videogame gioco)
        {
            if (!Videogames.Contains(gioco))
            {
                Videogames.Add(gioco);
            }
            else
            {
                throw new Exception("Videogioco Esistente");
            }
        }
    }
}
