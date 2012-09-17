using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectedCode.Models
{
    class Revision
    {
        public int Version { get; set; }
        public DateTime DateSaved { get; set; }
        public string Code { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
