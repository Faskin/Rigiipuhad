using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Rigiipuhad
{
    public partial class Veebruar : ContentPage
    {
        public Veebruar()
        {
            InitializeComponent();
           
        }
        async void ButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Iseseisvuspäev on riigi ja rahva pidupäev. 24. veebruaril 1918 avaldati Manifest kõigile Eestimaa rahvastele, milles kuulutati välja sõltumatu ja demokraatlik Eesti Vabariik. Vabariigi aastapäeva tähistamist koorineerib Välisministeerium", "OK");
        }
    }
}
