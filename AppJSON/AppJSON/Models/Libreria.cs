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
        public Libreria(List<Libro> libri) { 
            Libri = libri;
        }
    }
}
