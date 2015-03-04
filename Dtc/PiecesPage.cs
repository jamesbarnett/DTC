using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using Xamarin.Forms;
using Dtc.Core;

namespace Dtc
{
    public class PiecesPage : CarouselPage
    {
        private List<Piece> _pieces;

        public PiecesPage(List<Piece> pieces)
        {
            _pieces = pieces;

            var pages = new List<ContentPage>(0);
            foreach (Piece p in _pieces)
            {
                var contentPage = new ContentPage { Content = new StackLayout {
                        Children = {
                            new Label { Text = p.Title }
                        }
                    }
                };
                pages.Add(contentPage);
            }

            foreach (var p in pages)
            {
                Children.Add(p);
            }
        }
    }
}


