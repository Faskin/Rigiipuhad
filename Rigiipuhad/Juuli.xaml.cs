using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Rigiipuhad
{
    public partial class Juuli : ContentPage
    {
        public Juuli()
        {
            InitializeComponent();
        }
        async void ButtonClicked1(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Mina sunnipaev", "OK");
        }
    }
}
