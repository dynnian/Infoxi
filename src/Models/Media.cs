using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class Media
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(512)]
    public string FileName { get; set; }

    [StringLength(256)]
    public string ContentType { get; set; }

    [StringLength(512)]
    public string FilePath { get; set; }

    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}