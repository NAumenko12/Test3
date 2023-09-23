using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ByghalterPageFlyout : ContentPage
    {
        public ListView ListView;

        public ByghalterPageFlyout()
        {
            InitializeComponent();

            BindingContext = new ByghalterPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class ByghalterPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ByghalterPageFlyoutMenuItem> MenuItems { get; set; }

            public ByghalterPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<ByghalterPageFlyoutMenuItem>(new[]
                {
                    new ByghalterPageFlyoutMenuItem { Id = 0, Title = "Код ФККО", TargetType=typeof(KodPage) },
                    new ByghalterPageFlyoutMenuItem { Id = 1, Title = "Список талонов" , TargetType=typeof(ProductPage) },
                    new ByghalterPageFlyoutMenuItem { Id = 2, Title = "Добавить договора" , TargetType=typeof(ImagePage) },
                    new ByghalterPageFlyoutMenuItem { Id = 2, Title = "Выйти" , TargetType=typeof(LoginPage) },
                    
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}