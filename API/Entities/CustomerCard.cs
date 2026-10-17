using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Entities;

public class CustomerCard
{
    public int Id { get; set; }

    [JsonIgnore]
    [ForeignKey(nameof(Id))]
    public Customer Customer { get; set; } = null!;   
    //public int CustomerId { get; set; }

    public required string CustomerToken { get; set; }

    public required string MaskedCardNo { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
