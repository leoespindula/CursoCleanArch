using CleanArchMvc.WebUi;
using CleanArchMvc.Infra.Ioc;
using CleanArchMvc.Domain.Account;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

var seedUserRoleInitial = builder.Services.BuildServiceProvider().GetService<ISeedUserRoleInitial>();
startup.Configure(app, app.Environment, seedUserRoleInitial);
app.Run();