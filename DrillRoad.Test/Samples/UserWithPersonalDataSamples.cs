using DrillRoad.Entities.Account;

namespace DrillRoad.Test.Samples
{
    public static class UserWithPersonalDataSamples
    {
        // Tworzenie przykładowych instancji UserWithPersonalData
        public static UserWithPersonalData User1 { get; } = new UserWithPersonalData
        {
            PictureRepoPatch = "/images/user1.jpg",
            Contact = ContactSamples.Contact1,
            JoinDate = DateTime.UtcNow.AddMonths(-6) // Przyklad: dołączenie 6 miesięcy temu
        };

        public static UserWithPersonalData User2 { get; } = new UserWithPersonalData
        {
            PictureRepoPatch = "/images/user2.jpg",
            Contact = ContactSamples.Contact2,
            JoinDate = DateTime.UtcNow.AddMonths(-3) // Przyklad: dołączenie 3 miesiące temu
        };

        public static UserWithPersonalData User3 { get; } = new UserWithPersonalData
        {
            PictureRepoPatch = "/images/user3.jpg",
            Contact = ContactSamples.Contact3,
            JoinDate = DateTime.UtcNow.AddMonths(-1) // Przyklad: dołączenie 1 miesiąc temu
        };

        public static UserWithPersonalData User4 { get; } = new UserWithPersonalData
        {
            PictureRepoPatch = "/images/user4.jpg",
            Contact = ContactSamples.Contact4,
            JoinDate = DateTime.UtcNow // Przyklad: dołączenie teraz
        };

        public static UserWithPersonalData User5 { get; } = new UserWithPersonalData
        {
            PictureRepoPatch = "/images/user5.jpg",
            Contact = ContactSamples.Contact5,
            JoinDate = DateTime.UtcNow.AddMonths(-2) // Przyklad: dołączenie 2 miesiące temu
        };

        // Lista wszystkich użytkowników
        public static List<UserWithPersonalData> AllUsers { get; } = new List<UserWithPersonalData>
        {
            User1,
            User2,
            User3,
            User4,
            User5
        };
    }
}
