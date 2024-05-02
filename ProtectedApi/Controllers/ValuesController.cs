using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProtectedApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            var userInfo = new 
            {
                Name = "John Doe",
                Section = "A",
                Course = "Computer Science",
                FunFacts = new List<string>
                {
                    "Fact 1",
                    "Fact 2",
                    "Fact 3",
                    "Fact 4",
                    "Fact 5",
                    "Fact 6",
                    "Fact 7",
                    "Fact 8",
                    "Fact 9",
                    "Fact 10"
                }
            };

            return Ok(userInfo);
        }
    }
}