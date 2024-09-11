using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RoadMapBJJ.Contracts.Entities.Persons;
using RoadMapBJJ.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RoadMapDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlConnection")));


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthorization();
builder.Services.AddAuthentication().AddCookie(IdentityConstants.ApplicationScheme)
    .AddBearerToken(IdentityConstants.BearerScheme);

builder.Services.AddIdentityCore<User>()
    .AddEntityFrameworkStores<RoadMapDbContext>()
    .AddApiEndpoints();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
    // app.ApplyMigration();
}

app.UseHttpsRedirection();
app.MapIdentityApi<User>();
app.UseAuthorization();
app.MapControllers();
app.Run();