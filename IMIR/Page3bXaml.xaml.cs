﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IMIR
{
    public partial class Page3bXaml : ContentPage
    {
        private bool check = false;

        public Page3bXaml()
        {
            InitializeComponent();
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void OnRootPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            check = e.Value;
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            if (check)
            {
                await Navigation.PushAsync(new Page3aXaml());
            }
            else
            {
                await Navigation.PushAsync(new Page3bXaml());

            }

        }
    }
}
