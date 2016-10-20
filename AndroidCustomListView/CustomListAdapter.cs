using System;
using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace AndroidCustomListView
{
	public class CustomListAdapter : BaseAdapter
	{
		private Activity ctx;
		private List<Character> characters;
		public CustomListAdapter(Activity _ctx, List<Character> _characters)
		{
			ctx = _ctx;
			characters = _characters;
		}

		public override int Count
		{
			get
			{
				return characters.Count;
			}
		}

		public override Java.Lang.Object GetItem(int position)
		{
			return null;
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			View view = convertView;
			if (view == null)
			{
				view = ctx.LayoutInflater.Inflate(Resource.Layout.CustomRow, null);
			}
			var character = characters[position];

			view.FindViewById<ImageView>(Resource.Id.imgView).SetImageResource(character.pictureId);
			view.FindViewById<TextView>(Resource.Id.textHeader).Text = character.name;
			view.FindViewById<TextView>(Resource.Id.textSub).Text = "Age: "+character.age;

			return view;
		}
	}
}
