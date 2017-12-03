using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinHello
{
    public partial class App : Application
    {
        private Label arvauksenTulosLabel;
        private Entry syötekenttä;

        private int oikeaLuku;
        public App()
        {
            Random rnd = new Random();
            oikeaLuku = rnd.Next(1, 21);

            // painonapin alustus
            Button arvaaNappi = new Button();
            arvaaNappi.Text = "Arvaa";
            arvaaNappi.Clicked += ArvaaNappi_Clicked;

            syötekenttä = new Entry
            {
                Keyboard = Keyboard.Numeric,
                Text = ""
            };
            arvauksenTulosLabel = new Label();
            arvauksenTulosLabel.Text = "";

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
                     syötekenttä,
                     arvaaNappi,
                     arvauksenTulosLabel
                }
             }
          };
       }

        private void ArvaaNappi_Clicked(object sender, EventArgs e)
        {
            int arvaus = int.Parse(syötekenttä.Text);
            if (arvaus < oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Luku on suurempi. ";
            }
            else if (arvaus > oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Luku on pienempi";
            }
            else if ( arvaus == oikeaLuku) {
                arvauksenTulosLabel.Text = "Jee! täsmälleen oikein";
                Random rnd = new Random();
                oikeaLuku = rnd.Next(1, 21);
            }
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
