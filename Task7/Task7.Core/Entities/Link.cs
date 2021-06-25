using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Task7.Core.Entities
{
    public class Link : EntityBase<int>
    {
        public string OriginalLink { get; set; }
        public string ShortLink { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
