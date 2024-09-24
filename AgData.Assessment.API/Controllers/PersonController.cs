using AgData.Assessment.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgData.Assessment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonService _personService;

        public PersonController(PersonService personService)
        {
            _personService = personService;
        }

        [HttpPost]
        public IActionResult SavePersonData([FromBody] Person person)
        {
            try
            {
                var savedPerson = _personService.SavePersonData(person.Name, person.Address);
                return Ok(savedPerson);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
