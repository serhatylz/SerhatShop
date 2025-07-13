using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Concretes.Entities
{
    //Junction Table : İki tablonun birnbirine primerary keyleri üzerinden Many to Many bağlantı yapılabilmesi için kullanılır.EFCore bunu otomatik olarak oluşturur. İki anahtar tek bir priemry key (composite key) olarak tanımlanır.
    [Table("productTags", Schema = "production")]
    public class ProductTag
    {
        [Key, Column(Order = 0)]
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        [Key, Column(Order = 1)]
        public int TagId { get; set; }
        public virtual Tag? Tag { get; set; }
    }
}
