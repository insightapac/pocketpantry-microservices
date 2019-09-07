using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("RecipeCollection")]
    public class RecipeCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
