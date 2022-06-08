using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using P9.Server.Controllers;
using P9.Shared;

namespace P9.Server.DB
{
    public class ClotheProvider
    {
        private readonly ClotheDbContext _context;
        private readonly ILogger _logger;
        public ClotheProvider(ClotheDbContext context, ILoggerFactory loggerFactory)
        {
            this._context = context;
            this._logger = loggerFactory.CreateLogger("ClotheProvider");
        }

        public async Task AddCloth(Clothe clothe)
        {
            
            var lastClothe = this._context.Clothes.ToList().LastOrDefault();
            var newId = 0;
            if(!(lastClothe is null))
                newId = lastClothe.Id + 1;
            clothe.Id = newId;
            await _context.Clothes.AddAsync(clothe);
            await _context.SaveChangesAsync();
            
        }

        public List<Clothe> GetAllClothe()
            =>this._context.Clothes.ToList();

        public List<Clothe> RemoveClotheFromDb(int idd)
        {
            var clothe = this._context.Clothes.Where(c => c.Id==idd).FirstOrDefault();
            this._context.Clothes.Remove(clothe);
            this._context.SaveChanges();
            return this._context.Clothes.ToList();

        }

        internal void removefromdb(int id)
        {
            foreach (var item in _context.Clothes.ToList())
            {
                if (item.Id == id)
                {
                    _context.Clothes.Remove(item);
                }
            }
        }

        public void reduce(List<Clothe> b)
        {
            // Clothe a = _context.Clothes.Where(x=> x.Id == b.Id).FirstOrDefault();
            // a.count = a.count - 1;
            // _context.Clothes.Update(a);
            // _context.SaveChanges();
            
            _context.Clothes.UpdateRange(b);
            _context.SaveChanges();
        }
    }
}