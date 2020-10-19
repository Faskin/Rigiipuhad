using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Rigiipuhad
{
    public partial class Aprill : ContentPage
    {
        public Aprill()
        {
            InitializeComponent();
        }
        async void ButtonClicked1(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Suur reede on kristlik püha, mil tähistatakse Jeesus Kristuse ristilöömist ja surma Kolgata mäel. See kuulub kokku rea teiste pühadega, mis seostuvad Jeesuse eluga. Suur reede eelneb lihavõttepühadele ning võib langeda kokku juudiusu paasapühadega.", "OK");
        }
        async void ButtonClicked2(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Ülestõusmispühad (ka lihavõttepühad ehk lihavõtted ja munapühad) on kristluses liikuvad pühad, mis algavad esimese täiskuu pühapäevaga pärast kevadist pööripäeva. Pühad mälestavad Jeesus Kristuse surnust ülestõusmist pärast ristilöömist. Ajaliselt langevad need kokku judaismi paasapühadega. Samale ajale jääb ka maausuliste kiigepüha ehk munapüha.", "OK");
        }

    }
}
