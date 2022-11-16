using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class ContactInfoService: IContactInfoService
    {
        private readonly IUnitOfWork _uow;
        
        public ContactInfoService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<IEnumerable<ContactInfo>> GetAll()
        {
            return await _uow.ContactInfos.GetAllAsync();
        }

        public async Task<ContactInfo> GetById(int id)
        {
            return await _uow.ContactInfos.GetByIdAsync(id);
        }

        public async Task<ContactInfo> Create(ContactInfo item)
        {
            await _uow.ContactInfos.AddAsync(item);
            await _uow.SaveAsync();
            return await _uow.ContactInfos.SingleOrDefaultAsync(p => p.Id == item.Id);
        }

        public async Task Update(ContactInfo item)
        {
            _uow.ContactInfos.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var contactInfo = await _uow.ContactInfos.GetByIdAsync(id);
            _uow.ContactInfos.Remove(contactInfo);
            await _uow.SaveAsync();
        }
    }
}