using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("RecipeSteps")]
    public class RecipeSteps
    {
        public int Id { get; set; }        
        public int StepNumber { get; set; }
        public string Description { get; set; }
        
        public virtual Recipe Recipe { get; set; }
    }
}
