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
    public partial class ManagerPageFlyout : ContentPage
    {
        public ListView ListView;

        public ManagerPageFlyout()
        {
            InitializeComponent();

            BindingContext = new ManagerPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class ManagerPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ManagerPageFlyoutMenuItem> MenuItems { get; set; }

            public ManagerPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<ManagerPageFlyoutMenuItem>(new[]
                {
                    new ManagerPageFlyoutMenuItem { Id = 0, Title = "Код ФККО", TargetType=typeof(KodPage) },
                    new ManagerPageFlyoutMenuItem { Id = 1, Title = "Список талонов" , TargetType=typeof(ProductPage) },
                    new ManagerPageFlyoutMenuItem { Id = 2, Title = "Выйти" , TargetType=typeof(LoginPage) },
                    
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
             public void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}