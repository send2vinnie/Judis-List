using System.Threading.Tasks;
using Blargo.JudisList.Sessions.Dto;

namespace Blargo.JudisList.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
