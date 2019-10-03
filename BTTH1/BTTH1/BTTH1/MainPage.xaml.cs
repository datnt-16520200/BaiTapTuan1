using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BTTH1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void switchToTheWelcomeScreen(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new WelcomScreen()));
        }

        private async void switchToTheTotalsScreen(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new TotalsScreen()));
        }

        private async void switchToTheStackLayoutScreen(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new StackLayoutScreen()));
        }

        private async void switchToTheAbsoluteLayoutScreen(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new AbsoluteLayoutScreen()));
        }

        private async void switchToTheGridLayoutScreen(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new GridLayoutScreen()));
        }

        private async void switchToTheLoginScreen(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new LoginScreen()));
        }

        private async void switchToCalculator(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new CalculatorScreen()));
        }
    }
}
