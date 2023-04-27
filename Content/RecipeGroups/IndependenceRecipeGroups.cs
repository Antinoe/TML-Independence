using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Independence
{
	public class IndependenceRecipeGroups : ModSystem
	{
		public override void AddRecipeGroups()
		{
		//	Moss
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("Any Moss"), new int[]
			{
				ItemID.GreenMoss,
				ItemID.BrownMoss,
				ItemID.BlueMoss,
				ItemID.PurpleMoss,
				ItemID.LavaMoss,
				ItemID.KryptonMoss,
				ItemID.XenonMoss,
				ItemID.ArgonMoss
			});
			RecipeGroup.RegisterGroup("Independence:Moss", group);
		//	Herbs
			group = new RecipeGroup(() => Language.GetTextValue("Any Herb"), new int[]
			{
				ItemID.Blinkroot,
				ItemID.Daybloom,
				ItemID.Deathweed,
				ItemID.Fireblossom,
				ItemID.Moonglow,
				ItemID.Shiverthorn,
				ItemID.Waterleaf
			});
			RecipeGroup.RegisterGroup("Independence:Herbs", group);
			
		//	Potent Herbs
			group = new RecipeGroup(() => Language.GetTextValue("Any Potent Herb"), new int[]
			{
				ItemID.TealMushroom,
				ItemID.YellowMarigold,
				ItemID.PinkPricklyPear,
				ItemID.GreenMushroom,
				ItemID.BlueBerries,
				ItemID.OrangeBloodroot,
				ItemID.SkyBlueFlower,
				ItemID.LimeKelp
			});
			RecipeGroup.RegisterGroup("Independence:HerbsPotent", group);
		}
	}
}