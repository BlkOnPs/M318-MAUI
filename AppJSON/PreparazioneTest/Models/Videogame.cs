using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparazioneTest.Models
{
    internal class Videogame
    {
		private string _title;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		private string _commento;

		public string Commento
		{
			get { return _commento; }
			set { _commento = value; }
		}

		private string _image;

		public string Image
		{
			get { return _image; }
			set { _image = value; }
		}

        public Videogame ( string title, string name, string description, string image )
        {
            Title = title;
            Name = name;
            Description = description;
            Image = image;
        }

		public Videogame ( ) { }

        public override bool Equals ( object? obj )
        {
			return obj is Videogame videogame &&
				Title == videogame.Title &&
				Name == videogame.Name &&
				Description == videogame.Description &&
				Image == videogame.Image;
        }

        public override int GetHashCode ( )
        {
			return HashCode.Combine (Title, Name, Description);
        }

        public override string? ToString ( )
        {
            return Title + " - " + Name;
        }
    }
}
