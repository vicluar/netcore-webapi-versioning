using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Versioning.ApiModel;

namespace WebAPI_Versioning.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    [Route("api/[controller]")]
    public class DarkKnightTrilogyController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCharacters()
        {
            var result = new List<Character>
            {
                new Character { FirstName = "Bruce", LastName = "Wayne", AlterEgo = "Batman", Actor = "Christian Bale" },
                new Character { FirstName = "Rachel", LastName = "Dawes", AlterEgo = "", Actor = "Katie Holmes" },
                new Character { FirstName = "Jonathan", LastName = "Crane", AlterEgo = "Scarecrow", Actor = "Cillian Murphy" },
                new Character { FirstName = "James", LastName = "Gordon", AlterEgo = "", Actor = "Gary Oldman" },
                new Character { FirstName = "Alfred", LastName = "Pennyworth", AlterEgo = "", Actor = "Michael Caine" },
                new Character { FirstName = "Henri", LastName = "Ducard", AlterEgo = "Ras al Gul", Actor = "Liam Neeson" }
            };

            return new OkObjectResult(result);
        }

        [HttpGet, MapToApiVersion("2.0")]
        public IActionResult GetCharactersV2()
        {
            var result = new List<Character>
            {
                new Character { FirstName = "Bruce", LastName = "Wayne", AlterEgo = "Batman", Actor = "Christian Bale" },
                new Character { FirstName = "Rachel", LastName = "Dawes", AlterEgo = "", Actor = "Maggie Gyllenhaal" },
                new Character { FirstName = "James", LastName = "Gordon", AlterEgo = "", Actor = "Gary Oldman" },
                new Character { FirstName = "Alfred", LastName = "Pennyworth", AlterEgo = "", Actor = "Michael Caine" },
                new Character { FirstName = "", LastName = "", AlterEgo = "The Joker", Actor = "Heath Ledger" },
                new Character { FirstName = "Harvey", LastName = "Dent", AlterEgo = "Two Faces", Actor = "Aaron Eckhart" }
            };

            return new OkObjectResult(result);
        }

        [HttpGet, MapToApiVersion("3.0")]
        public IActionResult GetCharactersV3()
        {
            var result = new List<Character>
            {
                new Character { FirstName = "Bruce", LastName = "Wayne", AlterEgo = "Batman", Actor = "Christian Bale" },
                new Character { FirstName = "Rachel", LastName = "Dawes", AlterEgo = "", Actor = "Maggie Gyllenhaal" },
                new Character { FirstName = "James", LastName = "Gordon", AlterEgo = "", Actor = "Gary Oldman" },
                new Character { FirstName = "Alfred", LastName = "Pennyworth", AlterEgo = "", Actor = "Michael Caine" },
                new Character { FirstName = "Selina", LastName = "Kyle", AlterEgo = "Catwoman", Actor = "Anne Hathaway" },
                new Character { FirstName = "", LastName = "", AlterEgo = "Bane", Actor = "Tom Hardy" },
                new Character { FirstName = "Miranda", LastName = "Tate", AlterEgo = "Talia al Ghul", Actor = "Marion Cotillard" }
            };

            return new OkObjectResult(result);
        }
    }
}
