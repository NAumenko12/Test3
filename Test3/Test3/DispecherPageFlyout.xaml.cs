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
    public partial class DispecherPageFlyout : ContentPage
    {
        public ListView ListView;

        public DispecherPageFlyout()
        {
            InitializeComponent();

            BindingContext = new DispecherPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class DispecherPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<DispecherPageFlyoutMenuItem> MenuItems { get; set; }
            
            public DispecherPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<DispecherPageFlyoutMenuItem>(new[]
                {
                    new DispecherPageFlyoutMenuItem { Id = 0, Title = "Смотреть талоны" ,TargetType=typeof(NewPage)},
                    new DispecherPageFlyoutMenuItem { Id = 1, Title = "Выйти",TargetType=typeof(LoginPage) },
                   
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