using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Geometria.Models
{
    internal class Cubo
    {
        #region =01=== costanti & statici ======================
        #endregion

        #region =02=== membri & proprietà ============propfull==
        //propfull comando da fare
        //Campo
        private double _lato;

        //Metodo Proprità Full
        public double Lato
        {
            get
            {
                return _lato;
            }
            set
            {
                if (value >= 0)
                {
                    _lato = value;
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
        public Cubo ( double lato )
        {
            Lato = lato;
        }

        public Cubo ( )
        {
            Lato = 1;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================
        /// <summary>
        /// Metodo che serve a calcolare il volume di un cubo
        /// </summary>
        /// <returns> Volume del cubo</returns>
        public double CalcolaVolume ( )
        {
            return Math.Pow(Lato,3);
        }

        /// <summary>
        /// Metodo che serve a calcolare il perimetro di un cubo
        /// </summary>
        /// <returns> Perimetro del cubo</returns>
        public double CalcolaPerimetro ( )
        {
            return Lato * 12;
        }
        #endregion
    }
}
