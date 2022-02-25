using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Models
{
    public class Post : BaseEntity
    {
        public string PostDate { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
    }
}
