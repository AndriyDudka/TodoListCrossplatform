using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using Java.Lang;
using TodoList.Core;

namespace TodoList.Droid
{
	public class MyAdapter : BaseAdapter<Person>
	{
		private List<Person> mItems;
		private Context mContext;

		public MyAdapter(Context context, List<Person> items)
		{
			mContext = context;
			mItems = items;
		}


		public override int Count
		{
			get
			{
				return mItems.Count;
			}
		}

		public override Person this[int position]
		{
			get
			{
				return mItems[position];
			}
		}


		public override long GetItemId(int position)
		{
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var view = convertView;

			if (view == null)
			{
				view = LayoutInflater.From(mContext).Inflate(Android.Resource.Layout.SimpleListItem1, null, false);
			}

			TextView txtview = view.FindViewById<TextView>(Android.Resource.Id.Text1);
			txtview.Text = mItems[position].Name;

			return view;
		}
	}
}

