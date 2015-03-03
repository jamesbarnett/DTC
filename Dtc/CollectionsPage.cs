using System;
using System.Diagnostics;
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
            Catalog = Catalog.Load();

            var stackLayout = new StackLayout();

            var listView = new ListView
            {
                RowHeight = 40
            };

            listView.ItemsSource = Catalog.Collections;
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");

            listView.ItemSelected += async(sender, e) => {
                var selectedCollection = (Collection)e.SelectedItem;
                await Navigation.PushAsync(new PiecesPage(selectedCollection.Pieces));
            };

            stackLayout.Children.Add(listView);
            Content = new ScrollView { Content = stackLayout };
        }
    }
}
