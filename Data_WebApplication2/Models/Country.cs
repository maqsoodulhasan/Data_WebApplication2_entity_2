using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_WebApplication2.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<City> Cities { get; set; }

        public Country()
        {
            Cities = new List<City>();
        }
    }
}
