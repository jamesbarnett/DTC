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

            var labels = Catalog.Collections.ConvertAll<Label>(c => new Label { 
                XAlign = TextAlignment.Center,
                Text = c.Title
            });

            labels.ForEach(label => stackLayout.Children.Add(label));

            Content = new ScrollView { Content = stackLayout };
        }
    }
}


