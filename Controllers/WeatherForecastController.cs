using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
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

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var calculateInstance = new Calculate(23);

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpGet]
        //public List<int> Getalue()   // zwracanie wiekszej ilosci wartosci
        public int GetValue()
        {
            var calculateInstance = new Calculate(23);
            calculateInstance.Increase(10);
            calculateInstance.Decrease(3);
            return calculateInstance.GetValue();

            //var calculateInstance2 = new Calculate(45); //druga wartosc
            //return new List<int>() { calculateInstance2.GetValue(), calculateInstance.GetValue()} //sposob zwracania
        }
    }
}