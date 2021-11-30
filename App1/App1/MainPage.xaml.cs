using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Start_Clicked(object sender, EventArgs e)
        {
            int Number = Convert.ToInt32(xNumber.Text);
            int Repetition = Convert.ToInt32(xRepeatition.Text);
            int PrimeNumber;
            bool IsPrime = true;
            string NumberContent = "";

            for (int k = 1; k <= Repetition; k++)
            {
                NumberContent += Number.ToString();
            }

            for (int i = 2; i > 0; i++) //hledání prvočísla
            {
                IsPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime == true) //prvočíslo
                {
                    PrimeNumber = i;
                    xResult.Text = PrimeNumber.ToString();
                    xResult.Text = i.ToString();
                    if (PrimeNumber.ToString().Contains(NumberContent))
                    {
                        xResult.Text = PrimeNumber.ToString();
                        break;
                    }
                }
            }


        }
    }
}
