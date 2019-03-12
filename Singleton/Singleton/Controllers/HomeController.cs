using Singleton.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Singleton.Controllers
{
    public class HomeController : ApiController
    {
        private readonly IRequestHandler _handler;

        public HomeController(IRequestHandler handler)
        {
            _handler = handler;
        }

        [HttpGet]
        public IHttpActionResult Index()
        {
            var result = _handler.GetStudent();

            return Ok(result);
        }
    }
}
