using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJSON.Models
{
    internal class Libro
    {
		private string _titolo;

		public string Titolo
		{
			get { return _titolo; }
			set { _titolo = value; }
		}

        private string _autore;

        public string Autore
        {
            get { return _autore; }
            set { _autore = value; }
        }

        private int _annoPubblicazione;

        public int AnnoPubblicazione
        {
            get { return _annoPubblicazione; }
            set { _annoPubblicazione = value; }
        }

        public Libro(string titolo, string autore, int annoPubblicazione) {
            Titolo = titolo;
            Autore = autore;
            AnnoPubblicazione = annoPubblicazione;
        }

        public override string? ToString()
        {
            return Titolo + " - " + Autore;
        }
    }
}
