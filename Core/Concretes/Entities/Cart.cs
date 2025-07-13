using Core.Abstracts.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helpers;

namespace Core.Concretes.Entities
{

    [Table("carts", Schema = "sales")]
    public class Cart : BaseEntity
    {
        [Required]
        public required string MemberId { get; set; }
        public virtual Member? Member { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; } = [];
        public CartStatus Status { get; set; }
    }
}
