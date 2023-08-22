using ExamenAPI_JoselinM;
using ExamenAPP_JoselinM.Models;
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
    public partial class PreguntaPage : ContentPage
    {

        AskViewModel viewModel;
        public PreguntaPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new AskViewModel();

            LoadAskStatusAsync();

            LoadUserName();

        }

        private void LoadUserName()
        {
            LblUserName.Text = GlobalObjects.MyLocalUser.UserName.Trim();
            TxtUser.Text = GlobalObjects.MyLocalUser.FirstName.ToUpper();
        }

            
        private async void LoadAskStatusAsync()
        {
            PkrAskStatus.ItemsSource = await viewModel.GetAskStatusAsync();
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            //capturar el rol que se haya seleccionado en el picker 
            AskStatus SelectedAskStatus = PkrAskStatus.SelectedItem as AskStatus;
            

            bool R = await viewModel.AddAsksAsync(DateTime.Now, 
                                                  TxtAsk.Text.Trim(), 
                                                  GlobalObjects.MyLocalUser.UserId, 
                                                  SelectedAskStatus.AskStatusId, 
                                                  TxtImage.Text.Trim(), 
                                                  TxtAskDetail.Text.Trim());

            if (R)
            {
                await DisplayAlert(":)", "Ask created succesfully", "OK");
                
            }
            else
            {
                await DisplayAlert(":(", "Something went wrong", "OK");
            }

        }

        private void BtnCancel_Clicked(object sender, EventArgs e)
        {

        }
    }
}