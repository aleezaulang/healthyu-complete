using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace healthyu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DailyStretch : ContentPage
    {
        public DailyStretch()
        {
            InitializeComponent();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Exercise1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DSExerciseOne());
        }

        private async void Exercise2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DSExerciseTwo());
        }
    }
}