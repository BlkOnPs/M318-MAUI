using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Pokemon.Models
{
    internal class Pokemon
    {
		private List<Ability> _abilities;

		public List<Ability> Abilities
		{
			get { return _abilities; }
			set { _abilities = value; }
		}

		private string _category;

		public string Category
		{
			get { return _category; }
			set { _category = value; }
		}


		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		private float _height;

		public float Height
		{
			get { return _height; }
			set { _height = value; }
		}

		private string _imagePath;

		public string ImagePath
		{
			get { return _imagePath; }
			set { _imagePath = value; }
		}


		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private double _points;

		public double Points
		{
			get { return _points; }
			set { _points = value; }
		}

		private string _type;

		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}

		private float _weight;

		public float Weight
		{
			get { return _weight; }
			set { _weight = value; }
		}

        public void AddAbility ( Ability ability )
        {
            _abilities.Add (ability);
        }


        public Pokemon ( string name, float height, float weight, string type, string imagePath,
            string description, string category )
        {
            _name = name;
            if (height <= 0 || weight <= 0)
            {
                //Gestione personalizzata dell'eccezione in caso di immissione di valori negativi
                throw new ArgumentOutOfRangeException ("Valori immessi non validi");
            }
            _height = height;
            _weight = weight;
            _type = type;
            _imagePath = imagePath;
            _description = description;
            _category = category;
            _points = 0;
            _abilities = new List<Ability> ();
        }


        public override string? ToString ( )
        {
            return Name + " - " + Type;
        }
    }
}
