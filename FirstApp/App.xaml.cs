using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;

namespace FirstApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("9461c25d-ab5f-4c87-8772-4bdf6643d042",
                  typeof(Analytics), typeof(Crashes));
        }
    }
}
