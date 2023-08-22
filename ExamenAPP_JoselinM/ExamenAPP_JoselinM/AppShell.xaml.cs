using ExamenAPP_JoselinM.ViewModels;
using ExamenAPP_JoselinM.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ExamenAPP_JoselinM
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
