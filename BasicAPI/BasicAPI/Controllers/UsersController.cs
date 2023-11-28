﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get(string? status, string? name)
        {
            var arr = new string[] { "value1", "value2" };
            return arr.Where(v=>v.Contains(name) || string.IsNullOrEmpty(name));
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id, int bla, string clum)
        {
            
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        // PUT api/<UsersController>/5
        [HttpPut("{id}/status")]
        public void PutStatus(int id, [FromBody] string status)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}