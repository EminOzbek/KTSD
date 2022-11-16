using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class WeeklyInfoService: IWeeklyInfoService
    {
        private readonly IUnitOfWork _uow;

        public WeeklyInfoService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<WeeklyInfo>> GetAll()
        {
            return await _uow.WeeklyInfos.GetAllAsync();
        }

        public async Task<WeeklyInfo> GetById(int id)
        {
            return await _uow.WeeklyInfos.GetByIdAsync(id);
        }

        public async Task<WeeklyInfo> Create(WeeklyInfo item)
        {
            await _uow.WeeklyInfos.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Update(WeeklyInfo item)
        {
            _uow.WeeklyInfos.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var weeklyInfo = await _uow.WeeklyInfos.GetByIdAsync(id);
            _uow.WeeklyInfos.Remove(weeklyInfo);
            await _uow.SaveAsync();
        }
    }
}