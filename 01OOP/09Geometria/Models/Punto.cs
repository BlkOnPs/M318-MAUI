using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Geometria.Models
{
    internal class Punto
    {
        #region =01=== costanti & statici ======================
        #endregion

        #region =02=== membri & proprietà ============propfull==
        //propfull comando da fare
        //Campo
        private double _valoreX;

        //Metodo Proprità Full
        public double ValoreX
        {
            get
            {
                return _valoreX;
            }
            set
            {
                if (value >= 0)
                {
                    _valoreX = value;
                }
                else
                {
                    //è come await DisplayAlert
                    throw new ArgumentException ("Inserire solo valori positivi");
                }
            }
        }

        private double _valoreY;

        public double ValoreY
        {
            get
            {
                return _valoreY;
            }
            set
            {
                if (value >= 0)
                {
                    _valoreY = value;
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
        public Punto ( double x, double y)
        {
            ValoreX = x;
            ValoreY= y;
        }

        public Punto ( )
        {
            ValoreX = 1;
            ValoreY = 1;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================
        /// <summary>
        /// Metodo che serve a calcolare la distanza di x,y dal punto 0,0
        /// </summary>
        /// <returns> Distanza dal 0,0 </returns>
        public double CalcolaDistanza ( )
        {
            return Math.Sqrt(Math.Pow(ValoreX,2) + Math.Pow (ValoreY, 2));
        }
        #endregion
    }
}
