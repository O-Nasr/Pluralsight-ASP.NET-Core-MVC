using System.Collections.Generic;

namespace BethanysPiShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
