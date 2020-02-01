using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Versioning.ApiModel;

namespace WebAPI_Versioning.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DarkKnightTrilogyController : ControllerBase
    {
        public IActionResult GetCharacters()
        {
            var result = new List<Character>
            {
                new Character { FirstName = "Bruce", LastName = "Wayne", AlterEgo = "Batman", Actor = "Christian Bale" },
                new Character { FirstName = "Rachel", LastName = "Daws", AlterEgo = "", Actor = "Katie Holmes" },
                new Character { FirstName = "Jonathan", LastName = "Crane", AlterEgo = "Scarecrow", Actor = "Cillian Murphy" },
                new Character { FirstName = "James", LastName = "Gordon", AlterEgo = "", Actor = "Gary Oldman" },
                new Character { FirstName = "Alfred", LastName = "Pennyworth", AlterEgo = "", Actor = "Michael Caine" },
                new Character { FirstName = "Henri", LastName = "Ducard", AlterEgo = "Ras al Gul", Actor = "Liam Neeson" }
            };

            return new OkObjectResult(result);
        }
    }
}
