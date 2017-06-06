using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Modulo_4_Lab
{
    public partial class MainPage : ContentPage
    {

        readonly AzureService azureService = new AzureService();

        public MainPage()
        {
            InitializeComponent();

            LoginButton.Clicked += LoginButton_ClickedAsync;


        }

        private async void LoginButton_ClickedAsync(object sender, EventArgs e)
        {
            var user = await azureService.LoginAsync();
            InfoLabel.Text = (user != null) ? $"Bem vindo: {user.UserId}" : "Falha no login, tente novamente!";
        }
    }
}
