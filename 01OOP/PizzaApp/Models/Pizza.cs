using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Models
{
    internal class Pizza
    {
        private string _nome;
        private float _prezzo;
        private string _image;
        private string _ingredienti;
        private int _valuta;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public float Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public string Ingredienti
        {
            get { return _ingredienti; }
            set { _ingredienti = value; }
        }

        public int Valuta
        {
            get { return _valuta; }
            set { _valuta = value; }
        }

        public Pizza(string nome, float prezzo, string image, string ingredienti)
        {
            Nome = nome;
            Prezzo = prezzo;
            Image = image;
            Ingredienti = ingredienti;
            Valuta = 0;
        }

        public override string? ToString()
        {
            return Nome;
        }
    }
}
