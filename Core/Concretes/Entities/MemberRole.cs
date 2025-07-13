using System.ComponentModel.DataAnnotations.Schema;
using Utilities.Helpers;

namespace Core.Concretes.Entities
{
    [Table("memberRoles", Schema = "sales")]
    public class MemberRole 
    {
    public string? Description { get; set; }
        public UserType MemberType { get; set; } = UserType.ORDINARY_CUSTOMER;

    }


}
