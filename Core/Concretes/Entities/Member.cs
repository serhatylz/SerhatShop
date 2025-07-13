using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Core.Concretes.Entities
{
    [Table("members", Schema = "sales")]
    public class Member :IdentityUser
    {
        [Required]
        public required string FirstName { get; set; }
        [Required]
        public required string LastName { get; set; }
        public string? ProfileImagePath { get; set; }
        public string? Bİography { get; set; }
        [Required]  
        public required DateTime? DateofBirth { get; set; } 
        public char? Gender { get; set; }
        public virtual ICollection<Cart> Carts { get; set; } = [];
        public virtual ICollection<OrderHeader> Orders { get; set; } = [];
        public virtual ICollection<Reaction> Reactions { get; set; } = [];
        public virtual ICollection<Review> Reviews { get; set; } = [];
    }


}
