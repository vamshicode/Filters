using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //global level filter(controller level)
    //[MySampleActionFilter("Controller")]
    //[MySampleAsyncActionFilter("Controller")]


    //Tests
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger) 
        {
            _logger = logger;
        }
        //method level
        //action filter
        [MySampleActionFilter("Action")]
        //AsyncActionFilter
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
    [ApiController]
    [Route("[controller]")]
    //[Route("UserS")]
    public class UserController : ControllerBase
    {
        [Route("GetUser")]
        //[HttpGet(Name = "GetUser")]
        public string Get()
        {
            //Console.WriteLine("User Called");
            return "Hello World";
        }
    }

}