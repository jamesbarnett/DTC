using System;
using Xamarin.Forms;
using Dtc.Core;

namespace Dtc
{
    public class PiecesPage : ContentPage
    {
        public PiecesPage()
        {
//            this.BindingContext = piece;

            Content = new StackLayout { 
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


