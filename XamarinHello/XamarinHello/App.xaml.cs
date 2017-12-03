using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinHello
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Arvaa Numero - Peli",
                        TextColor = Color.Blue,                     
                    },
                      new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Sovellusversio 0.10",
                        TextColor = Color.Blue,                       
                    },
                      new Entry
                      {
                          Keyboard = Keyboard.Numeric,
                          Text = ""
                      },
                      new Button
                      {
                          Text = "Arvaa"
                      }
                }
             }
          };
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
