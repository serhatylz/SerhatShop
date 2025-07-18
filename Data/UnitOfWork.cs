using Core.Abstracts;
using Data.Contexts;
using Data.Repositories;
using Data.Repository;
using System.Linq.Expressions;

public class UnitOfWork : IUnitOfWork
{
    private readonly ShopContext context;

    public UnitOfWork(ShopContext context)
    {
        this.context = context;
    }

    private IProductRepository productRepository;
    public IProductRepository ProductRepository =>
        productRepository ??= new ProductRepository(context);

    private ICategoryRepository categoryRepository;
    public ICategoryRepository CategoryRepository =>
        categoryRepository ??= new CategoryRepository(context);

    private IBrandRepository brandRepository;
    public IBrandRepository BrandRepository =>
        brandRepository ??= new BrandRepository(context);

    private ICartRepository cartRepository;
    public ICartRepository CartRepository =>
        cartRepository ??= new CartRepository(context);

    private ICartItemRepository cartItemRepository;
    public ICartItemRepository CartItemRepository =>
        cartItemRepository ??= new CartItemRepository(context);

    private IOrderHeaderRepository orderHeaderRepository;
    public IOrderHeaderRepository OrderHeaderRepository =>
        orderHeaderRepository ??= new OrderHeaderRepository(context);

    private IOrderDetailRepository orderDetailRepository;
    public IOrderDetailRepository OrderDetailRepository =>
        orderDetailRepository ??= new OrderDetailRepository(context);

    private IAttributeRepository attributeRepository;
    public IAttributeRepository AttributeRepository =>
        attributeRepository ??= new AttributeRepository(context);

    private IProductMediaRepository productMediaRepository;
    public IProductMediaRepository ProductMediaRepository =>
        productMediaRepository ??= new ProductMediaRepository(context);

    private IReactionRepository reactionRepository;
    public IReactionRepository ReactionRepository =>
        reactionRepository ??= new ReactionRepository(context);

    private IReviewRepository reviewRepository;
    public IReviewRepository ReviewRepository =>
        reviewRepository ??= new ReviewRepository(context);

    private ITagRepository tagRepository;
    public ITagRepository TagRepository =>
        tagRepository ??= new TagRepository(context);

    public async Task CommitAsync()
    {
        try
        {
            await context.SaveChangesAsync();
        }
        catch (Exception)
        { 
            await DisposeAsync();
        }
        
    }

    public ValueTask DisposeAsync()
    {
        return context.DisposeAsync();
    }
}
