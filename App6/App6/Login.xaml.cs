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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            
            var nombre = boxName.Text;


            if (!string.IsNullOrEmpty(nombre))
            {
                DisplayAlert("Xamarin Forms" ,nombre, "Aceptar");
            }
        }

        private void btnNewPage_Clicked(object sender, EventArgs e)
        {
            var user = new UserModel() {
                Nombre =  boxName.Text
            };
            Intent intent = new Intent(this, new Page2());
            intent.PutObject("user", user);
            intent.PutString("xD", "Lol");
            intent.StartIntent();
        }
    }
}