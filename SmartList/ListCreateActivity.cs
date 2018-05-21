using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SmartList
{
    [Activity(Label = "New List")]
    public class ListCreateActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ListCreate);

            List<string> listItems = new List<string>();
            EditText itemTextAdd = FindViewById<EditText>(Resource.Id.itemTextAdd);
            ListView itemList = FindViewById<ListView>(Resource.Id.itemList);
            Button addItem = FindViewById<Button>(Resource.Id.addItem);
            Button addRecipe = FindViewById<Button>(Resource.Id.addRecipe);
            TextView listName = FindViewById<TextView>(Resource.Id.listName);

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, listItems);
            itemList.SetAdapter(adapter);

            addItem.Click += (sender, e) =>
            {
                if(itemTextAdd.Text.Length > 0)
                {
                    adapter.Add(itemTextAdd.Text.ToString());
                }
            };
        }
    }
}