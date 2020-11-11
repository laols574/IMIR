using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace IMIR
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new Page1Xaml());

        }

    }
}

