﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> strings = new List<string>()
        {
            "value0",
            "value1",
            "value2"
        };

        // GET api/values
        [HttpGet]
        [Route("All")]
        public IEnumerable<string> GetAllString()
        {
            return strings;
        }

        // GET api/values/5
        [HttpGet]
        public string GetAString(int id)
        {
            return strings[id];
        }

        // POST api/values
        [HttpPost]
        public void AddString([FromBody]string value)
        {
            strings.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            strings[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }
    }
}
