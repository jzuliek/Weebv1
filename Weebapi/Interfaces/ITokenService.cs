using Weebapi.Entities;

namespace Weebapi.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}