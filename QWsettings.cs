using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModSettings;

namespace QuickWitted
{
    internal class Settings : JsonModSettings 
    {
		[Name("Archery Rate")]
		[Description("Multiplies the skill points recieved from completing an action")]
		[Slider(1, 10)]
		public int archeryrate = 1;

		[Name("Carcass Harvesting Rate")]
		[Description("Multiplies the skill points recieved from completing an action")]
		[Slider(1, 10)]
		public int carcassharvestingrate = 1;

		[Name("Clothing Repair Rate")]
		[Description("Multiplies the skill points recieved from completing an action")]
		[Slider(1, 10)]
		public int clothingrepairrate = 1;

		[Name("Cooking Rate")]
		[Description("Multiplies the skill points recieved from completing an action")]
		[Slider(1, 10)]
		public int cookingrate = 1;

		[Name("Firestarting Rate")]
		[Description("Multiplies the skill points recieved from completing an action")]
		[Slider(1, 10)]
		public int firestartingrate = 1;

		[Name("Gunsmithing Rate")]
		[Description("Multiplies the skill points recieved from completing an action")]
		[Slider(1, 10)]
		public int gunsmithingrate = 1;

		[Name("Icefishing Rate")]
		[Description("Multiplies the skill points recieved from completing an action")]
		[Slider(1, 10)]
		public int icefishingrate = 1;

		[Name("Revolver Rate")]
		[Description("Multiplies the skill points recieved from completing an action")]
		[Slider(1, 10)]
		public int revolverrate = 1;

		[Name("Rifle Rate")]
		[Description("Multiplies the skill points recieved from completing an action")]
		[Slider(1, 10)]
		public int riflerate = 1;

		[Name("Tool Repair Rate")]
		[Description("Multiplies the skill points recieved from completing an action")]
		[Slider(1, 10)]
		public int toolrepairrate = 1;


	}
	internal static class QuickWittedModSettings
	{

		internal static readonly Settings settings = new Settings();

		public static void OnLoad()
		{
			settings.AddToModSettings("Quick Witted");
		}
	}
}
