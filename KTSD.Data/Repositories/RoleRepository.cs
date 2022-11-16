using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Repository;

namespace KTSD.Data.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        
        public RoleRepository(KTSDDbContext context)
            : base(context)
        {
        }
    }
}