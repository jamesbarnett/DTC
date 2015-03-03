using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using Dtc.Core;

namespace Dtc
{
    public class PiecesPage : ContentPage
    {
        private List<Piece> _pieces;

        public PiecesPage(List<Piece> pieces)
        {
            _pieces = pieces;

            foreach (Piece p in _pieces)
            {
                Debug.WriteLine(string.Format("piece: {0}", p));
            }
//            this.BindingContext = piece;

            StackLayout stackLayout = new StackLayout();
            foreach (Piece p in _pieces)
            {
                stackLayout.Children.Add(new Label { Text = p.Title });
            }

            Content = stackLayout;
        }
    }
}


