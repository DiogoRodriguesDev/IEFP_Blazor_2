using System.ComponentModel.DataAnnotations.Schema;

namespace DotNet001API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }

    }
}
