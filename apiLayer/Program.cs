using DaoLayer;
using DaoLayer.Posts;
using DaoLayer.Utilisateurs;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
}) ;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
IConfiguration conf = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddCommandLine(args)
    .AddEnvironmentVariables()
    .Build();

string sconf = conf.GetConnectionString("mycon");
builder.Services.AddDbContext<PostContext>(opt => opt.UseSqlServer(sconf));
builder.Services.AddTransient(typeof(IPost),typeof(PostService));
builder.Services.AddTransient(typeof(IUtilisateur),typeof(UtilisateurService));
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
