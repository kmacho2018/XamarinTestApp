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
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            
		}
        int count = 0;
        protected override void OnAppearing()
        {
            base.OnAppearing();
            btnClic.Clicked += btnClic_Clicked;
        }

        private void btnClic_Clicked(object sender, EventArgs e) {
            count++;
            btnClic.Text = count.ToString();
        }
    }
}