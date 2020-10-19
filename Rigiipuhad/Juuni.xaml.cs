using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Rigiipuhad
{
    public partial class Juuni : ContentPage
    {
        public Juuni()
        {
            InitializeComponent();
        }

        async void ButtonClicked1(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Võidupüha on Eesti riigipüha, mida peetakse 23. juunil alates aastast 1934. Sellega tähistatakse Eesti võitu Võnnu lahingus Landeswehri üle 23. juunil 1919.Võidupüha on eraisikutele kohustuslikuks lipuheiskamise päevaks.Võidupüha tähistamine on tseremoniaalselt seotud jaanipäeva tähistamisega 24.juunil.", "OK");
        }
        async void ButtonClicked2(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Jaanipäev on Eestis 24. juunil tähistatav püha. 24. juunile eelnevat 23. juuni päeva nimetatakse jaanilaupäevaks ja nendevahelist ööd jaaniööks, seda tähistatakse Eestis, Lätis ja põhjamaades jaanituledega.  Jaanipäeva nimetus pärineb kirikukalendrist, kirikus tähistatakse sel päeval Ristija Johannese sünnipäeva.  Eesti Vabariigis on jaanilaupäev ja jaanipäev riigipühad; jaanilaupäeval peetakse Eestis võidupüha, mis tähistab Eesti vägede võitu Vabadussõjas Võnnu lahingus 23. juunil 1919 Landeswehri üle.", "OK");
        }

    }
}
