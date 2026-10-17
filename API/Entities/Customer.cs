using System;

namespace API.Entities;

public class Customer
{
    public int Id { get; set; }

    public required string FirstName { get; set; } 

    public required string LastName { get; set; }

    public string Email { get; set; } = "";
}
