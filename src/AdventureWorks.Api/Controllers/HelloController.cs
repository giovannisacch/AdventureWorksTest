using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
    
        // GET api/Hello
        [HttpGet]
        public ActionResult<string> Get(int id)
        {
            return "Hello from IOB Sage Adventure Works!";
        }
    }
}
