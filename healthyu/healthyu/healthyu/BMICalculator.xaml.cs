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
    public partial class BMICalculator : ContentPage
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void heightUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.heightUnit.SelectedIndex == 0)
            {
                this.heightcmView.IsVisible = true;

                this.heightftEntryView.IsVisible = false;
                this.heightftLabelView.IsVisible = false;
                this.heightinEntryView.IsVisible = false;
                this.heightinLabelView.IsVisible = false;

                this.heightUnit.SelectedIndex = 0;
            }
            else
            {
                this.heightcmView.IsVisible = false;

                this.heightftEntryView.IsVisible = true;
                this.heightftLabelView.IsVisible = true;
                this.heightinEntryView.IsVisible = true;
                this.heightinLabelView.IsVisible = true;

                this.heightUnit.SelectedIndex = 1;
            }

        }

        private void bmi_calculate_btn_Clicked(object sender, EventArgs e)
        {
            double height = 0;
            double weight = 0;
            double feet = 0;
            double inch = 0;
            double BMI = 0;
            bool calculated = false;
            this.lblerror.IsVisible = false;

            if (this.heightUnit.SelectedIndex == 0 && this.weightUnit.SelectedIndex == 0)
            {
                //cm & kg
                if (double.TryParse(this.heightcm.Text, out height) && double.TryParse(this.weight.Text, out weight))
                {
                    height = Math.Pow((height / 100), 2);
                    BMI = Math.Round(weight / height, 1);
                    this.bmiResult.Text = BMI.ToString();
                    calculated = true;
                }
                else
                {
                    this.lblerror.IsVisible = true;
                }
            }
            else if (this.heightUnit.SelectedIndex == 0 && this.weightUnit.SelectedIndex == 1)
            {
                //cm & lb
                if (double.TryParse(this.heightcm.Text, out height) && double.TryParse(this.weight.Text, out weight))
                {
                    height = Math.Pow((height / 100), 2);
                    weight = weight / 2.205;

                    BMI = Math.Round(weight / height, 1);
                    this.bmiResult.Text = BMI.ToString();
                    calculated = true;
                }
                else
                {
                    this.lblerror.IsVisible = true;
                }
            }
            else if (this.heightUnit.SelectedIndex == 1 && this.weightUnit.SelectedIndex == 0)
            {
                //ft & kg
                if (double.TryParse(this.heightft.Text, out feet) && double.TryParse(this.heightin.Text, out inch) && double.TryParse(this.weight.Text, out weight))
                {
                    height = Math.Pow(((feet * 12) + inch) / 39.37, 2);
                    BMI = Math.Round(weight / height, 1);
                    this.bmiResult.Text = BMI.ToString();
                    calculated = true;
                }
                else
                {
                    this.lblerror.IsVisible = true;
                }
            }
            else
            {
                //ft & lb
                if (double.TryParse(this.heightft.Text, out feet) && double.TryParse(this.heightin.Text, out inch) && double.TryParse(this.weight.Text, out weight))
                {
                    height = Math.Pow(((feet * 12) + inch) / 39.37, 2);
                    weight = weight / 2.205;
                    BMI = Math.Round(weight / height, 1);
                    this.bmiResult.Text = BMI.ToString();
                    calculated = true;
                }
                else
                {
                    this.lblerror.IsVisible = true;
                }
            }
            if (calculated)
            {
                this.bmiResult.IsVisible = true;
                this.bmiResulttxt.IsVisible = true;
                if (BMI < 15)
                {
                    this.line.TranslateTo(-185, 0);
                }
                else if (BMI > 33)
                {
                    this.line.TranslateTo(185, 0);
                }
                else
                {
                    this.line.TranslateTo(((BMI - 15.1) / (33.9 - 15.1) * (185 - -185) + -185), 0);
                }

                if (BMI < 18.6)
                {
                    this.bmiResult.TextColor = Color.FromHex("FFD800");
                    this.bmiResulttxt.TextColor = Color.FromHex("FFD800");
                    this.bmiResulttxt.Text = "Underweight";
                }
                else if (BMI > 18.5 && BMI < 25)
                {
                    this.bmiResult.TextColor = Color.Green;
                    this.bmiResulttxt.TextColor = Color.Green;
                    this.bmiResulttxt.Text = "Normal";
                }
                else if (BMI > 24.9 && BMI < 30)
                {
                    this.bmiResult.TextColor = Color.Orange;
                    this.bmiResulttxt.TextColor = Color.Orange;
                    this.bmiResulttxt.Text = "Overweight";
                }
                else
                {
                    this.bmiResult.TextColor = Color.Red;
                    this.bmiResulttxt.TextColor = Color.Red;
                    this.bmiResulttxt.Text = "Obese";
                }
            }
        }
    }
}