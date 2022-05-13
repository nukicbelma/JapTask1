using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using API.Repositories;
using API.Database;
using API.Helpers;

namespace API.Seeder
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<string> Salt = new List<string>();
            for (int i = 0; i< 5; i++)
            {
                Salt.Add(StringGenerators.GenerateSalt());
            }

                #region Dodavanje korisnika 
                //AppUsers
                modelBuilder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    AppUserId = 1,
                    FirstName = "Belma",
                    LastName = "Nukic",
                    Username = "belma",
                    PasswordSalt = Salt[0],
                    PasswordHash = StringGenerators.GenerateHash(Salt[0], "belma"),
                },
                new AppUser()
                {
                    AppUserId = 2,
                    FirstName = "Ema",
                    LastName = "Bojcic",
                    Username = "ema",
                    PasswordSalt = Salt[0],
                    PasswordHash = StringGenerators.GenerateHash(Salt[0], "ema"),
                });
            #endregion

            #region Dodavanje categorija
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Pancakes"
                },
                new Category()
                {
                      CategoryId = 2,
                      CategoryName = "Waffles"
                },
                new Category()
                {
                     CategoryId = 3,
                     CategoryName = "Pizzas"
                },
                new Category()
                {
                      CategoryId = 4,
                      CategoryName = "Burgers"
                },
                new Category()
                {
                       CategoryId = 5,
                       CategoryName = "Gluten-free"
                },
                new Category()
                {
                    CategoryId = 6,
                    CategoryName = "Pasta"
                },
                new Category()
                {
                    CategoryId = 7,
                    CategoryName = "Seafood"
                },
                new Category()
                {
                     CategoryId = 8,
                     CategoryName = "Salads"
                },
                new Category()
                {
                    CategoryId = 9,
                    CategoryName = "Soups"
                },
                new Category()
                {
                     CategoryId = 10,
                     CategoryName = "Breakfast"
                }
                //new Category()
                //{
                //             CategoryId = 11,
                //             CategoryName = "Bosnian traditional food"
                //}
                );
            #endregion

            #region Dodavanje sastojaka
            modelBuilder.Entity<Ingredient>().HasData(
               new Ingredient()
               {
                   IngredientId = 1,
                   Name = "Flour",
                   Price = 30,
                   Quantity = 20,
                   //UnitMeasure= 'kg'
               }
               );
            #endregion
        }
    }
}
