using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Concretes.Entities;
using System.Security.Cryptography.X509Certificates;

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

    }
}
   
