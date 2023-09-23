using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Test3.Manager;
using Test3;
using System.Runtime.InteropServices.ComTypes;
using System.IO;

namespace Test3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {


        private List<ImageSource> selectedPhotos = new List<ImageSource>();

        public ImagePage()
        {
            InitializeComponent();
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {
            // Проверяем, есть ли разрешение на чтение файлов
            var status = await Permissions.CheckStatusAsync<Permissions.StorageRead>();
            if (status != PermissionStatus.Granted)
            {
                // Если разрешение не предоставлено, запрашиваем его у пользователя
                status = await Permissions.RequestAsync<Permissions.StorageRead>();
                if (status != PermissionStatus.Granted)
                {
                    // Если пользователь не предоставил разрешение, показываем сообщение об ошибке
                    await DisplayAlert("Ошибка", "Разрешение на чтение файлов не было предоставлено", "OK");
                    return;
                }
            }

            FileResult photoResult = await MediaPicker.PickPhotoAsync();

            if (photoResult != null)
            {
                using (Stream stream = await photoResult.OpenReadAsync())
                {
                    selectedPhotos.Add(ImageSource.FromStream(() => stream));
                }
            }

            var pdfResult = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Pdf,
                PickerTitle = "Выберите PDF-файл"
            });

            if (pdfResult != null)
            {
                // Откройте PDF-файл с помощью выбранного приложения по умолчанию
                await Launcher.OpenAsync(new OpenFileRequest
                {
                    File = new ReadOnlyFile(pdfResult.FullPath)
                });
            }
        }
    }
}