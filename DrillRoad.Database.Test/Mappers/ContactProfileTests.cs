using System.Text.Json;
using AutoMapper;
using DrillRoad.Database.Mappers;
using DrillRoad.Database.Tables.Account;
using DrillRoad.Entities.Account;

namespace DrillRoad.Database.Test.Mappers;

public class ContactProfileTests
{
    private readonly IMapper _mapper;

    public ContactProfileTests()
    {
        // Konfiguracja AutoMapper z naszymi profilami
        var config = new MapperConfiguration(cfg => 
        {
            cfg.AddProfile<AddressProfile>(); // Zakładamy, że ten profil już istnieje
            cfg.AddProfile<ContactProfile>();
        });
        _mapper = config.CreateMapper();
    }

    [Fact]
    public void Should_Map_ContactRow_To_Contact()
    {
        // Arrange
        var contactRow = new ContactRow
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
        };

        // Act
        var contact = _mapper.Map<Contact>(contactRow);

        // Assert
        Assert.Equal(contactRow.PhoneNumber, contact.PhoneNumber);
        Assert.Equal(contactRow.Email, contact.Email);
        Assert.Equal(contactRow.Id, contact.Id);

        // Sprawdzanie mapowania Address
        Assert.Equal(contactRow.Address.Apartment, contact.Address.Apartment);
        Assert.Equal(contactRow.Address.Building, contact.Address.Building);
        Assert.Equal(contactRow.Address.Street, contact.Address.Street);
        Assert.Equal(contactRow.Address.City, contact.Address.City);
        Assert.Equal(contactRow.Address.PostalCode, contact.Address.PostalCode);
        Assert.Equal(contactRow.Address.Country, contact.Address.Country);
        Assert.Equal(contactRow.Address.Id, contact.Address.Id);
    }

    [Fact]
    public void Should_Map_Contact_To_ContactRow()
    {
        // Arrange
        var contact = new Contact
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
        };

        // Act
        var contactRow = _mapper.Map<ContactRow>(contact);

        // Assert
        Assert.Equal(contact.PhoneNumber, contactRow.PhoneNumber);
        Assert.Equal(contact.Email, contactRow.Email);
        Assert.Equal(contact.Id, contactRow.Id);

        // Sprawdzanie mapowania Address
        Assert.Equal(contact.Address.Apartment, contactRow.Address.Apartment);
        Assert.Equal(contact.Address.Building, contactRow.Address.Building);
        Assert.Equal(contact.Address.Street, contactRow.Address.Street);
        Assert.Equal(contact.Address.City, contactRow.Address.City);
        Assert.Equal(contact.Address.PostalCode, contactRow.Address.PostalCode);
        Assert.Equal(contact.Address.Country, contactRow.Address.Country);
        Assert.Equal(contact.Address.Id, contactRow.Address.Id);
    }
    
    [Fact]
    public void Should_Map_Contact_To_ContactRow_And_Back_To_Contact_And_Compare_As_Json()
    {
        // Arrange
        var originalContact = new Contact
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
        };

        // Act
        var contactRow = _mapper.Map<ContactRow>(originalContact);
        var mappedBackContact = _mapper.Map<Contact>(contactRow);

        // Serialize both objects to JSON
        var originalJson = JsonSerializer.Serialize(originalContact, new JsonSerializerOptions { WriteIndented = true });
        var mappedBackJson = JsonSerializer.Serialize(mappedBackContact, new JsonSerializerOptions { WriteIndented = true });

        // Assert - compare JSON strings
        Assert.Equal(originalJson, mappedBackJson);
    }
}
