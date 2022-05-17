using Microsoft.AspNetCore.Mvc;

namespace Filter_and_Attribute.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [MyAttribute("Class level")]
    public class UserController: ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello world";
        }
        [HttpGet("GetName")]
        [MyAttribute("Action level")]
        public string GetName()
        {
            return "Nguyen Xuan An";
        }
    }
}
