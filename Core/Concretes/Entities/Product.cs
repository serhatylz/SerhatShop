using Core.Abstracts.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Concretes.Entities
{
    [Table("Products", Schema = "production")]
    public class Product : BaseEntity
    {
        [Required]
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? ExpirationDate { get; set; } = null;
        public string? Origin { get; set; }
        [Required]
        public int MakerFlag { get; set; } = 0; // 0: Local, 1: Import, 2: Export
        [Required]
        public int CoverImageId { get; set; }
        [Required]
        public decimal ListePrice { get; set; }
        [Required]
        public decimal DiscountRate { get; set; } = 0;
        [Required]
        public decimal TaxRate { get; set; }
        [Required]
        public int CoverImageType { get; set; } // 0: Image, 1: Video, 2: Document, 3: Audio, 4: Embed
        public virtual ICollection<ProductMedia> MediaLibrary { get; set; } = [];
        [Required]
        public int BrandId { get; set; }
        public virtual Brand? Brand { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<Tag> Tags { get; set; } = [];
        public virtual ICollection<CartItem> CartItems { get; set; } = [];
        public virtual ICollection<OrderDetail> OrderItems{ get; set; } = [];
        public virtual ICollection<Reaction> Reactions { get; set; } = [];
        public virtual ICollection<Review> Reviews { get; set; } = [];
    }
}
