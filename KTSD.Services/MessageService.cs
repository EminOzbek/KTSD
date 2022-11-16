using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class MessageService: IMessageService
    {
        private readonly IUnitOfWork _uow;

        public MessageService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Message>> GetAll()
        {
            return await _uow.Messages.GetAllAsync();
        }

        public async Task<Message> GetById(int id)
        {
            return await _uow.Messages.GetByIdAsync(id);
        }

        public async Task<Message> Create(Message item)
        {
            await _uow.Messages.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Update(Message item)
        {
            _uow.Messages.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var message = await _uow.Messages.GetByIdAsync(id);
            _uow.Messages.Remove(message);
            await _uow.SaveAsync();
        }
    }
}