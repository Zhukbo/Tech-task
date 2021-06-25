using System;
using System.Collections.Generic;
using System.Text;

namespace Task7.Core.Entities
{
    public class Transition : EntityBase<int>
    {
        public int TransitionCount { get; set; }
        public int LinkId { get; set; }
        public Link Link { get; set; }
    }
}
