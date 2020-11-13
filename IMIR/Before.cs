using System;

using Xamarin.Forms;

namespace IMIR
{
    public class Before : ContentPage
    {
        public Before()
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

