using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Recipes
{
	public class HerbsMushrooms : ModSystem
	{
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.enableHerbsMushrooms)
			{
				Recipe.Create(ItemID.Mushroom,1)
				.AddIngredient(ItemID.Hay, 50)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.Mushroom,3)
				.AddIngredient(ItemID.RottenChunk, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.Mushroom,3)
				.AddIngredient(ItemID.Vertebrae, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.VileMushroom,1)
				.AddIngredient(ItemID.RottenChunk, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.ViciousMushroom,1)
				.AddIngredient(ItemID.Vertebrae, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
			}
        }
	}
}