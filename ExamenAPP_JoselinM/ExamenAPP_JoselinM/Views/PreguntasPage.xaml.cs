using ExamenAPI_JoselinM;
using ExamenAPP_JoselinM.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenAPP_JoselinM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreguntasPage : ContentPage
    {
        AskViewModel askViewModel;
        public PreguntasPage()
        {
            InitializeComponent();

            BindingContext = askViewModel = new AskViewModel();

            LoadAskList();
        }

        private async void LoadAskList()
        {
            LvList.ItemsSource = await askViewModel.GetAskAsync(GlobalObjects.MyLocalUser.UserId);
        }

    }
    
}