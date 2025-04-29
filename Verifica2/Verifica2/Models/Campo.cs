using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica2.Models
{
    internal class Campo
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

        private string _indirizzo;

        public string Indirizzo
        {
            get { return _indirizzo; }
            set { _indirizzo = value; }
        }

        private int _nap;

        public int NAP
        {
            get { return _nap; }
            set { _nap = value; }
        }

        private string _citta;

        public string Citta
        {
            get { return _citta; }
            set { _citta = value; }
        }

        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _link;

        public string Link
        {
            get { return _link; }
            set { _link = value; }
        }

        private Responsabile _responsabile;

        public Responsabile Responsabile
        {
            get { return _responsabile; }
            set { _responsabile = value; }
        }

        private bool _preferito;

        public bool Preferito
        {
            get { return _preferito; }
            set { _preferito = value; }
        }

        private string _pathImm;

        public string PathImm
        {
            get { return _pathImm; }
            set { _pathImm = value; }
        }

        private string _commento;

        public string Commento
        {
            get { return _commento; }
            set { _commento = value; }
        }

        #endregion

        #region =03=== costruttori =======================ctor==

        public Campo(string nome, string indirizzo, int nAP, string citta, string telefono, string link, Responsabile responsabile, string pathImm)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            NAP = nAP;
            Citta = citta;
            Telefono = telefono;
            Link = link;
            Responsabile = responsabile;
            PathImm = pathImm;
        }

        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================

        public override string? ToString()
        {
            return Nome + " - " + NAP + " " + Citta;
        }

        #endregion
    }
}
