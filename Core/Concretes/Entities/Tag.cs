using Core.Abstracts.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Concretes.Entities
{
    [Table("tags", Schema = "production")]
    public class Tag : BaseEntity
    {
        [Required]
        public required string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; } = [];
    }
}
