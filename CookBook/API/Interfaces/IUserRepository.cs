using API.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        Task<UserDto> Login(LoginDto model);
        Task<ActionResult<IEnumerable<UserDto>>> GetUsers();
    }
}
