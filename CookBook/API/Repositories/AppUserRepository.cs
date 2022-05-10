using API.Database;
using API.DTOs;
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using FashionNova.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly IMapper _mapper;
        private readonly japtask1Context _context;

        public AppUserRepository(japtask1Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<AppUserDto> GetUsers()
        {
            var query = _context.AppUsers.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<AppUserDto>>(list);
        }
        public AppUserDto Authenticiraj(string username, string pass)
        {
            var user = _context.AppUsers.FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var hashedPass = StringGenerators.GenerateHash(user.PasswordSalt, pass);

                if (hashedPass == user.PasswordHash)
                {
                    AppUserDto novikorisnik = new AppUserDto();

                    novikorisnik.AppUserId = user.AppUserId;
                    novikorisnik.FirstName = user.FirstName;
                    novikorisnik.LastName = user.LastName;
                    novikorisnik.Username = user.Username;
                    novikorisnik.PasswordHash = user.PasswordHash;
                    novikorisnik.PasswordSalt = user.PasswordSalt;

                    return novikorisnik;
                }
            }
            return null;
        }
        public async Task<AppUserDto> Login(string username, string password)
        {
            var entity = await _context.AppUsers.FirstOrDefaultAsync(x => x.Username == username);

            if (entity == null)
            {
                throw new UserException("Pogresan username ili password");
            }

            var hash = StringGenerators.GenerateHash(entity.PasswordSalt, password);

            if (hash != entity.PasswordHash)
            {
                throw new UserException("Pogresan username ili password");
            }
            return _mapper.Map<AppUserDto>(entity);
        }
    }
}
