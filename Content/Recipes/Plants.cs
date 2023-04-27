using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Recipes
{
	public class Plants : ModSystem
	{
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.enablePlants)
			{
				Recipe.Create(ItemID.Cactus,5)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.SandBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.BambooBlock,5)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.MudBlock, 1)
				.Register();
			}
        }
	}
}