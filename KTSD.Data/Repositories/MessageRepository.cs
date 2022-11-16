using KTSD.Core.Models;
using KTSD.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace KTSD.Data.Repositories
{
    public class MessageRepository: Repository<Message>, IMessageRepository
    {
        public MessageRepository(KTSDDbContext context) : base(context)
        {
        }
    }
}