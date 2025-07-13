using Core.Abstracts.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Utilities.Helpers;

namespace Core.Concretes.Entities
{
    [Table("orderHeaders", Schema = "sales")]
    public class OrderHeader : BaseEntity
    {
        [Required]
        public required string MemberId { get; set; }
        public virtual Member? Member { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = [];
        public  decimal TotalDue { get; set; }
        public decimal TotalDiscount { get; set; } 
        public decimal TotalTax { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.PENDING;
    }


}
