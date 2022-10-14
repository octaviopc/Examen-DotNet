using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Proyecto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<Users> users = new List<Users>{
            new Users{Name = "Tavo"},
            new Users{ID=1, Name = "Arturo"}
        };

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<Users> Get()
        {
            return Ok(users);
        }

        [HttpGet("id")]
        public ActionResult<Users> GetSingle(int id)
        {
            return Ok(users.FirstOrDefault(c => c.ID == id));
        }

        [HttpPost]
        public ActionResult<List<Users>> AddUser(Users newUser)
        {
            users.Add(newUser);
            return Ok(users);
        }
    }
}