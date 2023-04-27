using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Recipes
{
	public class Liquids : ModSystem
	{
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.enableLiquids)
			{
				Recipe.Create(ItemID.BottledWater,1)
				.AddIngredient(ItemID.Bottle, 1)
				.AddIngredient(ItemID.SnowBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.BottledWater,1)
				.AddIngredient(ItemID.Bottle, 1)
				.AddIngredient(ItemID.Cactus, 1)
				.Register();
				
				Recipe.Create(ItemID.BottledWater,1)
				.AddIngredient(ItemID.Bottle, 1)
				.AddIngredient(ItemID.BambooBlock, 1)
				.Register();
				
				Recipe.Create(ItemID.WaterBucket,1)
				.AddIngredient(ItemID.EmptyBucket, 1)
				.AddIngredient(ItemID.SnowBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.WaterBucket,1)
				.AddIngredient(ItemID.EmptyBucket, 1)
				.AddIngredient(ItemID.Cactus, 3)
				.Register();
				
				Recipe.Create(ItemID.WaterBucket,1)
				.AddIngredient(ItemID.EmptyBucket, 1)
				.AddIngredient(ItemID.BambooBlock, 3)
				.Register();
				
				Recipe.Create(ItemID.LavaBucket,3)
				.AddIngredient(ItemID.EmptyBucket, 3)
				.AddIngredient(ItemID.Hellstone, 1)
				.Register();
				
				Recipe.Create(ItemID.HoneyBucket,1)
				.AddIngredient(ItemID.EmptyBucket, 1)
				.AddIngredient(ItemID.BottledHoney, 3)
				.Register();
				
				Recipe.Create(ItemID.SnowBlock,10)
				.AddIngredient(ItemID.BottledWater,1)
				.AddTile(TileID.IceMachine)
				.Register();
				
				Recipe.Create(ItemID.SnowBlock,3)
				.AddIngredient(ItemID.IceBlock,1)
				.Register();
				
				Recipe.Create(ItemID.IceBlock,1)
				.AddIngredient(ItemID.SnowBlock,3)
				.Register();
			}
        }
	}
}