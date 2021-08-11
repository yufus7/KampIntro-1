using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Odev3
{
    class Musteri
    {
        private int    id;
        private string name;
        private string lastName;

        public Musteri()
        {

        }

        public int Id { 
            get {
                return id;
            }
            set {
                 id=value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

    }
}
