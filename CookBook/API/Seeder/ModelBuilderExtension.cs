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
        }
    }
}
