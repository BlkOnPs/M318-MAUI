using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJSON.Models
{
    internal class Libreria
    {
        public List<Libro> Libri { get; set; }

        public Libreria() { 
            Libri = new List<Libro>();
        }

        public void AggiungiLIbro(Libro libro)
        {
            if (!Libri.Contains(libro))
            {
                Libri.Add(libro);
            }
            else
            {
                throw new Exception("Libro esistente");
            }
        }
    }
}
