using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniseTier
{
    public class Person
    {
        public string Name { get; set; }
        public string City { get; set; }
        public Person(string name, string city)
        {
            Name = name;
            City = city;


        }
        
        public virtual string GetPersonInfo()
        {
            return $" Name : {Name}  City : {City}";
        }
    }
}
