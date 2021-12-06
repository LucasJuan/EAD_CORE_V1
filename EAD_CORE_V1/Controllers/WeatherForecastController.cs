using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_CORE_V1.Controllers
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

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        //public async Task<string> EnviaArquivo([FromForm] IFormFile arquivo)
        //{
        //    if (arquivo.Length > 0)
        //    {
        //        try
        //        {
        //            if (!Directory.Exists(_environment.WebRootPath + "\\imagens\\"))
        //            {
        //                Directory.CreateDirectory(_environment.WebRootPath + "\\imagens\\");
        //            }
        //            using (FileStream filestream = System.IO.File.Create(_environment.WebRootPath + "\\imagens\\" + arquivo.FileName))
        //            {
        //                await arquivo.CopyToAsync(filestream);
        //                filestream.Flush();
        //                return "\\imagens\\" + arquivo.FileName;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            return ex.ToString();
        //        }
        //    }
        //    else
        //    {
        //        return "Ocorreu uma falha no envio do arquivo...";
        //    }
        //}
    }
}
