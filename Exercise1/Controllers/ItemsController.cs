using Exercise1.managers;
using Exercise1.models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exercise1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsManager _manager;

        public ItemsController(ItemContext context)
        {
            _manager = new ItemManagerDB(context);
        }

        [HttpGet]
        public IEnumerable<Item> Get([FromQuery] string name)
        {
            return _manager.GetAll(name);
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public Item Post([FromBody] Item newItem)
        {
            return _manager.Add(newItem);
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Item updateItem)
        {
            _manager.Update(id, updateItem);
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public Item Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
