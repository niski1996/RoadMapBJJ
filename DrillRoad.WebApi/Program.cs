using DrillRoad.Contracts.Account;
using DrillRoad.Database;
using DrillRoad.Database.Repositories;
using DrillRoad.Database.Tables;
using DrillRoad.Services.videos;
using FFMpegCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args); //TODO generate strtup
ConfigurationManager configuration = builder.Configuration; ;

GlobalFFOptions.Configure(new FFOptions{BinaryFolder = "ffmpeg/bin", TemporaryFilesFolder = "ffmpeg/tmp"});
builder.Services.Configure<VideoSettings>(configuration.GetSection("VideoSettings"));


builder.Services.AddDbContext<RoadMapDbContext>(options =>
    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddControllers();
builder.Services.AddRepositories();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin());
});
builder.Services.AddSwaggerGen(options =>
    {
        options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Name = "Authorization",
            Type = SecuritySchemeType.ApiKey,
        });
        options.OperationFilter<SecurityRequirementsOperationFilter>();
    }
    );


builder.Services.AddAuthorization();
builder.Services.AddIdentityApiEndpoints<UserDrillIdentity>()
    .AddEntityFrameworkStores<RoadMapDbContext>();


// builder.Services.AddAuthentication().AddCookie(IdentityConstants.ApplicationScheme)
//     .AddBearerToken(IdentityConstants.BearerScheme);

// builder.Services.AddIdentityCore<User>()
//     .AddEntityFrameworkStores<RoadMapDbContext>()
//     .AddApiEndpoints();



var app = builder.Build();


    app.UseSwagger();
    app.UseSwaggerUI();
    
    // app.ApplyMigration();


app.UseHttpsRedirection();
app.MapIdentityApi<UserDrillIdentity>();
app.UseAuthorization();
app.MapControllers();
app.Run();