using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class Education
{
    [Key]
    public int Id { get; set; }

    public required Company School { get; set; }

    public required Person Person { get; set; }

    public EducationDegree? Degree { get; set; }

    public EducationCarreer? Carreer { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool IsCurrent { get; set; } = false;

    public bool IsGraduated { get; set; } = false;

    public bool IsSuspended { get; set; } = false;

    public bool IsAbandoned { get; set; } = false;

    public bool IsDeleted { get; set; } = false;

    [Range(0.00, 4.00)]
    public float? Gpa { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}