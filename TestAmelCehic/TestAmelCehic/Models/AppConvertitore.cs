using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAmelCehic.Models
{
    internal class AppConvertitore
    {

        #region =01=== costanti & statici ======================
        #endregion

        #region =02=== membri & proprietà ============propfull==
        private float _franco;

        public float Franco
        {
            get { return _franco; }
            set
            {
                if (value >= 0.0)
                {
                    _franco = value;
                }
                else
                {
                    throw new ArgumentException("Inserire solo valori positivi"); ;
                }
            }
        }

        private float _cambio;

        public float Cambio
        {
            get { return _cambio; }
            set
            {
                if (value >= 0)
                {
                    _cambio = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Inserire valori maggiori a 0");
                }
            }
        }
        #endregion

        #region =03=== costruttori =======================ctor==
        public AppConvertitore(float franco, float cambio)
        {
            Franco = franco;
            Cambio = cambio;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================
        /// <summary>
        /// Convertire Franco in Euro
        /// </summary>
        /// <returns>>Ritorna l'euro convertito con il franco e il cambio medio</returns>
        public string ConvertiFrEu()
        {
            float calcolo = _franco * _cambio;
            Math.Round(calcolo, 2);
            string valore = Convert.ToString(calcolo);
            return $"{valore} EUR";
        }

        /// <summary>
        /// Genera la data attuale
        /// </summary>
        /// <returns>>Ritorna la data attuale, l'orario, e il cambio medio attuale</returns>
        public string GeneraData()
        {
            DateTime data = DateTime.Now;
            string dataConPunti = data.ToString("dd.MM.yyy");
            string orario = data.ToString("HH:mm:ss");
            return $"Oggi {dataConPunti} {orario} 1 Franco vale {Cambio}Euro";
        }
        #endregion
    }
}
