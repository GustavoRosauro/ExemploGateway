using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carros.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrosController : ControllerBase
    {
        [HttpGet]
        public string[] RetornarCarros() => new string[]
            {
                "BMW",
                "JETTA",
                "FUSION",
                "ONIX"
            };
    }
}
