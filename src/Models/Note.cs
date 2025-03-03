using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class Note<TEntity>
{
    [Key]
    public Guid Id { get; set; }

    public TEntity? Entity { get; set; }

    public string Content { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}