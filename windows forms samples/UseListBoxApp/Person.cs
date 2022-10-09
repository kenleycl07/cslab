using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWindowsApp
{
    public class Person
    {
        private string name;
        private string address;
        private string city;
        private string zipcode;
        private string state;

        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }
        public string Address 
        { 
            get { return address; }
            set { address = value; }
        }
        public string City 
        { 
            get { return city; }
            set { city = value; }
        }
        public string ZipCode 
        { 
            get { return zipcode; }
            set { zipcode = value; }
        }
        public string State 
        { 
            get { return state; }
            set { state = value; }
        }

    }
}
