using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("RecipeCategory")]
    public class RecipeCollections
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
