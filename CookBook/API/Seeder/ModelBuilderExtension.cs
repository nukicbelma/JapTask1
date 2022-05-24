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
            for (int i = 0; i < 5; i++)
            {
                Salt.Add(StringGenerators.GenerateSalt());
            }

            #region Dodavanje korisnika 
            //AppUsers
            modelBuilder.Entity<User>().HasData(
            new User()
            {
                Id = 1,
                Firstname = "Belma",
                Lastname = "Nukic",
                Username = "belma",
                PasswordSalt = Salt[0],
                PasswordHash = StringGenerators.GenerateHash(Salt[0], "belma"),
            },
            new User()
            {
                Id = 2,
                Firstname = "Ema",
                Lastname = "Bojcic",
                Username = "ema",
                PasswordSalt = Salt[0],
                PasswordHash = StringGenerators.GenerateHash(Salt[0], "ema"),
            });
            #endregion

            #region Dodavanje categorija
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Pancakes"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Waffles"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Pizzas"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Burgers"
                },
                new Category()
                {
                    Id = 5,
                    Name = "Gluten-free"
                },
                new Category()
                {
                    Id = 6,
                    Name = "Pasta"
                },
                new Category()
                {
                    Id = 7,
                    Name = "Seafood"
                },
                new Category()
                {
                    Id = 8,
                    Name = "Salads"
                },
                new Category()
                {
                    Id = 9,
                    Name = "Soups"
                },
                new Category()
                {
                    Id = 10,
                    Name = "Breakfast"
                },
                new Category()
                {
                    Id = 11,
                    Name = "testpaging1"
                },
                 new Category()
                 {
                     Id = 12,
                     Name = "testpaging2"
                 }
                );
            #endregion

            #region Dodavanje sastojaka
            modelBuilder.Entity<Ingredient>().HasData(
               new Ingredient()
               {
                   Id = 1,
                   Name = "Flour",
                   PurchasePrice = 30,
                   PurchaseAmount = 20,
                   PurchaseMeasure = EnumUnits.kg
               },
               new Ingredient()
               {
                   Id = 2,
                   Name = "Eggs",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = EnumUnits.kom
               },
               new Ingredient()
               {
                   Id = 3,
                   Name = "Milk",
                   PurchasePrice = 10,
                   PurchaseAmount = 8,
                   PurchaseMeasure = EnumUnits.l
               },
               new Ingredient()
               {
                   Id = 4,
                   Name = "Chicken",
                   PurchasePrice = 50,
                   PurchaseAmount = 5,
                   PurchaseMeasure = EnumUnits.kg
               },
               new Ingredient()
               {
                   Id = 5,
                   Name = "Beef",
                   PurchasePrice = 45,
                   PurchaseAmount = 3,
                   PurchaseMeasure = EnumUnits.kg
               },
               new Ingredient()
               {
                   Id = 6,
                   Name = "Salt",
                   PurchasePrice = 5,
                   PurchaseAmount = 5,
                   PurchaseMeasure = EnumUnits.kg
               },
               new Ingredient()
               {
                   Id = 7,
                   Name = "Vegeta",
                   PurchasePrice = 5,
                   PurchaseAmount = 500,
                   PurchaseMeasure = EnumUnits.g
               },
               new Ingredient()
               {
                   Id = 8,
                   Name = "Cheese",
                   PurchasePrice = 20,
                   PurchaseAmount = 2,
                   PurchaseMeasure = EnumUnits.kg
               },
               new Ingredient()
               {
                   Id = 9,
                   Name = "GreekYogurt",
                   PurchasePrice = 2,
                   PurchaseAmount = 2,
                   PurchaseMeasure = EnumUnits.l
               },
               new Ingredient()
               {
                   Id = 10,
                   Name = "Butter",
                   PurchasePrice = 20,
                   PurchaseAmount = 5,
                   PurchaseMeasure = EnumUnits.kg
               }
               );
            #endregion

            #region Dodavanje recepata

            modelBuilder.Entity<Recipe>().HasData(
              new Recipe()
              {
                  Id = 1,
                  CategoryId = 3,
                  Name = "Vegetarina",
                  Description = "This is a demo.",
                  TotalPrice = 15
              },
               new Recipe()
               {
                   Id = 2,
                   CategoryId = 3,
                   Name = "Fungi",
                   Description = "This is a demo part2. ",
                   TotalPrice = 19
               },
                new Recipe()
                {
                    Id = 3,
                    CategoryId = 1,
                    Name = "Ferero",
                    Description = "This is a demo3",
                    TotalPrice = 10
                },
                 new Recipe()
                 {
                     Id = 4,
                     CategoryId = 1,
                     Name = "Protein pancake",
                     Description = "This is a demo4",
                     TotalPrice = 14
                 }
                   );
            #endregion

            #region Dodavanje recipeDetails

            modelBuilder.Entity<RecipeDetail>().HasData(
              new RecipeDetail()
              {
                  Id = 1,
                  RecipeId = 1,
                  IngredientId = 1,
                  Measure = EnumUnits.g,
                  Amount = 3,
                  Price = 5
              },
               new RecipeDetail()
               {
                   Id = 2,
                   RecipeId = 1,
                   IngredientId = 2,
                   Measure = EnumUnits.g,
                   Amount = 2,
                   Price = 2
               },
                new RecipeDetail()
                {
                    Id = 3,
                    RecipeId = 1,
                    IngredientId = 3,
                    Measure = EnumUnits.ml,
                    Amount = 2,
                    Price = 3
                },
                 new RecipeDetail()
                 {
                     Id = 4,
                     RecipeId = 2,
                     IngredientId = 1,
                     Measure = EnumUnits.g,
                     Amount = 3,
                     Price = 3
                 },
                  new RecipeDetail()
                  {
                      Id = 5,
                      RecipeId = 2,
                      IngredientId = 1,
                      Measure = EnumUnits.g,
                      Amount = 3,
                      Price = 3
                  },
                   new RecipeDetail()
                   {
                       Id = 6,
                       RecipeId = 2,
                       IngredientId = 5,
                       Measure = EnumUnits.ml,
                       Amount = 4,
                       Price = 7
                   },
                    new RecipeDetail()
                    {
                        Id = 7,
                        RecipeId = 3,
                        IngredientId = 1,
                        Measure = EnumUnits.ml,
                        Amount = 4,
                        Price = 2
                    },
                     new RecipeDetail()
                     {
                         Id = 8,
                         RecipeId = 3,
                         IngredientId = 1,
                         Measure = EnumUnits.ml,
                         Amount = 4,
                         Price = 4
                     },
                      new RecipeDetail()
                      {
                          Id = 9,
                          RecipeId = 3,
                          IngredientId = 4,
                          Measure = EnumUnits.l,
                          Amount = 2,
                          Price = 2
                      },
                       new RecipeDetail()
                       {
                           Id = 10,
                           RecipeId = 4,
                           IngredientId = 1,
                           Measure = EnumUnits.ml,
                           Amount = 3,
                           Price = 3
                       },
                        new RecipeDetail()
                        {
                            Id = 11,
                            RecipeId = 4,
                            IngredientId = 3,
                            Measure = EnumUnits.ml,
                            Amount = 3,
                            Price = 2
                        },
                         new RecipeDetail()
                         {
                             Id = 12,
                             RecipeId = 4,
                             IngredientId = 4,
                             Measure = EnumUnits.ml,
                             Amount = 7,
                             Price = 4
                         }
                         );
            #endregion
        }
    }
}

