using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Recipes
{
	public class Organics : ModSystem
	{
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.enableOrganics)
			{
				Recipe.Create(ItemID.RottenChunk,1)
				.AddIngredient(ItemID.WormTooth, 2)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
        }
	}
}