using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("User")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Pantry Pantry { get; set; }
        public virtual ShoppingList ShoppingList { get; set; }
    }
}
