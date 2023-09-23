using System;
using System.IO;
using Test3.Manager;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test3
{
    public partial class App : Application
    {
        static ProductServies _productServies;
        public static ProductServies ProductServies
        {

            get
            {
                if (_productServies == null)
                {
                    _productServies = new ProductServies(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Ptoduct.db3"));
                }
                return _productServies;
            }
        }

        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            
            base.OnStart();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(AddProductPage), typeof(AddProductPage));
            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
           
        }
        

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
