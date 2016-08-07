using System;
using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using TodoList.Core;

namespace TodoList.Droid
{
	public class Setup : MvxAndroidSetup
	{
		public Setup(Context appContext) : base(appContext)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			var app = new Application();
			return app;
		}
	}
}

