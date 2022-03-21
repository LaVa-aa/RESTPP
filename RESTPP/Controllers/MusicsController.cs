using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTPP.Managers;
using RESTPP.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicsController : ControllerBase
    {
        private readonly MusicsManager manager = new MusicsManager();

        // GET: api/<MusicsController>
        [HttpGet]
        public IEnumerable<Music> Get([FromQuery] string title, [FromQuery] string artist)
        {
            return manager.GetAll(title, artist);
        }

        // GET api/<MusicsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MusicsController>
        [HttpPost]
        public Music Post([FromBody] Music value)
        {
            return manager.Add(value);
        }

        // PUT api/<MusicsController>/5
        [HttpPut("{id}")]
        public Music Put(int id, [FromBody] Music value)
        {
            return manager.Update(id, value);
        }

        // DELETE api/<MusicsController>/5
        [HttpDelete("{id}")]
        public Music Delete(int id)
        {
            return manager.Delete(id);
        }
    }
}
