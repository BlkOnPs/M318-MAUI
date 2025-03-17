using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparazioneTest.Models
{
    internal class Calcolatore
    {
        private string[] osservazioni = {"Respiro","Fruscio Foglie",
            "Bisbiglio","Frigorifero","Pioggia Moderata",
            "Conversazione","Traffico Città","Camion",
            "Asciugacapelli","Elicottero","Trombone",
            "Sirena di Polizia","Motore a Reazione",
            "Fuochi d'artificio"};

        private double _decibel;
        public double Decibel
        {
            get { return _decibel; }
            set {
                if (value >= 0)
                {
                    _decibel = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException ("Inserire solo valori positivi");
                }
            }
        }


        private string _colore;
        public string ColoreSoglia
        {
            get { return _colore; }
            set { _colore = value; }
        }

        public string CalcolaSoglia()
        {
            string soglia = "";
            int idTipo = (int)(_decibel / 10);

            if(idTipo >= 12)
            {
                idTipo = 12;
            }
            string tipo = osservazioni[idTipo];

            if(_decibel <= 40)
            {
                soglia = "Acettabile";
                ColoreSoglia = "#7DF570";
            }else if(_decibel > 40 && _decibel <= 60)
            {
                soglia = "Moderato";
                ColoreSoglia = "#F5BD70";
            }else if (_decibel > 60 && _decibel <= 80)
            {
                soglia = "Forte";
                ColoreSoglia = "#EA7F37";
            }else if(_decibel > 80 && _decibel <= 110)
            {
                soglia = "Troppo Forte";
                ColoreSoglia = "#FF0000";
            }
            else
            {
                soglia = "Soglia del dolore";
                ColoreSoglia = "#D600AA";
            }

            return soglia + " - " + tipo;
        }
    }
}
