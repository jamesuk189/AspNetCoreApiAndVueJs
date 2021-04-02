using Microsoft.AspNetCore.Mvc;

namespace ExampleApp
{

    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "Hello World from ASP.NET Core Web API!";
        }

    }

}