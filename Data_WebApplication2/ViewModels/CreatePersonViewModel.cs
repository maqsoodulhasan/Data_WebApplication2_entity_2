using Data_WebApplication2.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data_WebApplication2.ViewModels
{
    public class CreatePersonViewModel
    {
        public int Id { get; set; }

        [Display(Name = "City")]
        public int CityId { get; set; }

        [Required]
        public string Name { get; set; }
        [MinLength(5)]
        public string PhoneNumber { get; set; }
        [MaxLength(10)]
        public List<City> Cities { get; set; }

    }
}
