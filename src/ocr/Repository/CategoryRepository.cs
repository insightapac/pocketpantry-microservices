using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroServiceOCR.DBContexts;
using MicroServiceOCR.Models;

namespace MicroServiceOCR.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CategoryContext _dbContext;

        public CategoryRepository(CategoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public Category GetCategory(int categoryId)
        {
            return _dbContext.Categories.Find(categoryId);
        }
    }
}
