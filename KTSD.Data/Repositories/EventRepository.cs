using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace KTSD.Data.Repositories
{
    public class EventRepository: Repository<Event>, IEventRepository
    {
        private KTSDDbContext KTSDDbContext => Context as KTSDDbContext;

        public EventRepository(KTSDDbContext context) : base(context)
        {
        }
    }
}