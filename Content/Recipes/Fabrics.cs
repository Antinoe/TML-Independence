using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Recipes
{
	public class Fabrics : ModSystem
	{
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.enableFabrics)
			{
				Recipe.Create(ItemID.Rope,3)
				.AddIngredient(ItemID.Cobweb, 1)
				.Register();
				
				Recipe.Create(ItemID.Cobweb,2)
				.AddRecipeGroup("Independence:Moss", 1)
				.Register();
				
				Recipe.Create(ItemID.TatteredCloth,1)
				.AddIngredient(ItemID.Cobweb, 14)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.Silk,1)
				.AddIngredient(ItemID.TatteredCloth, 2)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.Leather,1)
				.AddIngredient(ItemID.Silk, 3)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.Cobweb,2)
				.AddIngredient(ItemID.Acorn, 1)
				.Register();
				
				Recipe.Create(ItemID.Cobweb,1)
				.AddIngredient(ItemID.Hay, 2)
				.Register();
				
				Recipe.Create(ItemID.Cobweb,10)
				.AddIngredient(ItemID.Vine, 1)
				.Register();
				
				Recipe.Create(ItemID.Hay,2)
				.AddIngredient(ItemID.Cobweb, 1)
				.Register();
			}
        }
	}
}