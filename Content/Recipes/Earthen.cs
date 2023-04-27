using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Recipes
{
	public class Earthen : ModSystem
	{
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.enableEarthen)
			{
				Recipe.Create(ItemID.AshBlock,2)
				.AddRecipeGroup(RecipeGroupID.Wood, 1)
				.AddTile(TileID.Furnaces)
				.Register();
				
				Recipe.Create(ItemID.AshBlock,2)
				.AddRecipeGroup(RecipeGroupID.Wood, 1)
				.AddIngredient(ItemID.Torch, 3)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.Coal,1)
				.AddIngredient(ItemID.AshBlock, 16)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.StoneBlock,1)
				.AddIngredient(ItemID.AshBlock, 4)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.SiltBlock,2)
				.AddIngredient(ItemID.StoneBlock, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.SandBlock,2)
				.AddIngredient(ItemID.SiltBlock, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.DirtBlock,3)
				.AddIngredient(ItemID.SiltBlock, 1)
				.AddIngredient(ItemID.SandBlock, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.DirtBlock,1)
				.AddIngredient(ItemID.Hay, 6)
				.Register();
				
				Recipe.Create(ItemID.ClayBlock,1)
				.AddIngredient(ItemID.MudBlock, 2)
				.Register();
			}
        }
	}
}