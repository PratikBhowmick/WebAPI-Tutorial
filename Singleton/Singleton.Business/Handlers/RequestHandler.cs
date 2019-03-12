using Singleton.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Business.Handlers
{
    public class RequestHandler : IRequestHandler
    {
        public List<string> GetStudent()
        {
            return new List<string>() { "RequestHandler", "Hello", "Bye" };
        }
    }
}
