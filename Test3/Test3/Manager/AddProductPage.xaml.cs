using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test3.Manager
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProductPage : ContentPage
    {
        public ProductInfo ProductInfo { get; set; }
        public AddProductPage()
        {
            InitializeComponent();
            BindingContext = new AddProductViewModel();
        }

        public AddProductPage(ProductInfo productInfo)
        {
            InitializeComponent();
            BindingContext = new AddProductViewModel();
            if (productInfo != null)
            {
                ((AddProductViewModel)BindingContext).ProductInfo = productInfo;
            }
        }

        private async void GoBack(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ProductPage");
        }
    }
}