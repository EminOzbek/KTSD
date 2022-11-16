using KTSD.Core.Models;
using KTSD.Core.Repository;

namespace KTSD.Data.Repositories
{
    public class ContactInfoRepository: Repository<ContactInfo>, IContactInfoRepository
    {
        public ContactInfoRepository(KTSDDbContext context) : base(context)
        {
        }
    }
}