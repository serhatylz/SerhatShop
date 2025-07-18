using Core.Concretes.Entities;
using Data.Contexts;
using Data.Repositories;
using Utilities.Generics;

namespace Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ShopContext context) : base(context) { }
    }

    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ShopContext context) : base(context) { }
    }

    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(ShopContext context) : base(context) { }
    }

    public class AttributeRepository : Repository<Attribute>, IAttributeRepository
    {
        public AttributeRepository(ShopContext context) : base(context) { }
    }

    public class ReactionRepository : Repository<Reaction>, IReactionRepository
    {
        public ReactionRepository(ShopContext context) : base(context) { }
    }

    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(ShopContext context) : base(context) { }
    }

    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(ShopContext context) : base(context) { }
    }

    public class ProductMediaRepository : Repository<ProductMedia>, IProductMediaRepository
    {
        public ProductMediaRepository(ShopContext context) : base(context) { }
    }

    public class CartRepository : Repository<Cart>, ICartRepository
    {
        public CartRepository(ShopContext context) : base(context) { }
    }

    public class CartItemRepository : Repository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(ShopContext context) : base(context) { }
    }

    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        public OrderHeaderRepository(ShopContext context) : base(context) { }
    }

    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(ShopContext context) : base(context) { }
    }
}
