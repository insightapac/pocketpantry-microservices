using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Models
{
    [Table("ShoppingList")]
    public class ShoppingList
    {
        public int Id { get; set; }       
        public virtual User User { get; set; }
        public virtual ICollection<ShoppingListItem> ShoppingListItem { get; set; }
    }
}