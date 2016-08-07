
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
using MvvmCross.Droid.Views;
using TodoList.Core;

namespace TodoList.Droid
{
	[Activity(Label = "SecondActivity")]
	public class SecondActivity : MvxActivity<FirstViewModel>
	{
		private int _id;
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.DetailLayout);

			TextView txtView = FindViewById<TextView>(Resource.Id.textView);
			txtView.Text = Intent.GetStringExtra("UserId");
			_id = Convert.ToInt32(Intent.GetStringExtra("UserId"));

			var btnDelete = FindViewById<Button>(Resource.Id.deleteButton);

			btnDelete.Click += OnClickButtonDelete;
		}

		void OnClickButtonDelete(object sender, EventArgs e)
		{
			new FirstViewModel().OnClickDelete(_id);
		}
}
}

