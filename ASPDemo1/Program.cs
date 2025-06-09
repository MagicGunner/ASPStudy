using ASPDemo1.Extensions;
using ASPDemo1.Model;
using ASPDemo1.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<BaseService<Role, RoleVo>>();

builder.Services.AddAutoMapper(typeof(AutoMapperConfig));
AutoMapperConfig.RegisterMappings();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

app.MapGet("/weatherforecast", async (BaseService<Role, RoleVo> service) => {
                                   // var forecast = Enumerable.Range(1, 5)
                                   //                          .Select(index =>
                                   //                                      new WeatherForecast
                                   //                                          (
                                   //                                           DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                                   //                                           Random.Shared.Next(-20, 55),
                                   //                                           summaries[Random.Shared.Next(summaries.Length)]
                                   //                                          ))
                                   //                          .ToArray();
                                   // return forecast;

                                   // var userService = new UserService();
                                   // var query = await userService.Query();
                                   // return query;

                                   // var service = new BaseService<Role, RoleVo>(mapper);
                                   return await service.Query();
                               })
   .WithName("GetWeatherForecast")
   .WithOpenApi();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary) {
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}