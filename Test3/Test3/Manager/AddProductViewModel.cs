using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Test3.Manager;

namespace Test3.Manager
{
    class AddProductViewModel : BaseProductViewModel
    {
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        public AddProductViewModel()
        {
            SaveCommand = new Command(OnSave);
            CancelCommand = new Command(OnCancel);

            this.PropertyChanged += (_, __) => SaveCommand.ChangeCanExecute();
            ProductInfo = new ProductInfo();
        }

        

        public async void OnSave()
        {
            var product = ProductInfo;
            if (product != null)
            {
                await App.ProductServies.AddProductAsync(product);
                await Shell.Current.Navigation.PushAsync(new ProductPage());
            }
            

        }

        public async void OnCancel()
        {
            await Shell.Current.Navigation.PushAsync(new ProductPage()); 
        }
    }
}
