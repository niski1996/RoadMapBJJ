// See https://aka.ms/new-console-template for more information

using SeederDB;

Console.WriteLine("Hello, World!");

var ConnectionString = $"Host=localhost;Port=6432;Database=test;Username=postgres;Password=postgres;TrustServerCertificate=True;";

var seeder = new Seeder(ConnectionString);
seeder.Seed();

var remover = new Remover(ConnectionString);
// remover.Remove();