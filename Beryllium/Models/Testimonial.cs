using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Models
{
    public class Testimonial : BaseEntity
    {
        public string Text { get; set; }
        public string Author { get; set; }

    }
}
