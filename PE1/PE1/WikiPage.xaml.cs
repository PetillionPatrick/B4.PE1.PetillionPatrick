﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PE1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WikiPage : ContentPage
    {
        public WikiPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}