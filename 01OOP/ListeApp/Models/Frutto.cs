using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeApp.Models
{
    internal class Frutto
    {
		private string _nome;

		public string Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

        private string _provienienza;

        public string Provenienza
        {
            get { return _provienienza; }
            set { _provienienza = value; }
        }

        public Frutto(string nome, string provenienza)
        {
            Nome = nome;
            Provenienza = provenienza;
        }

        public override string? ToString()
        {
            return Nome + "; " + Provenienza;
        }
    }
}
