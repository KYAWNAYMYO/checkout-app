using System;

namespace API.Entities;

public class Product
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public string Description { get; set; } = "";

    public double Price { get; set; }

    public string Currency { get; set; } = "SGD";

    public required string paymentType { get; set; }
}
