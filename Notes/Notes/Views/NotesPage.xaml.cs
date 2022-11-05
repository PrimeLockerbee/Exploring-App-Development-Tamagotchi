using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.Views
{
    public partial class NotesPage : ContentPage
    {
        public NotesPage()
        {
            InitializeComponent();

            var image = new Image { Source = "WAWATCHI2.jpg" };
        }

        async void OnBoredomButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Boredom());
        }

        async void OnEnergyButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Energy());
        }

        async void OnHungerButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hunger());
        }

        async void OnSocialButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Social());
        }

        async void OnStimulusButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Stimulus());
        }

        async void OnThirstButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Thirst());
        }
    }
}