using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Geometria.Models
{
    internal class Triangolo
    {
        #region =01=== costanti & statici ======================
        #endregion

        #region =02=== membri & proprietà ============propfull==
        //propfull comando da fare
        //Campo
        private double _base;

        //Metodo Proprità Full
        public double Base
        {
            get
            {
                return _base;
            }
            set
            {
                if (value >= 0)
                {
                    _base = value;
                }
                else
                {
                    //è come await DisplayAlert
                    throw new ArgumentException ("Inserire solo valori positivi");
                }
            }
        }

        private double _altezza;

        public double Altezza
        {
            get
            {
                return _altezza;
            }
            set
            {
                if (value >= 0)
                {
                    _altezza = value;
                }
                else
                {
                    //è come await DisplayAlert
                    throw new ArgumentException ("Inserire solo valori positivi");
                }
            }
        }
        #endregion

        #region =03=== costruttori =======================ctor==
        //comando ctor per costruttore
        public Triangolo ( double Basee, double altezza )
        {
            Base = Basee;
            Altezza = altezza;
        }

        public Triangolo ( )
        {
            Base = 1;
            Altezza = 1;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================
        /// <summary>
        /// Metodo che serve a calcolare l'area di un Triangolo
        /// </summary>
        /// <returns> Area del Triangolo </returns>
        public double CalcolaArea ( )
        {
            return (Base * Altezza)/2;
        }

        /// <summary>
        /// Metodo che serve a calcolare il perimetro di un Triangolo
        /// </summary>
        /// <returns> Perimetro del Triangolo </returns>
        public double CalcolaPerimentro ( )
        {
            return Base + Altezza + Math.Sqrt (Math.Pow (Base, 2) + Math.Pow (Altezza, 2));
        }
        #endregion
    }
}
