using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectedCode.Models
{
    public class Snippet
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Language Language { get; set; }
        public ICollection<Revision> Revisions { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
