using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Recipes
{
	public class Tools : ModSystem
	{
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.enableTools)
			{
				Recipe.Create(ItemID.Sickle,1)
				.AddRecipeGroup(RecipeGroupID.Wood, 3)
				.AddIngredient(ItemID.StoneBlock, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.BugNet,1)
				.AddRecipeGroup(RecipeGroupID.Wood, 3)
				.AddIngredient(ItemID.Cobweb, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
        }
	}
}