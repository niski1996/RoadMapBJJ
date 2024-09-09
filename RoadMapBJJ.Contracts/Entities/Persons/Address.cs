using RoadMapBJJ.Contracts.Common;

namespace RoadMapBJJ.Contracts.Entities.Persons;

public class Address  : IEntity
{
    public string Apartment { get; set; }
    public string Building { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public Guid ID { get; set; }
}