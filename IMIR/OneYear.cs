using System;

using Xamarin.Forms;

namespace IMIR
{
    public class OneYear : ContentPage
    {
        public OneYear()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

