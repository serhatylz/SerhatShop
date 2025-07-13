using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstracts.BaseModels
{
    public abstract class BaseEntity
    {
        [Key]
        // Her nesneye özel benzersiz kimlik (Primary Key)
        public int Id { get; set; }

        // Nesnenin oluşturulduğu zamanı UTC formatında saklar
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Kayıt aktif mi değil mi bilgisini tutar (true = aktif)
        public bool Active { get; set; } = true;

        // Kayıt silindi mi? (Soft delete: true = silinmiş gibi davranılır ama fiziksel olarak veritabanından silinmez)
        public bool Deleted { get; set; } = false;

    }
}
