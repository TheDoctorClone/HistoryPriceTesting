using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

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

        [HttpPut("[action]")]
        public async Task<IActionResult> AddProduct([FromBody] WeatherForecast forecast)
        {
            throw new NotImplementedException();
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProduct(string ean)
        {
            throw new NotImplementedException();
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductSpecificDate(string ean, DateTime specificDate)
        {
            throw new NotImplementedException();
        }
    }
}