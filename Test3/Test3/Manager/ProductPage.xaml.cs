using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Manager;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        
        ProductViewModel productViewModel;
        public ProductPage()
        {
            InitializeComponent();
            BindingContext = productViewModel = new ProductViewModel(Navigation);
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            productViewModel.OnAppearing();
        }
    }
}