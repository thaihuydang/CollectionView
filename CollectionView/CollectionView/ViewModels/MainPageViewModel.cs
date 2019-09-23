using CollectionView.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CollectionView.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection< DataItem> items;
        public ObservableCollection<DataItem> Items
        {
            get { return items; }
            set { SetProperty(ref items, value); }
        }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Collection VIew";
        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Items = new ObservableCollection<DataItem>();
            Items.Add(new DataItem { Name = "Item 1", Value = 1 });
            Items.Add(new DataItem { Name = "Item 2", Value = 2 });
            Items.Add(new DataItem { Name = "Item 3", Value = 3 });
            Items.Add(new DataItem { Name = "Item 4", Value = 4 });
            Items.Add(new DataItem { Name = "Item 5", Value = 5 });
            Items.Add(new DataItem { Name = "Item 6", Value = 6 });
            Items.Add(new DataItem { Name = "Item 7", Value = 7 });
            Items.Add(new DataItem { Name = "Item 8", Value = 8 });
            Items.Add(new DataItem { Name = "Item 9", Value = 9 });
            Items.Add(new DataItem { Name = "Item 10", Value = 10 });

            Items.Add(new DataItem { Name = "Item 11", Value = 11 });
            Items.Add(new DataItem { Name = "Item 12", Value = 12 });
            Items.Add(new DataItem { Name = "Item 13", Value = 13 });
            Items.Add(new DataItem { Name = "Item 14", Value = 14 });
            Items.Add(new DataItem { Name = "Item 15", Value = 15 });
            Items.Add(new DataItem { Name = "Item 16", Value = 16 });
            Items.Add(new DataItem { Name = "Item 17", Value = 17 });
            Items.Add(new DataItem { Name = "Item 18", Value = 18 });
            Items.Add(new DataItem { Name = "Item 19", Value = 19 });
            Items.Add(new DataItem { Name = "Item 20", Value = 20 });

        }
    }
}
