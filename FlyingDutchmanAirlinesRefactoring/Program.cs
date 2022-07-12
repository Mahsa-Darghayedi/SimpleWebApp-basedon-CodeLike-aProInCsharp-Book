using FlyingDutchmanAirlinesRefactoring.Configs.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServiceConfig(builder.Configuration);

var app = builder.Build();

app.UseApplicationConfig(app.Environment);

app.MapControllers();
app.Run();
