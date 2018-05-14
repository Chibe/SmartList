using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace SmartList
{
    [Activity(Label = "SmartList", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our UI controls from the loaded layout
            TextView existingLists = FindViewById<TextView>(Resource.Id.ExistingList);
            Button createListButton = FindViewById<Button>(Resource.Id.CreateListButton);
            Button createRecipeButton = FindViewById<Button>(Resource.Id.CreateNewRecipeButton);

            createListButton.Click += (sender, e) =>
             {
                 var intent = new Intent(this, typeof(ListCreateActivity));
                 
             };
        }
    }
}

