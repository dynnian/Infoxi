using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class Person
{
    [Key]
    public int Id { get; set; }

    [StringLength(32)]
    public string? IdNumber { get; set; }

    [StringLength(32)]
    public string? PassportNumber { get; set; }

    [StringLength(64)]
    public required string FirstName { get; set; }

    [StringLength(64)]
    public string? LastName { get; set; }

    public Gender? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public List<PhoneNumber>? PhoneNumbers { get; set; }

    public List<Email>? Emails { get; set; }

    public List<Address>? Addresses { get; set; }

    public float? Height { get; set; }

    public float? Weight { get; set; }

    public BloodType? BloodType { get; set; }

    public Color? FavoriteColor { get; set; }

    public Color? HairColor { get; set; }

    public Color? EyeColor { get; set; }

    public bool HasScars { get; set; }

    [StringLength(512)]
    public string? WhereScars { get; set; }

    public Media? ProfilePicture { get; set; }

    public List<Media>? AssociatedMedia { get; set; }

    public List<Website>? Websites { get; set; }

    public List<Interests> Interests { get; set; }

    public List<Hobbies> Hobbies { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}