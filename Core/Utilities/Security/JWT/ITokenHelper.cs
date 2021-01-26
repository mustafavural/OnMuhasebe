using Core.Entities.Concrete;
using System.Collections.Generic;
/* TODO:Klasör içinden dışına almak
 * 
 * 
 * JWT donanımını SOLID e uygun olarak kalsör dışına al
 * 
 */
namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
