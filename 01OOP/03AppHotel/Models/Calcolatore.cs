using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AppHotel.Models
{
    internal class Calcolatore
    {
        #region =01=== costanti & statici ======================
        #endregion

        #region =02=== membri & proprietà ============propfull==
        private bool _hasAnimal;
        public bool HasAnimal
        {
            get { return _hasAnimal; }
            set { _hasAnimal = value; }
        }


        private DatePicker _dataArrivo;
        public DatePicker DataArrivo
        {
            get { return _dataArrivo; }
            set { _dataArrivo = value; }
        }

        private DatePicker _dataPartenza;
        public DatePicker DataPartenza
        {
            get { return _dataPartenza; }
            set { _dataPartenza = value; }
        }

        private int _persone;
        public int Persone
        {
            get { return _persone; }
            set { _persone = value; }
        }

        private Stanza _stanza;
        public Stanza Stanza
        {
            get { return _stanza; }
            set { _stanza = value; }
        }
        #endregion

        #region =03=== costruttori =======================ctor==
        //comando ctor per costruttore
        public Calcolatore(Stanza stanza)
        {
            HasAnimal = false;
            Persone = 0;
            Stanza = stanza;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================
        public int CalcolaGiorni()
        {
            //Permette di restituire la differenza (in giorni) tra 2 date
            DateTime dataArrivo = DataArrivo.Date;
            DateTime dataPartenza = DataPartenza.Date;
            TimeSpan diff = dataPartenza.Subtract(dataArrivo);
            return Convert.ToInt32(diff.Days);
        }
        public double CalcolaCosto()
        {
            double costo = CalcolaGiorni() * Persone * Stanza.Costo;
            if (HasAnimal)
            {
                costo += CalcolaGiorni() * 20;
            }
            return costo;
        }
        #endregion
    }
}
