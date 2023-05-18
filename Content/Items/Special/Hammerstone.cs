using System;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace Independence.Content.Items.Special
{
	public class GrindingKit : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 18;
			Item.maxStack = 30;
			Item.rare = 0;
			Item.value = 10;
		}

		/*public override void AddRecipes()
        {
			CreateRecipe(1)
            .AddIngredient(ItemID.StoneBlock, 3)
            .Register();
        }*/
	}
}
