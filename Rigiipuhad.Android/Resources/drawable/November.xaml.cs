using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Rigiipuhad
{
    public partial class November : ContentPage
    {
        public November()
        {
            InitializeComponent();
        }


        
        async void ButtonClicked1(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Sinu nimi Viktor a.k.a Tjavik", "OK");
        }
    }
}
