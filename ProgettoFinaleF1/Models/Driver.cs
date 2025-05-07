using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoFinaleF1.Models
{
    class Driver
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        private string _nationality;
        public string Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }

        private string _team;
        public string Team
        {
            get { return _team; }
            set { _team = value; }
        }

        private int _racesWon;
        public int RacesWon
        {
            get { return _racesWon; }
            set { _racesWon = value; }
        }

        private int _championships;
        public int Championships
        {
            get { return _championships; }
            set { _championships = value; }
        }

        private string _helmetImage;
        public string HelmetImage
        {
            get { return _helmetImage; }
            set { _helmetImage = value; }
        }

        private string _numberImage;
        public string NumberImage
        {
            get { return _numberImage; }
            set { _numberImage = value; }
        }

        private string _driverImage;
        public string DriverImage
        {
            get { return _driverImage; }
            set { _driverImage = value; }
        }

        public Driver ( string firstName, string lastName, DateTime birthDate, 
            string nationality, string team, int racesWon, int championships, 
            string helmetImage, string numberImage, string driverImage )
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Nationality = nationality;
            Team = team;
            RacesWon = racesWon;
            Championships = championships;
            HelmetImage = helmetImage;
            NumberImage = numberImage;
            DriverImage = driverImage;
        }

        public override string? ToString ( )
        {
            return LastName + " - " + Team;
        }
    }
}
