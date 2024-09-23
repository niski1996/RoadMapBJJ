using System;
using System.Collections.Generic;

namespace DrillRoad.Entities.Persons
{
    public static class AddressSamples
    {
        public static Address Address1 { get; } = new()
        {
            Apartment = "A1",
            Building = "Building 1",
            Street = "Main Street",
            City = "Springfield",
            PostalCode = "12345",
            Country = "USA",
            Id = Guid.NewGuid()
        };

        public static Address Address2 { get; } = new()
        {
            Apartment = null,
            Building = "Building 2",
            Street = "Second Street",
            City = "Shelbyville",
            PostalCode = "54321",
            Country = "USA",
            Id = Guid.NewGuid()
        };

        public static Address Address3 { get; } = new()
        {
            Apartment = "B2",
            Building = "Building 3",
            Street = "Third Avenue",
            City = "Capital City",
            PostalCode = "67890",
            Country = "USA",
            Id = Guid.NewGuid()
        };

        public static Address Address4 { get; } = new()
        {
            Apartment = "C3",
            Building = "Building 4",
            Street = "Fourth Road",
            City = "Metropolis",
            PostalCode = "10112",
            Country = "USA",
            Id = Guid.NewGuid()
        };

        public static Address Address5 { get; } = new()
        {
            Apartment = null,
            Building = "Building 5",
            Street = "Fifth Boulevard",
            City = "Gotham",
            PostalCode = "33333",
            Country = "USA",
            Id = Guid.NewGuid()
        };

        // Lista wszystkich adresów
        public static List<Address> AllAddresses { get; } = new()
        {
            Address1,
            Address2,
            Address3,
            Address4,
            Address5
        };
    }
}