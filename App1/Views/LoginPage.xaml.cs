using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            init();
        }

        void init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginImage.HeightRequest = Constants.loginIconHeight;

            // this is the lambda 
            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => Btn_Signin_Clicked(s, e);
        }

        //  This is equivalent to SignInProcedure in the tutorial 
        private void Btn_Signin_Clicked(object sender, EventArgs e)
        {
            // this is using a 
            
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            System.Console.WriteLine("Username = "+user.Username);
            if (user.CheckInformation()) {
               DisplayAlert("Login", "Login Success", "Ok");
            } else
            {
               DisplayAlert("Login", "Login Not correct", "Ok");
            }
        }

    }
}