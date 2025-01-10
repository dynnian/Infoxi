using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infoxi.Models;

public class City
{
    [Key]
    public int Id { get; set; }

    [StringLength(128)]
    public required string Name { get; set; }

    public required Country Country { get; set; }

    public required float Latitude { get; set; }

    public required float Longitude { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}