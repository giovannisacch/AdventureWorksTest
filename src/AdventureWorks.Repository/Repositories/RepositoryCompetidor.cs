using AdventureWorks.Repository.Context;
using AdventureWorks.Repository.Interfaces;
using AdventureWorks.Repository.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Repository.Repositories
{
    public class RepositoryCompetidor : RepositoryBase<Model.Competidor>, IRepositoryCompetidor
    {
        public RepositoryCompetidor(AdventureContext context) : base(context)
        {
           
        }
    }
}
