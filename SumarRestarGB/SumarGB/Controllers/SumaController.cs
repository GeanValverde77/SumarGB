using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SumarGB.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class SumaController : ControllerBase
    {
        [HttpGet]
        [Route("Add")]
        public int Add(int a, int b)
        {
            return a + b;
        }
        [HttpPost]
        [Route("Multiply")]
        public int Mul( int a, int b)
        {
            return a * b;
        }
        [HttpGet]
        [Route("Add")]
        public int Add2([FromHeader] int a, [FromHeader] int b)
        {
            return a + b;
        }
        [HttpGet]
        [Route("Multiply")]
        public int Mul2([FromHeader] int a, [FromHeader] int b)
        {
            return a * b;
        }
    }
}
