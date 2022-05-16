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
                },
                new Category()
                {
                    CategoryId = 11,
                    CategoryName = "testpaging1"
                },
                 new Category()
                 {
                     CategoryId = 12,
                     CategoryName = "testpaging2"
                 }
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
                   UnitMeasure = "kg"
               },
               new Ingredient()
               {
                   IngredientId = 2,
                   Name = "Eggs",
                   Price = 10,
                   Quantity = 20,
                   UnitMeasure = "kom"
               },
               new Ingredient()
               {
                   IngredientId = 3,
                   Name = "Milk",
                   Price = 10,
                   Quantity = 8,
                   UnitMeasure = "l"
               },
               new Ingredient()
               {
                   IngredientId = 4,
                   Name = "Chicken",
                   Price = 50,
                   Quantity = 5,
                   UnitMeasure = "kg"
               },
               new Ingredient()
               {
                   IngredientId = 5,
                   Name = "Beef",
                   Price = 45,
                   Quantity = 3,
                   UnitMeasure = "kg"
               },
               new Ingredient()
               {
                   IngredientId = 6,
                   Name = "Salt",
                   Price = 5,
                   Quantity = 5,
                   UnitMeasure = "kg"
               },
               new Ingredient()
               {
                   IngredientId = 7,
                   Name = "Vegeta",
                   Price = 5,
                   Quantity = 500,
                   UnitMeasure = "g"
               },
               new Ingredient()
               {
                   IngredientId = 8,
                   Name = "Cheese",
                   Price = 20,
                   Quantity = 2,
                   UnitMeasure = "kg"
               },
               new Ingredient()
               {
                   IngredientId = 9,
                   Name = "GreekYogurt",
                   Price = 2,
                   Quantity = 2,
                   UnitMeasure = "l"
               },
               new Ingredient()
               {
                   IngredientId = 10,
                   Name = "Butter",
                   Price = 20,
                   Quantity = 5,
                   UnitMeasure = "kg"
               }
               );
            #endregion

            #region Dodavanje recepata

            modelBuilder.Entity<Recipe>().HasData(
              new Recipe()
              {
                  RecipeId = 1,
                  CategoryId = 3,
                  RecipeName = "Vegetarina",
                  Description = "This is a demo.",
                  TotalPrice = 15
              },
               new Recipe()
               {
                   RecipeId = 2,
                   CategoryId = 3,
                   RecipeName = "Fungi",
                   Description = "This is a demo part2. ",
                   TotalPrice = 19
               },
                new Recipe()
                {
                    RecipeId = 3,
                    CategoryId = 1,
                    RecipeName = "Ferero",
                    Description = "This is a demo3",
                    TotalPrice = 10
                },
                 new Recipe()
                 {
                     RecipeId = 4,
                     CategoryId = 1,
                     RecipeName = "Protein pancake",
                     Description = "This is a demo4",
                     TotalPrice = 14
                 }
                   );
            #endregion

            #region Dodavanje recipeDetails

            modelBuilder.Entity<RecipeDetail>().HasData(
              new RecipeDetail()
              {
                  RecipteDetailId = 1,
                  RecipeId = 1,
                  IngredientId = 1,
                  UnitMeasure = "g",
                  Amount = 3,
                  Price = 5
              },
               new RecipeDetail()
               {
                   RecipteDetailId = 2,
                   RecipeId = 1,
                   IngredientId = 2,
                   UnitMeasure = "l",
                   Amount = 2,
                   Price = 2
               },
                new RecipeDetail()
                {
                    RecipteDetailId = 3,
                    RecipeId = 1,
                    IngredientId = 3,
                    UnitMeasure = "ml",
                    Amount = 2,
                    Price = 3
                },
                 new RecipeDetail()
                 {
                     RecipteDetailId = 4,
                     RecipeId = 2,
                     IngredientId = 1,
                     UnitMeasure = "g",
                     Amount = 3,
                     Price = 3
                 },
                  new RecipeDetail()
                  {
                      RecipteDetailId = 5,
                      RecipeId = 2,
                      IngredientId = 1,
                      UnitMeasure = "g",
                      Amount = 3,
                      Price = 3
                  },
                   new RecipeDetail()
                   {
                       RecipteDetailId = 6,
                       RecipeId = 2,
                       IngredientId = 5,
                       UnitMeasure = "ml",
                       Amount = 4,
                       Price = 7
                   },
                    new RecipeDetail()
                    {
                        RecipteDetailId = 7,
                        RecipeId = 3,
                        IngredientId = 1,
                        UnitMeasure = "ml",
                        Amount = 4,
                        Price = 2
                    },
                     new RecipeDetail()
                     {
                         RecipteDetailId = 8,
                         RecipeId = 3,
                         IngredientId = 1,
                         UnitMeasure = "ml",
                         Amount = 4,
                         Price = 4
                     },
                      new RecipeDetail()
                      {
                          RecipteDetailId = 9,
                          RecipeId = 3,
                          IngredientId = 4,
                          UnitMeasure = "l",
                          Amount = 2,
                          Price = 2
                      },
                       new RecipeDetail()
                       {
                           RecipteDetailId = 10,
                           RecipeId = 4,
                           IngredientId = 1,
                           UnitMeasure = "ml",
                           Amount = 3,
                           Price = 3
                       },
                        new RecipeDetail()
                        {
                            RecipteDetailId = 11,
                            RecipeId = 4,
                            IngredientId = 3,
                            UnitMeasure = "ml",
                            Amount = 3,
                            Price = 2
                        },
                         new RecipeDetail()
                         {
                             RecipteDetailId = 12,
                             RecipeId = 4,
                             IngredientId = 4,
                             UnitMeasure = "ml",
                             Amount = 7,
                             Price = 4
                         }
                         );
            #endregion
        }
    }
}

