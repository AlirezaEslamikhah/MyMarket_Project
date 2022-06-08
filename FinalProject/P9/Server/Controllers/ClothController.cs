using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P9.Server.DB;
using P9.Shared;

namespace P8.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClotheController : Controller
    {
        // public static List<Clothe> Clothes = new List<Clothe>()
        // {
        //     new Clothe {Id = 1, Name = "T-Shirt", Price = 1_000_000, Color = "black"},
        //     new Clothe {Id = 2, Name = "Pants", Price = 1_000, Color = "red"},
        //     new Clothe {Id = 3, Name = "Hat", Price = 50_000, Color = "green"}
        // };

        // [HttpGet]
        // [Route("getAllClothes")]
        // public List<Clothe> getAllClothes() => ClotheController.Clothes;

        // [HttpGet("getClotheById/{id}")]
        // // [Route("getClotheById")]
        // public Clothe getClotheById (int id) => Clothes.Where((c) => c.Id == id).First();

        // [HttpPost]
        // [Route("AddNewCloth")]
        // public Clothe AddNewCloth(Clothe clothe)
        // {
        //     var nId = Clothes.Last().Id + 1;
        //     var newClothe =  new Clothe {
        //         Price = clothe.Price,
        //         Name = clothe.Name,
        //         Color = clothe.Color,
        //         Id = nId 
        //     };
        //     ClotheController.Clothes.Add(newClothe);
        //     return newClothe;
        // }

        // [HttpDelete]
        // [Route("removeClothes")]
        // public List<Clothe> RemoveClothes(int[] ids)
        // {
        //     ClotheController.Clothes = ClotheController.Clothes.Where(c => !ids.Contains(c.Id)).ToList();
        //     return ClotheController.Clothes; 
        // }

        // [HttpPut]
        // [Route("updateClothe")]
        // public Clothe UpdateClothe(Clothe clothe)
        // {
        //     int idx = Clothes.IndexOf(clothe);
        //     ClotheController.Clothes[idx] = clothe;
        //     return Clothes[idx];
        // }
        private readonly ClotheProvider _provider;
        public ClotheController(ClotheProvider provider)
        {
            this._provider = provider;
        }

        [HttpPost]
        [Route("addclothe")]
        public async Task<Clothe> AddNewClotheToDb(Clothe clothe)
        {
            await this._provider.AddCloth(clothe);
            return clothe;
        }

        [HttpGet]
        [Route("getallclothe")]
        public List<Clothe> GetAllClotheInDb()
            => this._provider.GetAllClothe();

        [HttpDelete]
        [Route("removeclothe")]
        public List<Clothe> RemoveClotheFromDb(int id)=>
            this._provider.RemoveClotheFromDb(id);
        [HttpDelete]
        [Route("removeclothe2")]
        
        public void removefromdb(int id)
        {
            this._provider.removefromdb(id);
        } 

        [HttpPut]
        [Route("reducecount")]
        public void reducecount(List<Clothe> v)
        {
            _provider.reduce(v);
        }

    }
}
