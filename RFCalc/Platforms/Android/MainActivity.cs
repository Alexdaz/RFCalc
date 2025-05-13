using Android.App;
using Android.Content.PM;
using Android.OS;

namespace RFCalc
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            Window.SetNavigationBarColor(Android.Graphics.Color.ParseColor("#33cc99"));

            base.OnCreate(savedInstanceState);
        }
    }
}
