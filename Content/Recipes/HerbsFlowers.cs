using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Recipes
{
	public class HerbsFlowers : ModSystem
	{
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.enableHerbsFlowers)
			{
				Recipe.Create(ItemID.Daybloom,2)
				.AddIngredient(ItemID.DaybloomSeeds, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.Shiverthorn,2)
				.AddIngredient(ItemID.ShiverthornSeeds, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.Waterleaf,2)
				.AddIngredient(ItemID.WaterleafSeeds, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.Moonglow,2)
				.AddIngredient(ItemID.MoonglowSeeds, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.Blinkroot,2)
				.AddIngredient(ItemID.BlinkrootSeeds, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.Deathweed,2)
				.AddIngredient(ItemID.DeathweedSeeds, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
			}
        }
	}
}