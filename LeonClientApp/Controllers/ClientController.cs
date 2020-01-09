﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeonClientApp.Services;
using LeonCustomerTracker.ApiModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeonClientApp.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost("[action]")]
        public void AddClient([FromBody] ClientDetailsDto clientData, [FromServices] IClientService clientService)
        {
            // Todo Validation
            clientService.Add(clientData);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
