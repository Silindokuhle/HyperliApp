using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using HyperliApp.Droid;
using System.Threading.Tasks;
using Android.Systems;
namespace HyperliApp.Droid
{

     [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
        public class SplashActivity : AppCompatActivity
        {
             protected override void OnCreate(Bundle savedInstanceState)
             {
                  base.OnCreate(savedInstanceState);
             }


        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
 }
