using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Concretes.Entities
{
    [Table("attributes", Schema = "production")]
    public class ProductAttribute
    {
        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]// Burayı eklersek Auto Increment özelliği devre dışı kalır
        public int Id { get; set; }

        [Required]
        public required int ProductId { get; set; }
        public virtual Product? Product { get; set; }

        [Required]
        public required string AttributeName { get; set; }

        [Required]
        public required string Value { get; set; }
    }
}
