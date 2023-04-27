using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Recipes
{
	public class Workstations : ModSystem
	{
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.enableWorkstations)
			{
				Recipe.Create(ItemID.LivingLoom,1)
				.AddRecipeGroup(RecipeGroupID.Wood, 20)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.Extractinator,1)
				.AddRecipeGroup(RecipeGroupID.Wood, 12)
				.AddIngredient(ItemID.StoneBlock, 20)
				.AddIngredient(ItemID.SandBlock, 20)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.IceMachine,1)
				.AddIngredient(ItemID.ClayBlock, 20)
				.AddTile(TileID.Furnaces)
				.Register();
				
				Recipe.Create(ItemID.TinkerersWorkshop,1)
				.AddIngredient(ItemID.SpikyBall, 20)
				.AddIngredient(ItemID.TatteredCloth, 5)
				.AddRecipeGroup(RecipeGroupID.Wood, 20)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
        }
	}
}