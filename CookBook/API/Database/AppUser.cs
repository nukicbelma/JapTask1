using System;
using System.Collections.Generic;

#nullable disable

namespace API.Database
{
    public partial class AppUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
