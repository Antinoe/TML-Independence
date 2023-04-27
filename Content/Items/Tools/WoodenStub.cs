using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;

namespace Independence.Content.Items.Tools
{
	public class WoodenStub : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Wooden Stub");
			Tooltip.SetDefault("Right-Click to hammer tiles." + "\n'For when there is truly nothing else.'");
		}

		public override void SetDefaults()
		{
			Item.axe = 1;
			Item.pick = 1;
			Item.hammer = 0;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}
		
		public override bool AltFunctionUse(Player Player) => true;
		
		public override bool CanUseItem(Player Player)
		{
			if (Player.altFunctionUse == 2)
			{
				Item.hammer = 1;
				Item.axe = 1;
				Item.pick = 1;
				Item.autoReuse = true;
			}
			else
			{
				Item.axe = 1;
				Item.pick = 1;
				Item.hammer = 0;
			}
			return true;
		}
		
		public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddIngredient(ItemID.Acorn, 5)
            .Register();
		}
	}
}