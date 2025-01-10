using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class Email
{
    [Key] public int Id { get; set; }

    [EmailAddress] [StringLength(256)] public required string Address { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}