using Core.Concretes.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contexts
{
    public class ShopContext : IdentityDbContext<Member, MemberRole, string>
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {


        }
        #region Production Scheme

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<ProductAttribute> Attributes { get; set; }
        public virtual DbSet<Reaction> Reactions { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<ProductMedia> MediaGallery { get; set; }

        #endregion

        #region Sales Scheme

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<OrderHeader> OrderHeaders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Varsayılan şema adı "account" olarak ayarlanır.
            // Bu sayede tüm tablolar "account" şeması altında toplanır.
            modelBuilder.HasDefaultSchema("account");

            // Kullanıcı-rol eşleştirmesi tablosu, özel isimle yeniden adlandırılır.
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("memberMemberRoles");
            });

            // Kullanıcıların sahip olabileceği claim bilgileri için tablo adı belirlenir.
            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("memberClaims");
            });

            // Kullanıcı giriş bilgilerini (örneğin dış sağlayıcılar) tutan tablo adı belirlenir.
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("memberLogins");
            });

            // Rollerle ilişkilendirilmiş claim’leri tutan tablo adı belirlenir.
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("memberRoleClaims");
            });

            // Kullanıcılara ait token bilgilerinin tutulduğu tablo adı belirlenir.
            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("memberTokens");
            });
        }
    }
}
   
