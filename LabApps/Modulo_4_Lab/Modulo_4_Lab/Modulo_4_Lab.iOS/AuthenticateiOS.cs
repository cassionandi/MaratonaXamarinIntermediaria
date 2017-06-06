using System;
using Modulo_4_Lab.iOS;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(AuthenticateiOS))]
namespace Modulo_4_Lab.iOS
{
    public class AuthenticateiOS : IAuthenticate
    {

        public async Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider)
        {

            try
            {
                return await client.LoginAsync(UIKit.UIApplication.SharedApplication.KeyWindow.RootViewController, provider);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}