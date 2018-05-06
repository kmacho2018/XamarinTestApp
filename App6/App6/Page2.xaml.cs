using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
        public Page2 ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var intent = Intent.Navigation.Intent;
            var user  = intent.GetObject<UserModel>("user");
            var lol = intent.GetString("xD");
            DisplayAlert("Xamarin App", lol, "Aceptar");
            BindingContext = user;
        }
    }
}