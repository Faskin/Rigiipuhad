using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Rigiipuhad
{
    public partial class Detsember : ContentPage
    {
        public Detsember()
        {
            InitializeComponent();
        }
        async void ButtonClicked1(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Jõululaupäev (ka: jõuluõhtu) on 24. detsember, päev enne esimest jõulupüha. Eestis on see päev riigipüha. Juliuse kalendri järgi, mida kasutab teiste seas Vene Õigeusu Kirik, langeb see päev praegu(aastatel 1900–2099) 6.jaanuarile.", "OK");
        }
        async void ButtonClicked2(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Pärast Eesti iseseisvuse taastamist on esimene ja teine jõulupüha (25. ja 26. detsember) riigipühad ja puhkepäevad, alates 2005. aastast ka jõululaupäev. Jõulukombestikku mõjutab järjest rohkem rahvusvaheline traditsioon. Rahvusringhääling kannab üle nii jõululaupäeva kui esimese jõulupüha jumalateenistusi. Paljudes asulates püstitatakse juba advendiaja alguses keskväljakule elektrituledega ehitud jõulukuusk, mis jääb enamasti püsti kolmekuningapäevani (langeb kokku Vene Õigeusu Kiriku jõululaupäevaga). Skandinaaviast on üle võetud komme asetada akendele advendiküünlad. Paljudes lastega peredes pannakse jõulude eel õhtuti aknalauale suss, kuhu toob maiustusi päkapikk – jõuluvana abiline, kes kontrollib ja talle ette kannab, kas lapsed on hästi käitunud. Kaubandusettevõtted rõhutavad jõulude eel külluse, heaolu ja kinkide tegemise tähtsust, püüdes suurendada oma läbimüüki; jõuludekoratsioonid ilmuvad kauplustesse sageli juba novembrikuus. Jõuluaja traditsioonilisteks toitudeks on jäänud verivorstid ning seapraad ahjukartuli ja hapukapsastega. Nii nagu naaberriikides, nõnda ka Eestis sagenevad jõulude ja uusaasta aegu meditsiinistatistikas liigsöömisest ja -joomisest tekkinud vaevused.", "OK");
        }
        async void ButtonClicked3(object sender, EventArgs args)
        {
            await DisplayAlert("About", "Pärast Eesti iseseisvuse taastamist on esimene ja teine jõulupüha (25. ja 26. detsember) riigipühad ja puhkepäevad, alates 2005. aastast ka jõululaupäev. Jõulukombestikku mõjutab järjest rohkem rahvusvaheline traditsioon.", "OK");
        }
    }
}
