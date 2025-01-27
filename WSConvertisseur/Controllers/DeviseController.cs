﻿using Microsoft.AspNetCore.Mvc;
using WSConvertisseur.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WSConvertisseur.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviseController : ControllerBase
    {
        private readonly List<Devise> devises;

        public DeviseController()
        {
            devises = new List<Devise>
        {
            new Devise(1, "Dollar", 1.08),
            new Devise(2, "Franc Suisse", 1.07),
            new Devise(3, "Yen", 120.0)
        };
        }
        // GET: api/<DeviseController>
        [HttpGet]
        public IEnumerable<Devise> Get()
        {
            return devises;
        }

        // GET api/<DeviseController>/5
        [HttpGet("{id}")]
        public string GetAll(int id)
        {
            return "value";
        }

        // POST api/<DeviseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DeviseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DeviseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}