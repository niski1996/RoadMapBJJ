using DrillRoad.Database.Repositories;
using DrillRoad.Entities.Account;
using DrillRoad.Test.Samples;
using Microsoft.EntityFrameworkCore;

namespace DrillRoad.Database.Test.Repository;

public class UserWithPersonalDataTests 
{


    [Fact]
    public async Task AddUserWithPersonalData_ShouldAddUserToDatabase()
    {
        
        
        var ConnectionString = $"Host=localhost;Port=6432;Database=test;Username=postgres;Password=postgres;TrustServerCertificate=True;";

        // Arrange
        var options = new DbContextOptionsBuilder<RoadMapDbContext>()
            .UseNpgsql(ConnectionString)
            .Options;

        using (var context = new RoadMapDbContext(options))
        {
            context.Database.EnsureCreated();
            var repo =new AdditionalUserRepository(context);
            var user = new UserWithPersonalData
            {
                PictureRepoPatch = "/images/user.jpg",
                Contact = ContactSamples.Contact1, // Przykładowy kontakt z wcześniej utworzonej fixtury
                JoinDate = DateTime.UtcNow
            };
            user.UserName = "user1@user.pl";
            repo.UpdateAsync(user);

            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();

            // Assert
            var addedUser = await context.Users.FindAsync(user.Id);
            Assert.NotNull(addedUser);
        }
    }
}