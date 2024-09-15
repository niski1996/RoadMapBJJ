using FFMpegCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RoadMapBJJ.Contracts.Entities.Persons;
using RoadMapBJJ.Database;
using RoadMapBJJ.Services.videos;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration; ;

GlobalFFOptions.Configure(new FFOptions{BinaryFolder = "ffmpeg/bin", TemporaryFilesFolder = "ffmpeg/tmp"});
builder.Services.Configure<VideoSettings>(configuration.GetSection("VideoSettings"));

builder.Services.AddDbContext<RoadMapDbContext>(options =>
    options.UseNpgsql(configuration.GetConnectionString("PostgreSqlConnection")));


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