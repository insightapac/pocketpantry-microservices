using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceOCR.Models
{
    public class RootObject
    {
        public string _id { get; set; }
        public string object_type { get; set; }
        public List<Category> categories { get; set; }
        public List<Unit> units { get; set; }
    }
}
