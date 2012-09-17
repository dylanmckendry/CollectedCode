using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectedCode.Models
{
    class Comment
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime DatePosted { get; set; }
        public Revision Revision { get; set; }
    }
}
