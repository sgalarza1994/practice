using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LecturaString.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpPost("[action]")]
        public IActionResult Get([FromBody] ValidacionHeader header)
        {


            var directorio = Directory.GetFiles("Resources");
            //var uno = header.Header.Split("\n", StringSplitOptions.TrimEntries);
            //var dos = header.Header.Split("\n", StringSplitOptions.RemoveEmptyEntries);
            var tres = header.Header.Split("\n", StringSplitOptions.None);

            var leng = tres[5].Length;
            int difference = 80 - 74;
            var hc = tres[5].Substring(74, difference);
            var hcbase = hc.Split(":");

            int length = 25 - 14;
            var IdentificaiconBase = tres[5].Substring(14, length);

            int lenghtNombre = 66 - 25;
            var nombreBase = tres[5].Substring(25, lenghtNombre);




            var builder = new BodyBuilder();
            using StreamReader sr = System.IO.File.OpenText(directorio[0]);
            builder.HtmlBody = sr.ReadToEnd();
            var rng = new Random();
            return Ok(builder.HtmlBody);
        }
    }
}
