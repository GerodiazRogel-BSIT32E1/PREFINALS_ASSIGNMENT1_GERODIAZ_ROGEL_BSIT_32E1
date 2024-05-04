namespace ProtectedApi
{
    using System;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class ValueController : ControllerBase
    {
        private readonly string _owner = "Rogel Gerodiaz";

        [HttpGet("about/me")]
        public IActionResult AboutMe()
        {
            var random = new Random();
            var thingsAboutOwner = new[]
            {
                "I am a BSIT student, im currently studying at Lyceum of Alabang",
                "I love playing online games such as League of Legends and Mobile Legends",
                "I'm into web development as a front-end developer and willing to learn full stack"
            };
            var thing = thingsAboutOwner[random.Next(thingsAboutOwner.Length)];

            return Ok(thing);
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return Ok(_owner);
        }

        [HttpPost("about")]
        public IActionResult About([FromBody] NameModel model)
        {
            return Ok($"Hi {model.Name} from {_owner}");
        }
    }

    public class NameModel
    {
        private string? _name = "Sr. Alamo";
        public string? Name
        {
            get { return _name == "string" ? "Sr. Alamo" : _name; }
            set { _name = value; }
        }
    }
}
