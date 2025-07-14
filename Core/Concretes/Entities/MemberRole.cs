using System.ComponentModel.DataAnnotations.Schema;
using Utilities.Helpers;
using Microsoft.AspNetCore.Identity;

namespace Core.Concretes.Entities
{
    [Table("memberRoles", Schema = "sales")]
    public class MemberRole : IdentityRole
    {
    public string? Description { get; set; }
        public UserType MemberType { get; set; } = UserType.ORDINARY_CUSTOMER;
    }
}
