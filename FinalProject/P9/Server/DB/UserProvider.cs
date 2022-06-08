using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using P9.Server.Controllers;
using P9.Shared;

namespace P9.Server.DB
{
    public class UserProvider
    {
        private readonly UserDbContext _context;
        private readonly ILogger _logger;
        public UserProvider(UserDbContext context, ILoggerFactory loggerFactory)
        {
            this._context = context;
            this._logger = loggerFactory.CreateLogger("UserProvider");
        }

        public async Task CreateUser(User user)
        {
            var lastUser = this._context.Users.OrderBy(x=>x.ID).LastOrDefault();
            // var lastid = this._context.Users.Select(c=>c.ID).Max();
            var newId = 0;
            if(!(lastUser is null))
                newId = lastUser.ID + 1;
            user.ID = newId; 
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            // _context.UpdateRange();
        }

        public List<User> deleteuser(int id)
        {
            var user  = this._context.Users.Where(c => c.ID==id).FirstOrDefault();
            this._context.Users.Remove(user);
            this._context.SaveChanges();
            return this._context.Users.ToList();
        }

        public User getlast()
        {
            User f =this._context.Users.OrderBy(x=>x.ID).LastOrDefault();
            return f;
        }

        public List<User> GetAllUser()
        {
            return this._context.Users.ToList();
        }
        

        internal void edituser(User user)
        {
            foreach (var item in _context.Users.ToList())
            {
                if (item.ID == user.ID)
                {
                    item.ID = user.ID;
                    item.LastName = user.LastName;
                    item.FirstName = user.FirstName;
                }
            }
        }

        public User loaduser(User user)
        {
            User ab = null;
            foreach (var item in _context.Users.ToList())
            {
                if (item.ID == user.ID)
                {
                    ab = item;
                }
            }
            return ab;

        }
    }
}
