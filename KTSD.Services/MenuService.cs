using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class MenuService : IMenuService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public MenuService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<NavMenu>> GetAll()
        {
            return await _uow.Menus.GetAllAsync();
        }

        public async Task<NavMenu> GetById(int id)
        {
            return await _uow.Menus.GetByIdAsync(id);
        }

        public async Task<NavMenu> Create(NavMenu item)
        {
            await _uow.Menus.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Update(NavMenu item)
        {
            _uow.Menus.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var menu = await _uow.Menus.GetByIdAsync(id);
            _uow.Menus.Remove(menu);
            await _uow.SaveAsync();
        }

        public IEnumerable<NavMenuListRes> GetMenusWithChildren()
        {
            var menuList = _uow.Menus.Find(p => p.ParentID == null && p.Status == 1);
            var menuResList = _mapper.Map<IEnumerable<NavMenuListRes>>(menuList);
            foreach (var navMenu in menuResList)
            {
                var navMenuChildren = _uow.Menus.Find(p => p.ParentID == navMenu.Id && p.Status == 1);
                navMenu.Children = _mapper.Map<IEnumerable<NavMenuListRes>>(navMenuChildren);
                foreach (var child in navMenu.Children)
                {
                   var subChildren = _uow.Menus.Find(p => p.ParentID == child.Id && p.Status == 1);
                   child.Children = _mapper.Map<IEnumerable<NavMenuListRes>>(subChildren);
                }
            }

            return menuResList;
        }
    }
}