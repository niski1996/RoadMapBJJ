using System.Text.Json;
using AutoMapper;
using DrillRoad.Contracts.Account;
using DrillRoad.Database.Mappers;
using DrillRoad.Database.Tables.Account;
using DrillRoad.Database.Tables.Techniques;
using DrillRoad.Entities.Account;

namespace DrillRoad.Database.Test.Mappers;

public class UserWithPersonalDataProfileTests
{
    private readonly IMapper _mapper;

    public UserWithPersonalDataProfileTests()
    {
        // Konfiguracja AutoMapper z naszymi profilami
        var config = new MapperConfiguration(cfg => 
        {
            cfg.AddProfile<AddressProfile>(); // Zakładamy, że ten profil już istnieje
            cfg.AddProfile<ContactProfile>(); // Zakładamy, że ten profil już istnieje
            cfg.AddProfile<UserWithPersonalDataProfile>();
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
                Address = new AddressRow
                {
                    Apartment = "A1",
                    Building = "10B",
                    Street = "Main St",
                    City = "Warsaw",
                    PostalCode = "00-001",
                    Country = "Poland",
                    Id = Guid.NewGuid(),
                    InsertTime = DateTime.Now
                },
                PhoneNumber = "123456789",
                Email = "test@example.com",
                Id = Guid.NewGuid(),
                InsertTime = DateTime.Now
            },
            Id = Guid.NewGuid(),
            InsertTime = DateTime.Now,
            fightActions = new List<FightActionRow>(),   // Zainicjowane puste listy
            positions = new List<PositionRow>(),
            transactions = new List<TransitionRow>(),
            trainers = new List<UserDrillIdentity>()
        };

        // Act
        var userWithPersonalData = _mapper.Map<UserWithPersonalData>(additionalUserInfoRow);

        // Assert
        Assert.Equal(additionalUserInfoRow.PictureRepoPatch, userWithPersonalData.PictureRepoPatch);
        Assert.Equal(additionalUserInfoRow.ContactRow.PhoneNumber, userWithPersonalData.Contact.PhoneNumber);
        Assert.Equal(additionalUserInfoRow.ContactRow.Email, userWithPersonalData.Contact.Email);
        Assert.Equal(additionalUserInfoRow.InsertTime, userWithPersonalData.JoinDate);

        // Zignorowanie list, które nie są mapowane
    }

    [Fact]
    public void Should_Map_UserWithPersonalData_To_AdditionalUserInfoRow()
    {
        // Arrange
        var userWithPersonalData = new UserWithPersonalData
        {
            PictureRepoPatch = "path/to/another/picture",
            Contact = new Contact
            {
                Address = new Address
                {
                    Apartment = "B2",
                    Building = "15C",
                    Street = "Second St",
                    City = "Krakow",
                    PostalCode = "31-002",
                    Country = "Poland",
                    Id = Guid.NewGuid()
                },
                PhoneNumber = "987654321",
                Email = "example@test.com",
                Id = Guid.NewGuid()
            },
            JoinDate = DateTime.Now
        };

        // Act
        var additionalUserInfoRow = _mapper.Map<AdditionalUserInfoRow>(userWithPersonalData);

        // Assert
        Assert.Equal(userWithPersonalData.PictureRepoPatch, additionalUserInfoRow.PictureRepoPatch);
        Assert.Equal(userWithPersonalData.Contact.PhoneNumber, additionalUserInfoRow.ContactRow.PhoneNumber);
        Assert.Equal(userWithPersonalData.Contact.Email, additionalUserInfoRow.ContactRow.Email);
        Assert.Equal(userWithPersonalData.JoinDate, additionalUserInfoRow.InsertTime);

        // Sprawdzanie, czy listy są zainicjowane jako puste (zgodnie z nową konfiguracją)
        Assert.NotNull(additionalUserInfoRow.fightActions);
        Assert.Empty(additionalUserInfoRow.fightActions);

        Assert.NotNull(additionalUserInfoRow.positions);
        Assert.Empty(additionalUserInfoRow.positions);

        Assert.NotNull(additionalUserInfoRow.transactions);
        Assert.Empty(additionalUserInfoRow.transactions);

        Assert.NotNull(additionalUserInfoRow.trainers);
        Assert.Empty(additionalUserInfoRow.trainers);
    }

    [Fact]
    public void Should_Map_AdditionalUserInfoRow_To_UserWithPersonalData_And_Back_And_Compare_As_Json()
    {
        // Arrange
        var originalAdditionalUserInfoRow = new AdditionalUserInfoRow
        {
            PictureRepoPatch = "path/to/picture",
            ContactRow = new ContactRow
            {
                Address = new AddressRow
                {
                    Apartment = "A1",
                    Building = "10B",
                    Street = "Main St",
                    City = "Warsaw",
                    PostalCode = "00-001",
                    Country = "Poland",
                    Id = Guid.NewGuid(),
                    InsertTime = DateTime.Now
                },
                PhoneNumber = "123456789",
                Email = "test@example.com",
                Id = Guid.NewGuid(),
                InsertTime = DateTime.Now
            },
            Id = Guid.NewGuid(),
            InsertTime = DateTime.Now,
            fightActions = new List<FightActionRow>(),
            positions = new List<PositionRow>(),
            transactions = new List<TransitionRow>(),
            trainers = new List<UserDrillIdentity>()
        };

        // Act
        var userWithPersonalData = _mapper.Map<UserWithPersonalData>(originalAdditionalUserInfoRow);
        var mappedBackAdditionalUserInfoRow = _mapper.Map<AdditionalUserInfoRow>(userWithPersonalData);

        // Serialize both objects to JSON
        var originalJson = JsonSerializer.Serialize(originalAdditionalUserInfoRow, new JsonSerializerOptions { WriteIndented = true });
        var mappedBackJson = JsonSerializer.Serialize(mappedBackAdditionalUserInfoRow, new JsonSerializerOptions { WriteIndented = true });

        // Assert - compare JSON strings
        Assert.Equal(originalJson, mappedBackJson);
    }

    [Fact]
    public void Should_Map_UserWithPersonalData_To_AdditionalUserInfoRow_And_Back_And_Compare_As_Json()
    {
        // Arrange
        var originalUserWithPersonalData = new UserWithPersonalData
        {
            PictureRepoPatch = "path/to/another/picture",
            Contact = new Contact
            {
                Address = new Address
                {
                    Apartment = "B2",
                    Building = "15C",
                    Street = "Second St",
                    City = "Krakow",
                    PostalCode = "31-002",
                    Country = "Poland",
                    Id = Guid.NewGuid()
                },
                PhoneNumber = "987654321",
                Email = "example@test.com",
                Id = Guid.NewGuid()
            },
            JoinDate = DateTime.Now
        };

        // Act
        var additionalUserInfoRow = _mapper.Map<AdditionalUserInfoRow>(originalUserWithPersonalData);
        var mappedBackUserWithPersonalData = _mapper.Map<UserWithPersonalData>(additionalUserInfoRow);

        // Serialize both objects to JSON
        var originalJson = JsonSerializer.Serialize(originalUserWithPersonalData, new JsonSerializerOptions { WriteIndented = true });
        var mappedBackJson = JsonSerializer.Serialize(mappedBackUserWithPersonalData, new JsonSerializerOptions { WriteIndented = true });

        // Assert - compare JSON strings
        Assert.Equal(originalJson, mappedBackJson);
    }
}