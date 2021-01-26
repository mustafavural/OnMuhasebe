using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string secuirtyKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secuirtyKey));
        }
    }
}
