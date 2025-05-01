using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaJson.Models
{
    internal class Developer
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _location;

		public string Location
		{
			get { return _location; }
			set { _location = value; }
		}

        public Developer ( string name, string location )
        {
            Name = name;
            Location = location;
        }

        public Developer ( string name )
        {
            Name = name;
        }

        public override string? ToString ( )
        {
            return Name;
        }
    }
}
