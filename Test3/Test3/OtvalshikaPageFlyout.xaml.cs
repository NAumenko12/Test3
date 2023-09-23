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
    public partial class OtvalshikaPageFlyout : ContentPage
    {
        public ListView ListView;

        public OtvalshikaPageFlyout()
        {
            InitializeComponent();

            BindingContext = new OtvalshikaPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class OtvalshikaPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<OtvalshikaPageFlyoutMenuItem> MenuItems { get; set; }

            public OtvalshikaPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<OtvalshikaPageFlyoutMenuItem>(new[]
                {
                    new OtvalshikaPageFlyoutMenuItem {Id = 0, Title = "Смотреть талоны" ,TargetType=typeof(NewPage)},
                     new OtvalshikaPageFlyoutMenuItem { Id = 1, Title = "Выйти", TargetType = typeof(LoginPage) },
                   
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