using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infoxi.Models;

public class PhoneNumber
{
    [Key]
    public int Id { get; set; }

    [StringLength(32)]
    public required string Number { get; set; }

    public PhoneNumberType Type { get; set; }

    public Country Country { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}