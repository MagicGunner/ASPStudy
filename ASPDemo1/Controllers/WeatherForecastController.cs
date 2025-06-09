using ASPDemo1.IService;
using ASPDemo1.Model;
using Microsoft.AspNetCore.Mvc;

namespace ASPDemo1.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(ILogger<WeatherForecastController> logger) : ControllerBase {
    public IBaseService<Role, RoleVo> RoleServiceObj { get; set; }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<object> Get() {
        return await RoleServiceObj.Query();
    }
}