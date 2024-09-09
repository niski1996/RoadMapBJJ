using System.Net.Mail;
using RoadMapBJJ.Contracts.Common;

namespace RoadMapBJJ.Contracts.Entities.Persons;

public class Contact: IEntity
{
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Guid ID { get; set; }
}