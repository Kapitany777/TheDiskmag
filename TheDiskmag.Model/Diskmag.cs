using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiskmag.Model
{
    public class Diskmag
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }

        public List<Article> Articles { get; set; }
    }
}
