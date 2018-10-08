using Microsoft.AspNetCore.Mvc;

namespace RestTest
{
    [Route("pet")]
    public class PetController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            if( id == 1 )
            {
                return Ok(new Pet
                {
                    Id = 1,
                    Name = "Feynman",
                    Type = "Dog"
                }
                );
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
