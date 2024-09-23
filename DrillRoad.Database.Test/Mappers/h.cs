using AutoMapper;
using DrillRoad.Database.Mappers;
using DrillRoad.Database.Tables.Account;
using DrillRoad.Entities.Account;

namespace DrillRoad.Database.Test.Mappers;

public class AddressProfileTests
{
    private readonly IMapper _mapper;

    public AddressProfileTests()
    {
        // Konfiguracja AutoMapper z naszym profilem
        var config = new MapperConfiguration(cfg => cfg.AddProfile<AddressProfile>());
        _mapper = config.CreateMapper();
    }

    [Fact]
    public void Should_Map_AddressRow_To_Address()
    {
        // Arrange
        var addressRow = new AddressRow
        {
            Apartment = "A1",
            Building = "10B",
            Street = "Main St",
            City = "Warsaw",
            PostalCode = "00-001",
            Country = "Poland",
            Id = Guid.NewGuid(),
            InsertTime = DateTime.Now
        };

        // Act
        var address = _mapper.Map<Address>(addressRow);

        // Assert
        Assert.Equal(addressRow.Apartment, address.Apartment);
        Assert.Equal(addressRow.Building, address.Building);
        Assert.Equal(addressRow.Street, address.Street);
        Assert.Equal(addressRow.City, address.City);
        Assert.Equal(addressRow.PostalCode, address.PostalCode);
        Assert.Equal(addressRow.Country, address.Country);
        Assert.Equal(addressRow.Id, address.Id);
    }

    [Fact]
    public void Should_Map_Address_To_AddressRow()
    {
        // Arrange
        var address = new Address
        {
            Apartment = "B2",
            Building = "15C",
            Street = "Second St",
            City = "Krakow",
            PostalCode = "31-002",
            Country = "Poland",
            Id = Guid.NewGuid()
        };

        // Act
        var addressRow = _mapper.Map<AddressRow>(address);

        // Assert
        Assert.Equal(address.Apartment, addressRow.Apartment);
        Assert.Equal(address.Building, addressRow.Building);
        Assert.Equal(address.Street, addressRow.Street);
        Assert.Equal(address.City, addressRow.City);
        Assert.Equal(address.PostalCode, addressRow.PostalCode);
        Assert.Equal(address.Country, addressRow.Country);
        Assert.Equal(address.Id, addressRow.Id);
    }
}