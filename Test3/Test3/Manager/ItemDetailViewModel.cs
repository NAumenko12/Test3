using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace Test3.Manager
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;
        private string zakaz;
        private string kodFKKO;
        private string massa;
        private string data;
        private string nomerMashini;
        public string Id
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public string Zakaz
        {
            get => zakaz;
            set => SetProperty(ref text, value);
        }
        public string KodFKKO
        {
            get => kodFKKO;
            set => SetProperty(ref text, value);
        }
        public string Massa
        {
            get => massa;
            set => SetProperty(ref text, value);
        }
        public string Data
        {
            get => data;
            set => SetProperty(ref text, value);
        }
        public string NomerMashini
        {
            get => nomerMashini;
            set => SetProperty(ref text, value);
        }


        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
                

            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
