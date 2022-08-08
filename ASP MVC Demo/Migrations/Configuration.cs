namespace ASP_MVC_Demo.Migrations
{
    using ASP_MVC_Demo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASP_MVC_Demo.Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ASP_MVC_Demo.Models.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Animals.RemoveRange(context.Animals);

            context.Animals.AddOrUpdate(animal => animal.ID,
                new Animal
                {
                    Age = 2,
                    Gender = AnimalGender.Male,
                    IsDomesticated = true,
                    Name = "Felix",
                    Price = 55,
                    ReleaseDate = DateTime.Parse("2020-01-02"),
                    Type = AnimalType.Cat,
                    CutenessRating = 9
                },

                new Animal
                {
                    Age = 6,
                    Gender = AnimalGender.Female,
                    IsDomesticated = true,
                    Name = "Polly",
                    Price = 255,
                    ReleaseDate = DateTime.Parse("2016-10-12"),
                    Type = AnimalType.Bird,
                    CutenessRating = 4
                },

                new Animal
                {
                    Age = 4,
                    Gender = AnimalGender.Male,
                    IsDomesticated = true,
                    Name = "Max",
                    Price = 140,
                    ReleaseDate = DateTime.Parse("2018-09-12"),
                    Type = AnimalType.Dog,
                    CutenessRating = 7
                },

                new Animal
                {
                    Age = 1,
                    Gender = AnimalGender.Female,
                    IsDomesticated = false,
                    Name = "Nemo",
                    Price = 5,
                    ReleaseDate = DateTime.Parse("2021-11-22"),
                    Type = AnimalType.Fish,
                    CutenessRating = 1
                });
        }
    }
}
