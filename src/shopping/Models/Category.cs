using System;
using System.Collections.Generic;

namespace Shopping.Models
{
    public partial class Category
    {
        public Category()
        {
            Recipe = new HashSet<Recipe>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUri { get; set; }
        public string Filters { get; set; }
        public ICollection<Recipe> Recipe { get; set; }
    }
}
