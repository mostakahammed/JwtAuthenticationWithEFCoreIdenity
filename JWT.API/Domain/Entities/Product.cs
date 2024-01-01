using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWT.API.Domain.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProductName { get; set; }
    }
}
