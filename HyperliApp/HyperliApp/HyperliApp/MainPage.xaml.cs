using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HyperliApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnImageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodPage());
        }

        private async void OnballonImageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activities());
        }

        private async void OnspaImageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Beauty_Spas());
        }

        private async void OnshoeImageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Health());
        }

        private async void OntoolsImageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LocalServices());
        }

        private async void OntreeImageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Getaways());
        }
    }
}
