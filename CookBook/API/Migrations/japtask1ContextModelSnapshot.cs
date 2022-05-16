﻿// <auto-generated />
using API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(japtask1Context))]
    partial class japtask1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Bosnian_Latin_100_BIN")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Database.AppUser", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("AppUserId");

                    b.ToTable("AppUser");

                    b.HasData(
                        new
                        {
                            AppUserId = 1,
                            FirstName = "Belma",
                            LastName = "Nukic",
                            PasswordHash = "JEFVxkJOeCd2ogmegwtWx+ll3Zs=",
                            PasswordSalt = "I9RlltY0zRVbFv3/0kT7rw==",
                            Username = "belma"
                        },
                        new
                        {
                            AppUserId = 2,
                            FirstName = "Ema",
                            LastName = "Bojcic",
                            PasswordHash = "Cfqcj9ysZmaAxARUowPltYXl09s=",
                            PasswordSalt = "I9RlltY0zRVbFv3/0kT7rw==",
                            Username = "ema"
                        });
                });

            modelBuilder.Entity("API.Database.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Pancakes"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Waffles"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Pizzas"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Burgers"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Gluten-free"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Pasta"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Seafood"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Salads"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Soups"
                        },
                        new
                        {
                            CategoryId = 10,
                            CategoryName = "Breakfast"
                        },
                        new
                        {
                            CategoryId = 11,
                            CategoryName = "testpaging1"
                        },
                        new
                        {
                            CategoryId = 12,
                            CategoryName = "testpaging2"
                        });
                });

            modelBuilder.Entity("API.Database.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UnitMeasure")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredient");

                    b.HasData(
                        new
                        {
                            IngredientId = 1,
                            Name = "Flour",
                            Price = 30m,
                            Quantity = 20,
                            UnitMeasure = "kg"
                        },
                        new
                        {
                            IngredientId = 2,
                            Name = "Eggs",
                            Price = 10m,
                            Quantity = 20,
                            UnitMeasure = "kom"
                        },
                        new
                        {
                            IngredientId = 3,
                            Name = "Milk",
                            Price = 10m,
                            Quantity = 8,
                            UnitMeasure = "l"
                        },
                        new
                        {
                            IngredientId = 4,
                            Name = "Chicken",
                            Price = 50m,
                            Quantity = 5,
                            UnitMeasure = "kg"
                        },
                        new
                        {
                            IngredientId = 5,
                            Name = "Beef",
                            Price = 45m,
                            Quantity = 3,
                            UnitMeasure = "kg"
                        },
                        new
                        {
                            IngredientId = 6,
                            Name = "Salt",
                            Price = 5m,
                            Quantity = 5,
                            UnitMeasure = "kg"
                        },
                        new
                        {
                            IngredientId = 7,
                            Name = "Vegeta",
                            Price = 5m,
                            Quantity = 500,
                            UnitMeasure = "g"
                        },
                        new
                        {
                            IngredientId = 8,
                            Name = "Cheese",
                            Price = 20m,
                            Quantity = 2,
                            UnitMeasure = "kg"
                        },
                        new
                        {
                            IngredientId = 9,
                            Name = "GreekYogurt",
                            Price = 2m,
                            Quantity = 2,
                            UnitMeasure = "l"
                        },
                        new
                        {
                            IngredientId = 10,
                            Name = "Butter",
                            Price = 20m,
                            Quantity = 5,
                            UnitMeasure = "kg"
                        });
                });

            modelBuilder.Entity("API.Database.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RecipeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipe");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            CategoryId = 3,
                            Description = "This is a demo.",
                            RecipeName = "Vegetarina",
                            TotalPrice = 15m
                        },
                        new
                        {
                            RecipeId = 2,
                            CategoryId = 3,
                            Description = "This is a demo part2. ",
                            RecipeName = "Fungi",
                            TotalPrice = 19m
                        },
                        new
                        {
                            RecipeId = 3,
                            CategoryId = 1,
                            Description = "This is a demo3",
                            RecipeName = "Ferero",
                            TotalPrice = 10m
                        },
                        new
                        {
                            RecipeId = 4,
                            CategoryId = 1,
                            Description = "This is a demo4",
                            RecipeName = "Protein pancake",
                            TotalPrice = 14m
                        });
                });

            modelBuilder.Entity("API.Database.RecipeDetail", b =>
                {
                    b.Property<int>("RecipteDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("UnitMeasure")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("RecipteDetailId")
                        .HasName("PK__RecipeDe__C8C9B68C715ACE4B");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeDetail");

                    b.HasData(
                        new
                        {
                            RecipteDetailId = 1,
                            Amount = 3,
                            IngredientId = 1,
                            Price = 5m,
                            RecipeId = 1,
                            UnitMeasure = "g"
                        },
                        new
                        {
                            RecipteDetailId = 2,
                            Amount = 2,
                            IngredientId = 2,
                            Price = 2m,
                            RecipeId = 1,
                            UnitMeasure = "l"
                        },
                        new
                        {
                            RecipteDetailId = 3,
                            Amount = 2,
                            IngredientId = 3,
                            Price = 3m,
                            RecipeId = 1,
                            UnitMeasure = "ml"
                        },
                        new
                        {
                            RecipteDetailId = 4,
                            Amount = 3,
                            IngredientId = 1,
                            Price = 3m,
                            RecipeId = 2,
                            UnitMeasure = "g"
                        },
                        new
                        {
                            RecipteDetailId = 5,
                            Amount = 3,
                            IngredientId = 1,
                            Price = 3m,
                            RecipeId = 2,
                            UnitMeasure = "g"
                        },
                        new
                        {
                            RecipteDetailId = 6,
                            Amount = 4,
                            IngredientId = 5,
                            Price = 7m,
                            RecipeId = 2,
                            UnitMeasure = "ml"
                        },
                        new
                        {
                            RecipteDetailId = 7,
                            Amount = 4,
                            IngredientId = 1,
                            Price = 2m,
                            RecipeId = 3,
                            UnitMeasure = "ml"
                        },
                        new
                        {
                            RecipteDetailId = 8,
                            Amount = 4,
                            IngredientId = 1,
                            Price = 4m,
                            RecipeId = 3,
                            UnitMeasure = "ml"
                        },
                        new
                        {
                            RecipteDetailId = 9,
                            Amount = 2,
                            IngredientId = 4,
                            Price = 2m,
                            RecipeId = 3,
                            UnitMeasure = "l"
                        },
                        new
                        {
                            RecipteDetailId = 10,
                            Amount = 3,
                            IngredientId = 1,
                            Price = 3m,
                            RecipeId = 4,
                            UnitMeasure = "ml"
                        },
                        new
                        {
                            RecipteDetailId = 11,
                            Amount = 3,
                            IngredientId = 3,
                            Price = 2m,
                            RecipeId = 4,
                            UnitMeasure = "ml"
                        },
                        new
                        {
                            RecipteDetailId = 12,
                            Amount = 7,
                            IngredientId = 4,
                            Price = 4m,
                            RecipeId = 4,
                            UnitMeasure = "ml"
                        });
                });

            modelBuilder.Entity("API.Database.Recipe", b =>
                {
                    b.HasOne("API.Database.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("API.Database.RecipeDetail", b =>
                {
                    b.HasOne("API.Database.Ingredient", "Ingredient")
                        .WithMany("RecipeDetails")
                        .HasForeignKey("IngredientId")
                        .HasConstraintName("fk_ingredient")
                        .IsRequired();

                    b.HasOne("API.Database.Recipe", "Recipe")
                        .WithMany("RecipeDetails")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("fk_recipeId")
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("API.Database.Category", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("API.Database.Ingredient", b =>
                {
                    b.Navigation("RecipeDetails");
                });

            modelBuilder.Entity("API.Database.Recipe", b =>
                {
                    b.Navigation("RecipeDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
