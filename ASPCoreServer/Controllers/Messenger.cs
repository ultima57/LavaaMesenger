﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreServer.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class Messenger : ControllerBase {


        // GET api/<Messenger>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "Rayner" + id.ToString();
        }

        // POST api/<Messenger>
        [HttpPost]
        public void Post([FromBody] string value) {
        }


    }
}
