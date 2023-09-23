using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BackgroundColor = Color.DodgerBlue;
            var logImage = new Image
            {
                Source = "gggg.PNG",
                WidthRequest = 250,
                HeightRequest = 250,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,

            };
            var LogButton = new Button
            {
                Text = "Войти",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                CornerRadius = 35,
                WidthRequest = 300,
                HeightRequest = 50,
                BackgroundColor = Color.White,
                Margin = new Thickness(0, 10, 0, 0),
            };
            var RegButton = new Button
            {
                Text = "Создать аккаунт",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                CornerRadius = 35,
                WidthRequest = 300,
                HeightRequest = 50,
                BackgroundColor = Color.White,
                Margin = new Thickness(0, 10, 0, 0),
            };
            LogButton.Clicked += (sender, args) => Navigation.PushAsync(new LoginPage());
            RegButton.Clicked += (sender, args) => Navigation.PushAsync(new SignUpPage());
            Content = new StackLayout
            {
                Children = { logImage, LogButton, RegButton }
            };
        }
    }
}