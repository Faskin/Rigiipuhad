using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Rigiipuhad
{
    public partial class Mai : ContentPage
    {
        public Mai()
        {
            InitializeComponent();
        }
        async void ButtonClicked1(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Kevadpüha on Eesti riigipüha, mida peetakse 1. mail. Pühaga tähistatakse kevade saabumist.1.mai kui kevadpüha kattub nii rahvusvahelise töörahvapühaga kui ka Eesti rahvakalendri volbripäevaga.", "OK");
        }
        async void ButtonClicked2(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Nelipühad on kristlik püha, millega mälestatakse Püha Vaimu laskumist apostlitele 50 päeva pärast Jeesuse Kristuse ülestõusmist ja 10 päeva pärast taevaminemispüha. See on kiriku sünnipäev.Nelipühad on seotud juudi pühaga šavuot, mis tähistab Jumalalt Moosesele Siinai mäel kümne käsu andmist.Šavuoti peetakse seitse nädalat pärast paasapühi ja ta on pärit kaugest paganlikust minevikust, mil tähistati lõikustänupüha.", "OK");
        }
    }
}
