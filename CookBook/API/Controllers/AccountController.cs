using API._Services;
using API.Database;
using API.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly japtask1Context _context;
        private readonly ITokenService _tokenService;
        public AccountController(japtask1Context context, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _context = context;
        }

       

        //[HttpPost("login")]
        //public async Task<ActionResult<AppUserDto>> Login(LoginDto loginDto)
        //{
        //    var user = await _context.AppUsers
        //        .SingleOrDefaultAsync(x => x.Username == loginDto.username);

        //    if (user == null) return Unauthorized("Invalid username");

        //    using var hmac = new HMACSHA512(user.PasswordSalt);

        //    var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.password));

        //    for (int i = 0; i < computedHash.Length; i++)
        //    {
        //        if (computedHash[i] != user.PasswordHash[i]) return Unauthorized("Invalid password");
        //    }

        //    return new AppUserDto
        //    {
        //        Username = user.Username,
        //        Token = _tokenService.CreateToken(user)
        //    };
        //}

        private async Task<bool> UserExists(string username)
        {
            return await _context.AppUsers.AnyAsync(x => x.Username == username.ToLower());
        }
    }
}
