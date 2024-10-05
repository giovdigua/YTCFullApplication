using Microsoft.AspNetCore.Mvc;
using YTCFullApplication.Domain;

namespace YTCFullApplication.Host.Controllers
{
    public class StudentiController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Studente>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        { return Ok();  }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        { return Ok();  }
        
        [HttpPost]
        public IActionResult Post(Studente studente)
        { return Ok();  }

        [HttpPut]
        public IActionResult Put(Studente studente)
        { return Ok(); }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int id)
        { return Ok(); }
    }
}
