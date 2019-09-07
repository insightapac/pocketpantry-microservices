using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("MasterFoodItem")]
    public class MasterFoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
