using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Geometria.Models
{
    internal class Cerchio
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
                    throw new ArgumentException("Inserire solo valori positivi");
                }
            }
        }
        #endregion

        #region =03=== costruttori =======================ctor==
        //comando ctor per costruttore
        public Cerchio(double raggio)
        {
            Raggio = raggio;
        }

        public Cerchio()
        {
            Raggio = 1;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================
        /// <summary>
        /// Metodo che serve a calcolare l'area di un cerchio
        /// </summary>
        /// <returns> Area del cerchio </returns>
        public double CalcolaArea()
        {
            return Math.PI * Math.Pow(Raggio,2);
        }

        /// <summary>
        /// Metodo che serve a calcolare la circonferenza di un cerchio
        /// </summary>
        /// <returns> Circonferenza del cerchio </returns>
        public double CalcolaCirconferenza()
        {
            return Math.PI * 2 * Raggio;
        }

        #endregion

    }
}
