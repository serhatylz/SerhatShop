using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helpers
{
    public enum CartStatus
    {
        ACTIVE,       // Aktif, kullanılmakta olan sepet
        ABANDONED,    // Yarıda bırakılmış, terk edilmiş sepet
        COMPLETED,    // Siparişe dönüştürülmüş, tamamlanmış sepet
        EXPIRED       // Süresi dolmuş, geçerliliğini yitirmiş sepet
    }
    public enum OrderStatus
    {
        PENDING,      // Bekliyor, sipariş alındı ama işleme alınmadı
        PROCESSING,   // İşleniyor, sipariş hazırlanıyor
        SHIPPED,      // Kargoya verildi
        DELIVERED,    // Teslim edildi
        CANCELED,     // İptal edildi
        REFUNDED      // İade edildi (parası geri ödendi)
    }

}
