using System;
using System.Collections.Generic;
using System.Text;

namespace Task7.Core.Entities
{
    public class EntityBase<TPrimaryKey> where TPrimaryKey : struct
    {
        public TPrimaryKey Id { get; set; }
    }
}
