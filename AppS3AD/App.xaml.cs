using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS3AD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            /// habiltar navegacion entre ventanas 
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
