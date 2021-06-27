using System;
using System.Collections.Generic;
using System.Text;
using Task7.Core.Entities;
using Task7.Core.Repositories;

namespace Task7.DAL.Repositories
{
    public class LinkRepository : RepositoryBase<Link,int>, ILinkRepository
    {
        public LinkRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
