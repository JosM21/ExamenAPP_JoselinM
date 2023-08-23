using ExamenAPP_JoselinM.Services;
using ExamenAPP_JoselinM.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenAPP_JoselinM
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

          // DependencyService.Register<MockDataStore>();


            MainPage = new NavigationPage(new BienvenidaPage());
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
