using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Blargo.JudisList.Authorization.Users;
using Blargo.JudisList.MultiTenancy;

namespace Blargo.JudisList.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
