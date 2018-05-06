using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Login() //Boton regresar no funciona en navigation page en windows app
            //{
            //    Title = "Login page"
            //});

            MainPage = new Login()
            {
                Title = "Login page"
            };
            //MainPage = new App6.MainPage()
            //{
            //    Content = new StackLayout()
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label{
            //                  XAlign = TextAlignment.Center,
            //                   Text = "Esto es una prueba"
            //            },
            //            new Button{
            //                 Text = "Esto es un bton para probar algo",

            //            }
            //        }
            //    }
            //};
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
