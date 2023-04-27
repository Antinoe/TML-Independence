using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Recipes
{
	public class Seeds : ModSystem
	{
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.enableSeeds)
			{
				Recipe.Create(ItemID.GrassSeeds,3)
				.AddIngredient(ItemID.GreenMoss, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.JungleGrassSeeds,3)
				.AddIngredient(ItemID.BrownMoss, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.MudBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.MushroomGrassSeeds,3)
				.AddIngredient(ItemID.BlueMoss, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.CorruptSeeds,3)
				.AddIngredient(ItemID.PurpleMoss, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.CrimsonSeeds,3)
				.AddIngredient(ItemID.RedMoss, 1)
				.AddIngredient(ItemID.Hay, 2)
				.AddIngredient(ItemID.DirtBlock, 1)
				.Register();
			}
        }
	}
}