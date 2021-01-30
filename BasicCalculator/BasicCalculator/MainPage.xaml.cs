using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BasicCalculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

         
        private void BtnAdd_OnClickedBtnAdd_Clicked(object sender, EventArgs e)
        {
             znak.Text="+";
             check1.IsChecked = false;
        }

        private void BtnSub_OnClickedBtnSub_Clicked(object sender, EventArgs e)
        {
            znak.Text = "-";
            check1.IsChecked = false;

        }

       

        private void BtnMul_OnClickedBtnMul_Clicked(object sender, EventArgs e)
        {
            znak.Text = "*";
            check1.IsChecked = false;

            
        }


        private void BtnDiv_OnClickedBtnDiv_Clicked(object sender, EventArgs e)
        {
            znak.Text = "/";
            check1.IsChecked = false;

           
        }

        private void BtnRem_OnClickedBtnRem_Clicked(object sender, EventArgs e)
        {
            znak.Text = "%";
            check1.IsChecked = false;

           
        }

        private void BtnClr_OnClickedBtnClr_Clicked(object sender, EventArgs e)
        {
            check1.IsChecked = true;
            num1.Text = String.Empty;
            num2.Text = String.Empty;
            res.Text = String.Empty;
        }

        
        private void Btn1_OnClicked(object sender, EventArgs e)
        {
            if (check1.IsChecked) 
            {
                num1.Text = num1.Text + "1";
                
            }
            else
            {
                num2.Text = num2.Text + "1";
                
            }
            

        }

        private void Btn2_OnClicked(object sender, EventArgs e)
        {
            if (check1.IsChecked)
            {
                num1.Text = num1.Text + "2";
            }
            else
            {
                num2.Text = num2.Text + "2";
            }



        }

        private void Btn3_OnClicked(object sender, EventArgs e)
        {
            if (check1.IsChecked)
            {
                num1.Text = num1.Text + "3";
            }
            else
            {
                num2.Text = num2.Text + "3";
            }

        }

        private void Btn4_OnClicked(object sender, EventArgs e)
        {
            if (check1.IsChecked)
            {
                num1.Text = num1.Text + "4";
            }
            else
            {
                num2.Text = num2.Text + "4";
            }

        }

        private void Btn5_OnClicked(object sender, EventArgs e)
        {
            if (check1.IsChecked)
            {
                num1.Text = num1.Text + "5";
            }
            else
            {
                num2.Text = num2.Text + "5";
            }

        }

        private void Btn6_OnClicked(object sender, EventArgs e)
        {
            if (check1.IsChecked)
            {
                num1.Text = num1.Text + "6";
            }
            else
            {
                num2.Text = num2.Text + "6";
            }

        }

        private void Btn7_OnClicked(object sender, EventArgs e)
        {
            if (check1.IsChecked)
            {
                num1.Text = num1.Text + "7";
            }
            else
            {
                num2.Text = num2.Text + "7";
            }

        }

        private void Btn8_OnClicked(object sender, EventArgs e)
        {
            if (check1.IsChecked)
            {
                num1.Text = num1.Text + "8";
            }
            else
            {
                num2.Text = num2.Text + "8";
            }

        }

        private void Btn9_OnClicked(object sender, EventArgs e)
        {
            if (check1.IsChecked)
            {
                num1.Text = num1.Text + "9";
            }
            else
            {
                num2.Text = num2.Text + "9";
            }

        }

        private void Btn0_OnClicked(object sender, EventArgs e)
        {
            if (check1.IsChecked)
            {
                num1.Text = num1.Text + "0";
            }
            else
            {
                num2.Text = num2.Text + "0";
            }

        }

        private void BtnEqual_OnClicked(object sender, EventArgs e)
        {
            check1.IsChecked = true;
            if (znak.Text == "+")
            {
                double a = double.Parse(num1.Text);
                double b = double.Parse(num2.Text);
                res.Text = (a + b).ToString();
            }
            else if (znak.Text == "-")
            {
                double a = double.Parse(num1.Text);
                double b = double.Parse(num2.Text);
                res.Text = (a - b).ToString();
            }
            else if (znak.Text == "*")
            {
                double a = double.Parse(num1.Text);
                double b = double.Parse(num2.Text);
                res.Text = (a * b).ToString();
            }
            else if (znak.Text == "/")
            {
                double a = double.Parse(num1.Text);
                double b = double.Parse(num2.Text);
                res.Text = Math.Round((a / b), 2).ToString();
            }

            else if (znak.Text=="%")
            {
                double a = double.Parse(num1.Text);
                double b = double.Parse(num2.Text);
                res.Text = (a % b).ToString();

            }
        }
    }
}
