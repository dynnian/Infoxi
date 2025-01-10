using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class Company
{
    [Key]
    public int Id { get; set; }

    [StringLength(256)]
    public string Name { get; set; }

    [StringLength(512)]
    public string? Description { get; set; }

    public Industry Industry { get; set; }

    public Address? Headquarter { get; set; }

    public List<Address>? Addresses { get; set; }

    public List<PhoneNumber>? PhoneNumbers { get; set; }

    public List<Email>? Emails { get; set; }

    public LegalForm? LegalForm { get; set; }

    public List<Media>? AssociatedMedia { get; set; }

    public List<Company>? Subsidiaries { get; set; }

    public List<Website>? Websites { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}