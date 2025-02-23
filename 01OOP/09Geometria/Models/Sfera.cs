using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Geometria.Models
{
    internal class Sfera
    {
        #region =01=== costanti & statici ======================
        #endregion

        #region =02=== membri & proprietà ============propfull==
        //propfull comando da fare
        //Campo
        private double _raggio;

        //Metodo Proprità Full
        public double Raggio
        {
            get
            {
                return _raggio;
            }
            set
            {
                if (value >= 0)
                {
                    _raggio = value;
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
        public Sfera ( double raggio )
        {
            Raggio = raggio;
        }

        public Sfera ( )
        {
            Raggio = 1;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================
        /// <summary>
        /// Metodo che serve a calcolare il volume di una sfera
        /// </summary>
        /// <returns> Volume del cubo</returns>
        public double CalcolaVolume ( )
        {
            return 4/3 * Math.PI * Math.Pow(Raggio,3);
        }
        #endregion
    }
}
