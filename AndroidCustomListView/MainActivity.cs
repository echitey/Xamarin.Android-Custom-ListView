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
		
		public List<Character> characters;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			characters = getCharacters();


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

