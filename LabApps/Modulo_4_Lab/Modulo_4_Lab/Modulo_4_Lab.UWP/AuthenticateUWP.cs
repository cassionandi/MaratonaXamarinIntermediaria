using Modulo_4_Lab.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

[assembly: Xamarin.Forms.Dependency(typeof(AuthenticateUWP))]
namespace Modulo_4_Lab.UWP
{
    public class AuthenticateUWP : IAuthenticate
    {
        public async Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider)
        {
            try
            {
                return await client.LoginAsync(provider);
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
