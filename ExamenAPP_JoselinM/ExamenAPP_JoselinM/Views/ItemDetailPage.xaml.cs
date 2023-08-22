using ExamenAPP_JoselinM.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ExamenAPP_JoselinM.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}