using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DataService;
using AutoMapper;
using LeagueOfLegendsRest.Services.IService;

namespace LeagueOfLegendsRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IUserService _userService;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
           
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = _userService.GetAllUsers();

            return Ok(list);
        }
    }
}
