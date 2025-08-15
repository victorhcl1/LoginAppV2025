using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace LoginAppV2025
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                               ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Com Hexadecimal

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                var theme = Microsoft.Maui.Controls.Application.Current?.RequestedTheme;
                if (theme == AppTheme.Dark)
                {
                    Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#000000")); // Preto
                }
                else
                {
                    Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#038C7F")); // Amarelo Ouro
                }
            }

            //if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            //{
            //    var theme = App.Current?.RequestedTheme;
            //    if (theme == AppTheme.Dark)
            //    {
            //        Window.SetStatusBarColor(Android.Graphics.Color.Black);
            //    }
            //    else
            //    {
            //        Window.SetStatusBarColor(Android.Graphics.Color.Yellow);
            //    }
            //}
        }
    }
}
