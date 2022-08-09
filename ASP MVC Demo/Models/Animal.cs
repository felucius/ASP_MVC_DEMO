using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Demo.Models
{
    public class Animal
    {
        public int ID { get; set; }

        [Range(1, 15)]
        public int Age { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [StringLength(25, MinimumLength = 2)]
        public string Name { get; set; }

        public AnimalType Type { get; set; }

        public AnimalGender Gender { get; set; }

        public bool IsDomesticated { get; set; }

        [Range(1, 300)]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 10)]
        public int CutenessRating { get; set; }
    }
}