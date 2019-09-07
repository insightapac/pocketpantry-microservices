using System;
using System.Collections.Generic;

namespace Shopping.Models
{
    public partial class RecipeSteps
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int StepNumber { get; set; }
        public string Description { get; set; }

        public Recipe Recipe { get; set; }
    }
}
