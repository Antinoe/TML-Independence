using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Recipes
{
	public class Fruits : ModSystem
	{
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.enableFruits)
			{
				Recipe.Create(ItemID.Apple,1)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Daybloom, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.Peach,1)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Daybloom, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.Lemon,1)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Daybloom, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.Apricot,1)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Daybloom, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.Grapefruit,1)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Daybloom, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.Cherry,1)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Shiverthorn, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.Plum,1)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Shiverthorn, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.Banana,1)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Waterleaf, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.Coconut,1)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Waterleaf, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.Mango,1)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Moonglow, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.Pineapple,1)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.Mushroom, 1)
				.AddIngredient(ItemID.Moonglow, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.Elderberry,3)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.VileMushroom, 1)
				.AddIngredient(ItemID.Deathweed, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(4284,3) //Blackcurrant
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.VileMushroom, 1)
				.AddIngredient(ItemID.Deathweed, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.BloodOrange,3)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.ViciousMushroom, 1)
				.AddIngredient(ItemID.Deathweed, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.Rambutan,3)
				.AddIngredient(ItemID.Hay, 3)
				.AddIngredient(ItemID.Acorn, 1)
				.AddIngredient(ItemID.ViciousMushroom, 1)
				.AddIngredient(ItemID.Deathweed, 1)
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
			}
        }
	}
}