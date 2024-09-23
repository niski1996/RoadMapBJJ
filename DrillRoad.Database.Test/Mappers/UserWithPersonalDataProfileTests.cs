using AutoMapper;
using DrillRoad.Database.Mappers;
using DrillRoad.Database.Tables.Account;
using DrillRoad.Entities.Account;
using Xunit;

public class UserWithPersonalDataProfileTests
{
    private readonly IMapper _mapper;

    public UserWithPersonalDataProfileTests()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<UserWithPersonalDataProfile>(); // Dodajemy profil mapowania
            cfg.AddProfile<ContactProfile>(); // Dodajemy profil mapowania dla Contact
            cfg.AddProfile<AddressProfile>(); // Dodajemy profil mapowania dla Contact
        });
        _mapper = config.CreateMapper();
    }

    [Fact]
    public void Should_Map_AdditionalUserInfoRow_To_UserWithPersonalData()
    {
        // Arrange
        var additionalUserInfoRow = new AdditionalUserInfoRow
        {
            PictureRepoPatch = "path/to/picture",
            ContactRow = new ContactRow
            {
                PhoneNumber = "123456789",
                Email = "test@example.com",
                Address = new AddressRow
                {
                    Building = "1A",
                    City = "TestCity",
                    Country = "TestCountry",
                    PostalCode = "12345",
                    Street = "Test Street"
                },
                Id = Guid.NewGuid()
            },
            InsertTime = DateTime.Now
        };

        // Act
        var userWithPersonalData = _mapper.Map<UserWithPersonalData>(additionalUserInfoRow);

        // Assert
        Assert.NotNull(userWithPersonalData);
        Assert.Equal(additionalUserInfoRow.PictureRepoPatch, userWithPersonalData.PictureRepoPatch);
        Assert.Equal(additionalUserInfoRow.ContactRow.PhoneNumber, userWithPersonalData.Contact.PhoneNumber);
        Assert.Equal(additionalUserInfoRow.ContactRow.Email, userWithPersonalData.Contact.Email);
        Assert.Equal(additionalUserInfoRow.InsertTime, userWithPersonalData.JoinDate);
    }

    [Fact]
    public void Should_Map_UserWithPersonalData_To_AdditionalUserInfoRow()
    {
        // Arrange
        var userWithPersonalData = new UserWithPersonalData
        {
            PictureRepoPatch = "path/to/picture",
            Contact = new Contact
            {
                PhoneNumber = "123456789",
                Email = "test@example.com",
                Address = new Address
                {
                    Building = "1A",
                    City = "TestCity",
                    Country = "TestCountry",
                    PostalCode = "12345",
                    Street = "Test Street"
                },
                Id = Guid.NewGuid()
            },
            JoinDate = DateTime.Now
        };

        // Act
        var additionalUserInfoRow = _mapper.Map<AdditionalUserInfoRow>(userWithPersonalData);

        // Assert
        Assert.NotNull(additionalUserInfoRow);
        Assert.Equal(userWithPersonalData.PictureRepoPatch, additionalUserInfoRow.PictureRepoPatch);
        Assert.Equal(userWithPersonalData.Contact.PhoneNumber, additionalUserInfoRow.ContactRow.PhoneNumber);
        Assert.Equal(userWithPersonalData.Contact.Email, additionalUserInfoRow.ContactRow.Email);
        Assert.Equal(userWithPersonalData.JoinDate, additionalUserInfoRow.InsertTime);
    }
}
