using Data_WebApplication2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_WebApplication2
{
    public class MyDbRepository : IMyDbRepository
    {
        private readonly MyDbContext _context;

        public MyDbRepository(MyDbContext context)
        {
            _context = context;
        }
        public List<Person> GetPersons()
        {
            return _context.Persons.Include(j => j.City).ToList();
        }

        public Person GetPersonById(int id)
        {
            return _context.Persons.Include(j => j.City).Where(x => x.Id == id).FirstOrDefault();
        }
        
        public void AddPerson(Person person)
        {
            _context.Persons.Add(person);
        }
        
        public void UpdatePerson(Person person)
        {
            _context.Persons.Update(person);
        }
        
        public void DeletePerson(Person person)
        {
            _context.Persons.Remove(person);
        }

        public List<City> GetCititesByCountryId(int id)
        {
            return _context.City.Where(x=>x.CountryId==id).ToList();
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}