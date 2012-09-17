using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectedCode.Models
{
    class Tag
    {
        // TODO: could use name for id??
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Snippet> Snippets { get; set; }
    }
}
