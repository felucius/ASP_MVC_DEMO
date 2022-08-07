using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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

        public class AnimalDatabaseContext
        {
            public DbSet<Animal> Animals { get; set; }
        }
    }
}