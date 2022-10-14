using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Dtos.User
{
    public class AddUserDto
    {
        public int ID {get;set;}
        public string Name { get; set; } = string.Empty;
        public int Type { get; set; }
        public string Email { get; set; } = string.Empty;
        public int Phone {get; set;}
    }
}