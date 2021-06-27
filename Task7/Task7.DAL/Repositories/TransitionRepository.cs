using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Task7.Core.Entities;
using Task7.Core.Repositories;

namespace Task7.DAL.Repositories
{
    public class TransitionRepository : RepositoryBase<Transition, int>, ITransitionRepository
    {
        public TransitionRepository(ApplicationContext context) :base(context)
        {

        }
    }
}
