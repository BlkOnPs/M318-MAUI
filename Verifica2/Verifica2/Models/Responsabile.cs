using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica2.Models
{
    internal class Responsabile
    {
        #region =01=== costanti & statici ======================
        #endregion

        #region =02=== membri & proprietà ============propfull==

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _cognome;

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        #endregion

        #region =03=== costruttori =======================ctor==
        public Responsabile(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================

        public override string? ToString()
        {
            return Nome + " " + Cognome;
        }

        #endregion
    }
}
