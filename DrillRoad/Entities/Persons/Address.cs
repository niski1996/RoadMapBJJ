﻿using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.Common;

namespace DrillRoad.Entities.Persons;

public class Address  : IAddress
{
    public string? Apartment { get; set; }
    public required string Building { get; set; }
    public string? Street { get; set; }
    public required string City { get; set; }
    public required string PostalCode { get; set; }
    public required string Country { get; set; }
    public Guid Id { get; set; } = new Guid();
}

