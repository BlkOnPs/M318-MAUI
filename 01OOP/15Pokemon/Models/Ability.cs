using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Pokemon.Models
{
    internal class Ability
    {
		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}


		private string _type;

		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}

        public Ability ( string description, string type )
        {
            Description = description;
            Type = type;
        }

        public override string? ToString ( )
        {
            return Type + "\n" + Description;
        }

    }
}
