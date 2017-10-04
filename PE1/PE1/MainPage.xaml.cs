using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace PE1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void btnPictureGallery_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PictureGallery());
            
        }

        private async void btnWikiPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WikiPage());
        }

        private async void btnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
