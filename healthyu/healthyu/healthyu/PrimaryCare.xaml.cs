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
    public partial class PrimaryCare : ContentPage
    {
        public PrimaryCare()
        {
            InitializeComponent();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}