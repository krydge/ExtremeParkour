using Android.App;
using Android.Content.PM;
using Android.OS;
using ExtremeParkour1.Droid;
using Prism;
using Prism.Ioc;

namespace ExtremeParkour.Droid
{
    [Activity(Label = "ExtremeParkour", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = ExtremeParkour1.Droid.Resource.Layout.Tabbar;
            ToolbarResource = ExtremeParkour1.Droid.Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register any platform specific implementations
        }
    }
}

