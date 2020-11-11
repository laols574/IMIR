﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IMIR
{
    public partial class Page2Xaml : ContentPage
    {
        public Page2Xaml()
        {
            InitializeComponent();
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new Page3Xaml());
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e) {
            await Navigation.PopAsync();

        }
    }
}
