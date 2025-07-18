using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstracts
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IBrandRepository BrandRepository { get; }
        ICartRepository CartRepository { get; }
        ICartItemRepository CartItemRepository { get; }
        IOrderHeaderRepository OrderHeaderRepository { get; }
        IOrderDetailRepository OrderDetailRepository { get; }
        IAttributeRepository AttributeRepository { get; }
        IProductMediaRepository ProductMediaRepository { get; }
        IReactionRepository ReactionRepository { get; }
        IReviewRepository ReviewRepository { get; }
        ITagRepository TagRepository { get; }
        Task CommitAsync();
    }
    }
