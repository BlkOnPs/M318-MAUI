using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGames.Models
{
    internal class Developer
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _address;

		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

        public override string? ToString()
        {
			return Name + ";" + Address ;
        }

        public Developer(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
