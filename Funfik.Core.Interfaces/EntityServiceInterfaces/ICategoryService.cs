using System.Collections.Generic;
using Funfik.Core.Entities;

namespace Funfik.Core.Interfaces.EntityServiceInterfaces
{
    /// <summary>
    /// An interface for category-related functionality.
    /// </summary>
    public interface ICategoryService
    {
        /// <summary>
        /// Gets all categories from database.
        /// </summary>
        IEnumerable<Category> GetCategories();
    }
}
