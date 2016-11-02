using Acr.UserDialogs;
using Android.App;
using Android.Widget;
using Android.OS;
using Portable;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        private readonly Class1 _class1 = new Class1();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            UserDialogs.Init(this);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate
            {
                button.Text = $"{count++} clicks!";
                _class1.EditMediaCommand.Execute();

            };
        }
    }
}

