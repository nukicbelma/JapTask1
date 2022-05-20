using API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API._Services
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
