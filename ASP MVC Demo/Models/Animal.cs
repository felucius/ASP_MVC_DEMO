using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Demo.Models
{
    public class Animal
    {
        public int ID { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public AnimalType Type { get; set; }

        public AnimalGender Gender { get; set; }

        public bool IsDomesticated { get; set; }

        public int Price { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        public int CutenessRating { get; set; }
    }
}