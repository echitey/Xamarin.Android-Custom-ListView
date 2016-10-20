using System;
namespace AndroidCustomListView
{
	public class Character
	{
		public string name { get; set; }
		public int age { get; set; }
		public int pictureId { get; set; }
		public override string ToString()
		{
			return string.Format("[Character: name={0}, age={1}, pictureId={2}]", name, age, pictureId);
		}
	}
}
