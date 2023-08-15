using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingSQLite;

public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [StringLength(40)]
    public string ProductName { get; set; } = null!;

    [Column("UnitPrice", TypeName = "Money")]
    public double Cost { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;
}