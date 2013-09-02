using Funfik.Core.DataAccess;
using Funfik.Core.Entities;
using Funfik.Core.Interfaces.EntityServiceInterfaces;

namespace Funfik.Core.Services.EntityServices
{
    /// <summary>
    /// A service which provides category-related functionality.
    /// </summary>
    public class CategoryService: ICategoryService
    {
        private FunfikDb Database { get; set; }

        public CategoryService()
        {
            Database = new FunfikDb();
        }

        System.Collections.Generic.IEnumerable<Category> ICategoryService.GetCategories()
        {
            return Database.Categories;
        }
    }
}
