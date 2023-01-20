﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Learning.navigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public bool loginSuccess = false;

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void LoginClicked(object sender, EventArgs e)
        {
            loginSuccess = !String.IsNullOrEmpty(User.Text);
            await Navigation.PopModalAsync();
        }

        string _displayErrorMessage = "";
        public string DisplayErrorMessage
        {
            get => _displayErrorMessage;
            set
            {
                if (_displayErrorMessage != value)
                {
                    _displayErrorMessage = value;
                    StatusMessage.Text = _displayErrorMessage;
                }
            }
        }
    }
}