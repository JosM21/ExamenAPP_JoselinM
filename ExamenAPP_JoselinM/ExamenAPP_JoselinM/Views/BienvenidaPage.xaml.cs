using ExamenAPI_JoselinM;
using ExamenAPP_JoselinM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenAPP_JoselinM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BienvenidaPage : ContentPage
    {
        UserViewModel viewModel;
        public BienvenidaPage()
        {
            InitializeComponent();

            this.BindingContext = viewModel = new UserViewModel();
        }

        private async void BtnEnter_Clicked(object sender, EventArgs e)
        {


            GlobalObjects.MyLocalUser = await viewModel.GetUserDataAsync();

            await Navigation.PushAsync(new PreguntaPage());



        }
    }
}