using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Shopping.Models.Dtos
{
    public class CategoryDto
    {
        /*  img: 'https://www.tasteofhome.com/wp-content/uploads/2018/01/exps28800_UG143377D12_18_1b_RMS-696x696.jpg',
        name: 'All burgers',
        filters: ['burgers'] */
        [DataMember(Name = "img")]
        public string Img { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "Filters")]
        public string[] Filters { get; set; }
    }
}
