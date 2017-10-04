using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PE1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PictureGallery : ContentPage
    {
        public PictureGallery()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            


        }

        //private async void btnHome_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new MainPage());
        //}

        private async  void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var imgSender = (Image)sender;
            
            imgSender.Aspect = Aspect.AspectFit;
            var temp = new ContentPage
            {
                Content = imgSender
            };
            NavigationPage.SetHasNavigationBar(temp, false);
            await Navigation.PushAsync(temp);
            //var temPage = new NavigationPage();
            //Grid add = new Grid();

            //add.Children.Add(imgSender);
            
            //await Navigation.PushAsync(temPage);
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}