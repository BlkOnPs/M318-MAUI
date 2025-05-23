﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGames.Models
{
    internal class Videogame
    {
		private string _title;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private Developer _developer;

		public Developer  Developer
		{
			get { return _developer; }
			set { _developer = value; }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		private string _comment;

		public string Comment
		{
			get { return _comment; }
			set { _comment = value; }
		}

		private string _image;

		public string Image
		{
			get { return _image; }
			set { _image = value; }
		}

        public Videogame(string title, Developer developer, string description, string image)
        {
            Title = title;
            Developer = developer;
            Description = description;
            Image = image;
        }

        public override string? ToString()
        {
            return Title + " - " + Developer.Name;
        }
    }
}
