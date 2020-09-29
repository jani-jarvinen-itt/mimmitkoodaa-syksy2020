using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TuotteetController : ControllerBase
    {
        public int Luku()
        {
            return 123;
        }
    }
}
