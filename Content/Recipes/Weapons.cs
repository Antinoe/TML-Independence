using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Recipes
{
	public class Weapons : ModSystem
	{
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.enableWeapons)
			{
				Recipe.Create(ItemID.ExplosivePowder,1)
				.AddIngredient(ItemID.Coal, 1)
				.AddIngredient(ItemID.Bone, 3)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.Grenade,4)
				.AddRecipeGroup(RecipeGroupID.IronBar, 1)
				.AddIngredient(ItemID.ExplosivePowder, 1)
				.AddTile(TileID.Anvils)
				.Register();
				
				Recipe.Create(ItemID.Bomb,4)
				.AddRecipeGroup(RecipeGroupID.IronBar, 2)
				.AddIngredient(ItemID.ExplosivePowder, 1)
				.AddTile(TileID.Anvils)
				.Register();
			}
        }
	}
}