using Core.Concretes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Generics;

namespace Data.Repositories
{
    public interface IProductRepository : IRepository<Product> { }
    public interface ICategoryRepository : IRepository<Category> { }
    public interface IBrandRepository : IRepository<Brand> { }
    public interface IAttributeRepository : IRepository<Attribute> { }
    public interface IReactionRepository : IRepository<Reaction> { }
    public interface IReviewRepository : IRepository<Review> { }
    public interface ITagRepository : IRepository<Tag> { }
    public interface IProductMediaRepository : IRepository<ProductMedia> { }
    public interface ICartRepository : IRepository<Cart> { }
    public interface ICartItemRepository : IRepository<CartItem> { }
    public interface IOrderHeaderRepository : IRepository<OrderHeader> { }
    public interface IOrderDetailRepository : IRepository<OrderDetail> { }
}

