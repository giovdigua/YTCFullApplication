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
        [ProducesResponseType(typeof(Studente), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            ModelState.AddModelError("Id", "Id non trovato");
            return NotFound(new ValidationProblemDetails(ModelState)); 
            //throw new Exception("Errorer imprevisto");
        }
        
        [HttpPost]
        [ProducesResponseType(typeof(Studente), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(Studente studente)
        {
            ModelState.AddModelError("Nome", "Nome troppo lungo");
            return BadRequest(new ValidationProblemDetails(ModelState));
            //return Ok();
        }

        [HttpPut]
        public IActionResult Put(Studente studente)
        { return Ok(); }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int id)
        { return Ok(); }
    }
}
