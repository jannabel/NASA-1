﻿using System;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace NASA.Views
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage" /> class.
        /// </summary>
        public LoginPage()
        {
            this.InitializeComponent();
        }

        void LoginClicked(object sender, EventArgs e)
        {
            //string pass = PasswordEntry.Text;

        }
    }
}