using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace healthyu
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void DailyStretch_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DailyStretch());
        }

        private async void HealthyDiet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HealthyDiet());
        }

        private async void PeaceMind_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PeaceMind());
        }

        private async void PrimaryCare_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrimaryCare());
        }

        private async void BuildU_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuildU());
        }

        private async void BMICalculator_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BMICalculator());
        }

        private async void AboutUs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new About());
        }
    }
}
