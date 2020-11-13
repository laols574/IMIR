using System;

using Xamarin.Forms;

namespace IMIR
{
    public class ThirdParty : ContentPage
    {
        public ThirdParty()
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

