using System;
using Xamarin.Forms;

namespace IMIR
{
	public class Page3 : ContentPage
	{
		private bool check = false;
		public Page3()
		{
			var previousPageButton = new Button { Text = "Previous Page", VerticalOptions = LayoutOptions.CenterAndExpand };
			previousPageButton.Clicked += OnPreviousPageButtonClicked;

			var rootPageButton = new Button { Text = "Return to Root Page", VerticalOptions = LayoutOptions.CenterAndExpand };
			rootPageButton.Clicked += OnRootPageButtonClicked;

			var nextPageButton = new Button { Text = "Next Page", VerticalOptions = LayoutOptions.CenterAndExpand };
			nextPageButton.Clicked += OnNextPageButtonClicked;

			var beforeButton = new Button { Text = "Learn More", VerticalOptions = LayoutOptions.CenterAndExpand };
			previousPageButton.Clicked += OnBeforeClicked;

			var thirdPartyButton = new Button { Text = "Learn More", VerticalOptions = LayoutOptions.CenterAndExpand };
			rootPageButton.Clicked += OnThirdPartyClicked;

			var oneYearButton = new Button { Text = "Learn More", VerticalOptions = LayoutOptions.CenterAndExpand };
			nextPageButton.Clicked += OnOneYearClicked;

			Title = "Page 3";
			Content = new StackLayout
			{
				Children = {
					previousPageButton,
					nextPageButton,
					rootPageButton,
					beforeButton,
					thirdPartyButton,
					oneYearButton
				}
			};
		}

		async void OnPreviousPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		async void OnRootPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopToRootAsync();
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

		async void OnThirdPartyClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ThirdPartyXaml());

		}
		async void OnBeforeClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new BeforeXaml());

		}
		async void OnOneYearClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new OneYearXaml());

		}

		void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
		{
			check = e.Value;
		}
	}
}
