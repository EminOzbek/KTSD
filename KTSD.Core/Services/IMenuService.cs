using System.Collections.Generic;
using KTSD.Core.Models;

namespace KTSD.Core.Services
{
    public interface IMenuService : ICrudService<NavMenu>
    {
        IEnumerable<NavMenuListRes> GetMenusWithChildren();
    }
}