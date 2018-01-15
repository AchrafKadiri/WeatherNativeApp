using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
namespace WeatherApp.Droid.Views
{
    [Activity(Label = "View for MainViewModel")]
    public class MainView : MvxActivity<WeatherApp.Core.ViewModels.MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);

           
            
        }
    }
}
