using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace healthyu
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new flyout();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
