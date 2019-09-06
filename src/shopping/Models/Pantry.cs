using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("Pantry")]
    public class Pantry
    {
        public int Id { get;set }
        public string Name { get; set }
        public virtual User User { get; set; }
        public virtual ICollection<PantryItem> PantryItem { get; set; }
    }
}
