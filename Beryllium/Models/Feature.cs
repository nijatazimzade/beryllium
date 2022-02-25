using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Models
{
    public class Feature : BaseEntity
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string BtnText { get; set; }

    }
}
