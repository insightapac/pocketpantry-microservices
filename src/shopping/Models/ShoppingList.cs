using System;
using System.Collections.Generic;

namespace Shopping.Models
{
    public partial class ShoppingList
    {
        public ShoppingList()
        {
            ShoppingListItem = new HashSet<ShoppingListItem>();
        }

        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
        public ICollection<ShoppingListItem> ShoppingListItem { get; set; }
    }
}
