using Core.Abstracts.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Concretes.Entities
{
    public class Review : BaseEntity 
    {
        [Table("reviews", Schema = "production")]
        [Required]
        public required int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        [Required]
        public required string MemberId { get; set; }
        public virtual Member? Member { get; set; }
        [Required]
        [Range (1,5)]
        public required int Rating { get; set; }
        public string? Commennt { get; set; }
    }
}
