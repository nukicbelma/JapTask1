using API.Database;
using API.DTOs;
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using FashionNova.WebAPI.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMapper _mapper;
        private readonly japtask1Context _context;

        public UserRepository(japtask1Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            var query = _context.AppUsers.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<UserDto>>(list);
        }

        public async Task<UserDto> Login(LoginDto model)
        {
            var entity = await _context.AppUsers.FirstOrDefaultAsync(x => x.Username == model.username);

            if (entity == null)
            {
                throw new UserException("Pogresan username ili password");
            }

            var hash = StringGenerators.GenerateHash(entity.PasswordSalt, model.password);

            if (hash != entity.PasswordHash)
            {
                throw new UserException("Pogresan username ili password");
            }
            return _mapper.Map<UserDto>(entity);
        }
    }
}
