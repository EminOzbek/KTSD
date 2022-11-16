using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Services
{
    public interface ISettingsService: ICrudService<Settings>
    {
        Task<Settings> GetByLangCode(string langCode);
    }
}