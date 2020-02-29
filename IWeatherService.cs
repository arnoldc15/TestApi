using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> GetAllWeatherForecasts();
    }

}
