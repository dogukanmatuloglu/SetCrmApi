using HomeWork.Business.Abstract;
using HomeWork.Business.Concrete;
using HomeWork.Entity.Options;

var builder = WebApplication.CreateBuilder(args);

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false).Build();

var _mayaSettings = new MayaSettings();
builder.Configuration.Bind(nameof(MayaSettings), _mayaSettings);
var _kampanyaModel=new KampanyaModel();
builder.Configuration.Bind(nameof(KampanyaModel), _kampanyaModel);
var _appConfig=new AppConfig();
builder.Configuration.Bind(nameof(AppConfig), _appConfig);

builder.Services.AddSingleton(_=>_appConfig);
builder.Services.AddSingleton(_ => _mayaSettings);
builder.Services.AddSingleton(_ => _kampanyaModel);

builder.Services.AddScoped<ISetCrmHelper, SetCrmHelper>();
builder.Services.AddScoped<IKampanyaService, KampanyaService>();
builder.Services.AddScoped<IUserService, UserService>();



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
