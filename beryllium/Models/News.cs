using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Models
{
    public class News: Base
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
    }
}
