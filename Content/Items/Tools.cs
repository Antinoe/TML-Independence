using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Items
{
	public class StoneAxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Stone Axe");
			//Tooltip.SetDefault("Bare Hands: Break Blocks.");
		}
        public override string Texture => "Independence/Content/Items/Tools/StoneAxe";

		public override void SetDefaults() 
		{
			Item.damage = IndependenceConfig.Instance.toolsStoneAxeDamage;
			Item.width = 32;
			Item.height = 32;
			Item.useTime = IndependenceConfig.Instance.toolsStoneAxeUseTime;
			Item.useAnimation = IndependenceConfig.Instance.toolsStoneAxeUseTime;
			Item.useStyle = 1;
			Item.knockBack = 5;
			Item.value = 100;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.axe = IndependenceConfig.Instance.toolsStoneAxeMineSpeed;
			Item.DamageType = DamageClass.Melee; //This is what allows Reforging to work on this item.
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddRecipeGroup(RecipeGroupID.Wood, 3)
            .AddIngredient(3,9) //Stone
            .Register();
		}
	}
	public class StonePickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Stone Pickaxe");
			//Tooltip.SetDefault("A rudimentary Pickaxe.");
		}
        public override string Texture => "Independence/Content/Items/Tools/StonePickaxe";

		public override void SetDefaults() 
		{
			Item.damage = IndependenceConfig.Instance.toolsStonePickaxeDamage;
			Item.width = 32;
			Item.height = 32;
			Item.useTime = IndependenceConfig.Instance.toolsStonePickaxeUseTime;
			Item.useAnimation = IndependenceConfig.Instance.toolsStonePickaxeUseTime;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 100;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.pick = IndependenceConfig.Instance.toolsStonePickaxeMineSpeed;
			Item.DamageType = DamageClass.Melee; //This is what allows Reforging to work on this item.
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddRecipeGroup(RecipeGroupID.Wood, 3)
            .AddIngredient(3,12) //Stone
            .Register();
		}
	}
	public class WoodenStub : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Wooden Stub");
			// Tooltip.SetDefault("Right-Click to hammer tiles." + "\n'For when there is truly nothing else.'");
		}
        public override string Texture => "Independence/Content/Items/Tools/WoodenStub";

		public override void SetDefaults()
		{
			Item.axe = 1;
			Item.pick = 1;
			Item.hammer = 0;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}
		
		public override bool AltFunctionUse(Player Player) => true;
		public override bool CanUseItem(Player Player)
		{
			/*if (Player.altFunctionUse == 2)
			{
				Item.hammer = 1;
				Item.axe = 1;
				Item.pick = 1;
				Item.autoReuse = true;
			}
			else
			{
				Item.axe = 1;
				Item.pick = 1;
				Item.hammer = 0;
			}*/
			return true;
		}
		
		public override void AddRecipes()
		{
			if (IndependenceConfig.Instance.craftWoodenStub)
			{
				CreateRecipe(1)
				.AddRecipeGroup("Wood", 1)
				.Register();
			}
		}
	}
}