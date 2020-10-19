using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Rigiipuhad
{
    public partial class Jaanuar : ContentPage
    {
        public Jaanuar()
        {
            InitializeComponent();
        }
        async void ButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Simple new year", "OK");
        }
    }
}
