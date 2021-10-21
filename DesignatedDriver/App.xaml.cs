using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DesignatedDriver
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            NavigationPage navPage = new NavigationPage(new MainPage());
            navPage.BarBackgroundColor = Color.DarkCyan;
            MainPage = navPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
