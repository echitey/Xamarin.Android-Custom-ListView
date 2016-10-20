using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System;

namespace AndroidCustomListView
{
	[Activity(Label = "AndroidCustomListView", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		
		private List<Character> characters;
		CustomListAdapter adapter;
		ListView characterListView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			characterListView = FindViewById<ListView>(Resource.Id.listView);

			characters = getCharacters();
			adapter = new CustomListAdapter(this, characters);

			characterListView.Adapter = adapter;

			characterListView.ItemClick += CharacterListView_ItemClick;

		}

		void CharacterListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			var selected = characters[e.Position];
			Toast.MakeText(this, selected.ToString(), ToastLength.Short).Show();
		}

		private List<Character> getCharacters()
		{
			var _characters = new List<Character>();
			_characters.Add(new Character { name = "Goomba", age = 12, pictureId = Resource.Drawable.Goomba});
			_characters.Add(new Character { name = "Bowser", age = 23, pictureId = Resource.Drawable.PaperBowser });
			_characters.Add(new Character { name = "Mario", age = 34, pictureId = Resource.Drawable.PaperMario });
			_characters.Add(new Character { name = "Racoon Mario", age = 35, pictureId = Resource.Drawable.RacoonMario });
			_characters.Add(new Character { name = "Shyguy Green", age = 11, pictureId = Resource.Drawable.ShyguyGreen });
			_characters.Add(new Character { name = "MArio Baby", age = 12, pictureId = Resource.Drawable.SuperBabyMario });
			_characters.Add(new Character { name = "Yoshi", age = 23, pictureId = Resource.Drawable.Yoshi });

			return _characters;
		}
	}
}

