using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Template.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase {

        private readonly IDatabase _context;

        [HttpGet]
        public IActionResult Get() {

            var result = _context.Query<bool>("SELECT TRUE");
            return Ok(result);

        }

        public DatabaseController(IDatabase context) {
            _context = context;
        }

    }
}
