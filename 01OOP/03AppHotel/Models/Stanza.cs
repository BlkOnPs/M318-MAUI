using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AppHotel.Models
{
    internal class Stanza
    {
        private int _numero;

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private int _costo;
        public int Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }
        private string _osservazioni;
        public string Osservazioni
        {
            get { return _osservazioni; }
            set { _osservazioni = value; }
        }

        public Stanza(int numero, int costo, string osservazioni)
        {
            Numero = numero;
            Costo = costo;
            Osservazioni = osservazioni;
        }
    }
}
