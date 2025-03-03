using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infoxi.Models;

public class Address
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(128)]
    public required string Address1 { get; set; }

    [StringLength(128)]
    public string? Address2 { get; set; }

    public required City City { get; set; }

    public required State State { get; set; }

    [StringLength(16)]
    public string? PostalCode { get; set; }

    public required Country Country { get; set; }

    public AddressType? AddressType { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}