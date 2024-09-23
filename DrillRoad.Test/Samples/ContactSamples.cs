using DrillRoad.Contracts.Tables.Account;
using DrillRoad.Entities.Account;

namespace DrillRoad.Test.Samples
{
    public static class ContactSamples
    {

        // Tworzenie przykładowych instancji Contact
        public static ContactRow Contact1 { get; } = new()
        {
            Address = AddressSamples.Address1,
            PhoneNumber = "123-456-7890",
            Email = "admin@example.com",
            Id = Guid.NewGuid()
        };

        public static ContactRow Contact2 { get; } = new()
        {
            Address = AddressSamples.Address2,
            PhoneNumber = "234-567-8901",
            Email = "user1@example.com",
            Id = Guid.NewGuid()
        };

        public static ContactRow Contact3 { get; } = new()
        {
            Address = AddressSamples.Address3,
            PhoneNumber = "345-678-9012",
            Email = "user2@example.com",
            Id = Guid.NewGuid()
        };

        public static ContactRow Contact4 { get; } = new()
        {
            Address = AddressSamples.Address4,
            PhoneNumber = "456-789-0123",
            Email = "user3@example.com",
            Id = Guid.NewGuid()
        };

        public static ContactRow Contact5 { get; } = new()
        {
            Address = AddressSamples.Address5,
            PhoneNumber = "567-890-1234",
            Email = "user4@example.com",
            Id = Guid.NewGuid()
        };

        // Lista wszystkich kontaktów
        public static List<ContactRow> AllContacts { get; } = new()
        {
            Contact1,
            Contact2,
            Contact3,
            Contact4,
            Contact5
        };
    }
}