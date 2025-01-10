using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class Relation
{
    [Key]
    public int Id { get; set; }

    public required Person SourcePerson { get; set; }

    public required Person TargetPerson { get; set; }

    public RelationName? RelationName { get; set; }

    public RelationType? RelationType { get; set; }

    [Range(1, 5)]
    public int? Affinity { get; set; }

    public DateTime? RelatedSince { get; set; }

    public bool IsOngoing { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}