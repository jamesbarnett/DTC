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

            Content = new StackLayout { 
                Children = {
                    new Label { Text = _pieces[0].Title }
                }
            };
        }
    }
}


