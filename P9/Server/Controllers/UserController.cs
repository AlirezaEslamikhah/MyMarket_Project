using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P9.Server.DB;
using P9.Shared;


namespace P9.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserProvider _provider;

        public UserController(UserProvider a)
        {
            _provider = a;
        }

        [HttpPost]
        [Route("createuser")]
        public async Task<User> CreateUser(User user)
        {
            await this._provider.CreateUser(user);
            return user;
        }
        
        [HttpGet]
        [Route("getusers")]
        public List<User> GetAllUserInDb()
            => this._provider.GetAllUser();
        
        [HttpDelete]
        [Route("deleteuser")]        
        public List<User> deleteuser(int id)=>
        this._provider.deleteuser(id);

        [HttpGet]
        [Route("getlastuser")]

        public User getlast()
        {
            User f =this._provider.getlast();
            return f;
        }
        
    }
}