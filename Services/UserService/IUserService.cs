using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto.Dtos.User;
using Proyecto.Models;

namespace Proyecto.Services.UserService
{
    public interface IUserService
    {
        Users GetUserByID( int id );
        List<Users> AddUser(Users newUser);
    }
}