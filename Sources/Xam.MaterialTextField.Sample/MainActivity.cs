using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

namespace Xam.MaterialTextField.Sample
{
	[Activity(Label = "MaterialTextField", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);

			var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetSupportActionBar(toolbar);
			toolbar.SetTitleTextColor(Color.White);

			var supportActionBar = SupportActionBar;
			if (supportActionBar != null)
			{
				supportActionBar.SetDisplayShowHomeEnabled(true);
			}
		}
	}
}

