using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_WebApplication2.Models
{
    public class City
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public List<Person> Person { get; set; }

        public City()
        {
            Person = new List<Person>();
        }
    }
}
