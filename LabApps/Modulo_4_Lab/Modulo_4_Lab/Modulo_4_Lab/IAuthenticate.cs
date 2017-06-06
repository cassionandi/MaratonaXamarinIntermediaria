using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace Modulo_4_Lab
{
    public interface IAuthenticate
    {

        Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider);

    }
}
