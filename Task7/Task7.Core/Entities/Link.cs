using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Text;

namespace Task7.Core.Entities
{
    public class Link : EntityBase<int>
    {
        [Required]
        public string OriginalLink { get; set; }
        [Required]
        public string ShortLink { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
