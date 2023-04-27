using System;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace Independence.Content.Items.Special
{
	public class MortarPestle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mortar and Pestle");
			Tooltip.SetDefault("Right Click items on this tool to grind them up.");
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 1;
			Item.rare = 1;
			Item.value = 100;
			Item.consumable = false;
		}

		public override bool CanRightClick()	{	return true;	}

		public override void AddRecipes()
        {
			CreateRecipe(1)
            .AddIngredient(ItemID.Wood, 5)
            .Register();
        }
	}
}
