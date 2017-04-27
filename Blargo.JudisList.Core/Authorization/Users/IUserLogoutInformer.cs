using System.Collections.Generic;
using Abp.Dependency;
using Abp.RealTime;

namespace Blargo.JudisList.Authorization.Users
{
    public interface IUserLogoutInformer
    {
        void InformClients(IReadOnlyList<IOnlineClient> clients);
    }
}
