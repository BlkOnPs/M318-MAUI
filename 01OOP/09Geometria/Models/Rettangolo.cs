using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Geometria.Models
{
    internal class Rettangolo
    {
        #region =01=== costanti & statici ======================
        #endregion

        #region =02=== membri & proprietà ============propfull==
        //propfull comando da fare
        //Campo
        private double _latoMinore;

        //Metodo Proprità Full
        public double LatoMinore
        {
            get
            {
                return _latoMinore;
            }
            set
            {
                if (value >= 0)
                {
                    _latoMinore = value;
                }
                else
                {
                    //è come await DisplayAlert
                    throw new ArgumentException("Inserire solo valori positivi");
                }
            }
        }

        private double _latoMaggiore;

        public double LatoMaggiore
        {
            get
            {
                return _latoMaggiore;
            }
            set
            {
                if (value >= 0)
                {
                    _latoMaggiore = value;
                }
                else
                {
                    //è come await DisplayAlert
                    throw new ArgumentException("Inserire solo valori positivi");
                }
            }
        }
        #endregion

        #region =03=== costruttori =======================ctor==
        //comando ctor per costruttore
        public Rettangolo(double latoMinore, double latoMaggiore)
        {
            LatoMinore = latoMinore;
            LatoMaggiore = latoMaggiore;
        }

        public Rettangolo()
        {
            LatoMaggiore = 1;
            LatoMinore = 1;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================
        /// <summary>
        /// Metodo che serve a calcolare l'area di un rettangolo
        /// </summary>
        /// <returns> Area del rettangolo </returns>
        public double CalcolaArea()
        {
            return LatoMaggiore * LatoMinore;
        }

        /// <summary>
        /// Metodo che serve a calcolare il perimetro di un rettangolo
        /// </summary>
        /// <returns> Perimetro del rettangolo </returns>
        public double CalcolaPerimentro()
        {
            return LatoMinore * 2 + LatoMaggiore * 2;
        }
        #endregion
    }
}
