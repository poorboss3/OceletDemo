using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace FoodApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PotatoController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<FoodModel>> Get()
        {
            List<PotatoModel> potatoModels = new List<PotatoModel>();
            for (int i = 0; i < 3; i++)
            {
                potatoModels.Add(new PotatoModel { Amount=i,Name="potato",Weight=new Random().Next(1,10)});
            }
            return potatoModels;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<FoodModel> Get(int id)
        {
            return new PotatoModel { Amount = id, Name = "Mypotato", Weight = new Random().Next(1, 10) };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
