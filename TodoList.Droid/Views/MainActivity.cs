using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Droid.Views;
using TodoList.Core;
using MvvmCross.Binding.BindingContext;
using System.Collections.Generic;
using System;
using Android.Content;

namespace TodoList.Droid
{
	[Activity(Label = "TodoList", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : MvxActivity<FirstViewModel>
	{
		
		private ListView mListView;

		private List<Person> myItems = new List<Person>
			{
				new Person() { Name = "item1", DetailInformation = "someInformation1"},
				new Person() { Name = "item2", DetailInformation = "someInformation2"},
				new Person() { Name = "item3", DetailInformation = "someInformation3"},
			};

		protected override void OnViewModelSet()
		{
			base.OnViewModelSet();
			SetContentView(Resource.Layout.Main);

			//var bindingSet = this.CreateBindingSet<MainActivity, FirstViewModel>();

			mListView = FindViewById<ListView>(Resource.Id.myListView);

			int i = 0;
			foreach (var p in myItems)
			{
				p.Id = i++;
			}


			MyAdapter mAdapter = new MyAdapter(this, myItems);
			mListView.Adapter = mAdapter;

			mListView.ItemClick += ClickOnmListView;
		}


		void ClickOnmListView(object sender, AdapterView.ItemClickEventArgs e)
		{
			Intent intent = new Intent(this, typeof(SecondActivity));	
			intent.PutExtra("UserId", e.Position.ToString());
			StartActivity(intent);
		}
}
}


