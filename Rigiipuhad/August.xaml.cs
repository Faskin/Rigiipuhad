using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Rigiipuhad
{
    public partial class August : ContentPage
    {
        public August()
        {
            InitializeComponent();
        }
        async void ButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Taasiseseisvumispäev(ka iseseisvuse taastamise päev) on Eesti Vabariigi riigipüha, millega igal aastal 20.augustil tähistatakse Eesti Vabariigi de facto taastamist Eesti Vabariigi Ülemnõukogu otsusega Eesti riiklikust iseseisvusest, mis võeti Eesti Komiteega kooskõlastatult vastu Eesti Vabariigi Ülemnõukogu istungil 20.augustil 1991 kell 23:03.", "OK");
        }
    }
}
