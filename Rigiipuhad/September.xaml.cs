using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Rigiipuhad
{
    public partial class September : ContentPage
    {
        public September()
        {
            InitializeComponent();
        }
        async void ButtonClicked1(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Teadmiste paev", "OK");
        }
    }
}
