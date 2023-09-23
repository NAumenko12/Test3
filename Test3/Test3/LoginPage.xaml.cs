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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            BackgroundColor = Color.DodgerBlue;
            var logoImage = new Image
            {
                Source = "gggg.PNG",
                WidthRequest = 250,
                HeightRequest = 250,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,

            };
            var loginFrame = new Frame
            {
                WidthRequest = 300,
                HeightRequest = 40,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.White,
                Margin = new Thickness(0, 10, 0, 0),
                CornerRadius = 35,
                HasShadow = true,

            };
            var loginEntry = new Entry
            {
                TextColor = Color.Black,
                Placeholder = "Логин"
            };
            loginFrame.Content = loginEntry;

            var passwordFrame = new Frame
            {
                HasShadow = true,
                CornerRadius = 35,
                WidthRequest = 300,
                HeightRequest = 40,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.White,
                Margin = new Thickness(0, 10, 0, 0),
            };
            var passwordEntry = new Entry
            {
                IsPassword = true,
                TextColor = Color.Black,
                Placeholder = "Пароль",


            };
            passwordFrame.Content = passwordEntry;

            var loginButton = new Button
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
            loginButton.Clicked += (sender, args) =>
            {
                if (loginEntry.Text == "Отходообразователь" && passwordEntry.Text == "1234")
                {
                    Navigation.PushAsync(new ManagerPage());
                }
                else if (loginEntry.Text == "МастерУчастка" && passwordEntry.Text == "123")
                {
                    Navigation.PushAsync(new ManagerPage());
                }
                else if (loginEntry.Text == "Отвальщик" && passwordEntry.Text == "000")
                {
                    Navigation.PushAsync(new OtvalshikaPage());
                }
                else if (loginEntry.Text == "Диспетчер" && passwordEntry.Text == "111")
                {
                    Navigation.PushAsync(new DispecherPage());

                }
                else if (loginEntry.Text == "Бухгалтер" && passwordEntry.Text == "1211")
                {
                    Navigation.PushAsync(new ByghalterPage());
                }
                else
                {
                    DisplayAlert("Ошибка", "Некорректный логин", "ОК");
                }
            };
            Content = new StackLayout
            {
                Children = { logoImage, loginFrame, passwordFrame, loginButton }
            };
        }
    }
}