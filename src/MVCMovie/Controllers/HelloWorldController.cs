using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "This is coming from Index action";
        }
                
        public string Welcome(string name)
        {
            return "This is coming from Welcome action " + name;
        }

    }


}
