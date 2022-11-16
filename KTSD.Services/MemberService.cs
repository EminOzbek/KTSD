using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class MemberService : IMemberService
    {
        private readonly IUnitOfWork _uow;

        public MemberService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<IEnumerable<Member>> GetAll()
        {
            return await _uow.Members.GetAllAsync();
        }

        public async Task<Member> GetById(int id)
        {
            return await _uow.Members.GetByIdAsync(id);
        }

        public async Task<Member> Create(Member item)
        {
            await _uow.Members.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Update(Member item)
        {
            _uow.Members.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var member = await _uow.Members.GetByIdAsync(id);
            _uow.Members.Remove(member);
            await _uow.SaveAsync();
        }
    }
}