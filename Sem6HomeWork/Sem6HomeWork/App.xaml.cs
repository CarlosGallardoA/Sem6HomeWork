using Sem6HomeWork.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sem6HomeWork
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new UsesGrup();
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
