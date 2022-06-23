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
    public partial class HealthyDiet : ContentPage
    {
        public HealthyDiet()
        {
            InitializeComponent();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void CalcCal_Clicked(object sender, EventArgs e)
        {
            decimal weight, height, age, exercise;
            decimal.TryParse(this.weightkg.Text, out weight);
            decimal.TryParse(this.heightcm.Text, out height);
            decimal.TryParse(this.ageper.Text, out age);
            decimal.TryParse(this.exerone.Text, out exercise);

            decimal menBMR = 0;
            decimal femaleBMR = 0;

            if (MainPicker.SelectedIndex == 0)
            {
                menBMR = (66.4730m + (13.7516m * weight) + (5.0033m * height) - (6.755m * age));

                decimal menResult = 0;
                if (exercise <= 0)
                {
                    menResult = (menBMR * 1.2m);
                    this.Result.Text = menResult.ToString() + " is the amount of calories you need to consume daily.";
                }
                else if (exercise == 1 || exercise == 2 || exercise == 3)
                {
                    menResult = (menBMR * 1.375m);
                    this.Result.Text = menResult.ToString() + " is the amount of calories you need to consume daily.";
                }
                else if (exercise == 4 || exercise == 5 || exercise == 6)
                {
                    menResult = (menBMR * 1.55m);
                    this.Result.Text = menResult.ToString() + " is the amount of calories you need to consume daily.";
                }
                else if (exercise == 7 || exercise == 8 || exercise == 9)
                {
                    menResult = (menBMR * 1.725m);
                    this.Result.Text = menResult.ToString() + " is the amount of calories you need to consume daily.";
                }
                else
                {
                    menResult = (menBMR * 1.9m);
                    this.Result.Text = menResult.ToString() + " is the amount of calories you need to consume daily.";
                }
            }
            else if (MainPicker.SelectedIndex == 1)
            {
                femaleBMR = (655.0955m + (9.5634m * weight) + (1.8496m * height) - (4.6756m * age));

                decimal femaleResult = 0;
                if (exercise <= 0)
                {
                    femaleResult = (femaleBMR * 1.2m);
                    this.Result.Text = femaleResult.ToString() + " is the amount of calories you need to consume daily.";
                }
                else if (exercise == 1 || exercise == 2 || exercise == 3)
                {
                    femaleResult = (femaleBMR * 1.375m);
                    this.Result.Text = femaleResult.ToString() + " is the amount of calories you need to consume daily.";
                }
                else if (exercise == 4 || exercise == 5 || exercise == 6)
                {
                    femaleResult = (femaleBMR * 1.55m);
                    this.Result.Text = femaleResult.ToString() + " is the amount of calories you need to consume daily.";
                }
                else if (exercise == 7 || exercise == 8 || exercise == 9)
                {
                    femaleResult = (femaleBMR * 1.725m);
                    this.Result.Text = femaleResult.ToString() + " is the amount of calories you need to consume daily.";
                }
                else
                {
                    femaleResult = (femaleBMR * 1.9m);
                    this.Result.Text = femaleResult.ToString();
                }
            }

        }
    }
}