using System;
using System.Linq;
using System.Linq.Expressions;
using Xamarin.Forms;
using Dtc.Core;

namespace Dtc
{
    public class CollectionsPage : ContentPage
    {
        public Catalog Catalog { get; set; }

        public CollectionsPage()
        {
            Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);
            Catalog = Catalog.Load();

            var stackLayout = new StackLayout();

            var listView = new ListView
            {
                RowHeight = 40
            };

            listView.ItemsSource = Catalog.Collections.ConvertAll<string>(c => c.Title);

            stackLayout.Children.Add(listView);
            Content = new ScrollView { Content = stackLayout };
        }
    }
}


