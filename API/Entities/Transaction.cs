using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Entities;

public class Transaction
{
    public int Id { get; set; }

    [JsonIgnore]
    [ForeignKey(nameof(Id))]
    public Customer Customer { get; set; } = null!;    
    //public int CustomerId { get; set; }

    [JsonIgnore]
    [ForeignKey(nameof(Id))]
    public Product Product { get; set; } = null!;   
    //public int ProductId { get; set; }

    public required string InvoiceNo { get; set; }

    public required string IdempotencyKey { get; set; }

    public double Amount { get; set; }

    public string Currency { get; set; } = "SGD";

    public required string Status { get; set; }

    public required string PaymentChannel { get; set; }

    public required string MaskedCardNo { get; set; }

    public required string ProviderRef { get; set; }

    public required string ResponseCode { get; set; }

    public required string ResponseDescription { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime PaidAt { get; set; } = DateTime.UtcNow;

}
