using System;
using System.Collections.Generic;

namespace Shopping.Models
{
    public partial class Pantry
    {
        public Pantry()
        {
            PantryItem = new HashSet<PantryItem>();
        }

        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
        public ICollection<PantryItem> PantryItem { get; set; }
    }
}
