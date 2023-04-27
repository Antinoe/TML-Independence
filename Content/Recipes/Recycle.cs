using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Recipes
{
	public class Recycle : ModSystem
	{
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.enableRecycle)
			{
				Recipe.Create(ItemID.Mushroom,4)
				.AddIngredient(ItemID.Seaweed, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.Leather,4)
				.AddIngredient(ItemID.OldShoe, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.TinBar,4)
				.AddIngredient(ItemID.TinCan, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
        }
	}
}