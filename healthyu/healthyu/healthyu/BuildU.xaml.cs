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
    public partial class BuildU : ContentPage
    {
        public BuildU()
        {
            InitializeComponent();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void btn_chest_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BuildU_Chest());
        }

        private void btn_biceps_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BuildU_Biceps());
        }

        private void btn_abs_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BuildU_Abs());
        }
    }
}