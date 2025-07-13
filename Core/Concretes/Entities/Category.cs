using Core.Abstracts.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Concretes.Entities
{
    [Table("Categories", Schema = "production")]
    public class Category : BaseEntity
    {
        [Required]
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? CoverImagePath { get; set; }
        public int ParentCategoryId { get; set; } = 0;  // 0, üst kategori yok demektir
        public virtual Category? Parent { get; set; }
    }
}
