using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Independence.Content.Items;

namespace Independence.Content.Items
{
	public class MortarPestle : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Mortar and Pestle");
			// Tooltip.SetDefault("Right Click items on this tool to grind them up.");
		}
        public override string Texture => "Independence/Content/Items/Special/MortarPestle";

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 1;
			Item.rare = 1;
			Item.value = 100;
			Item.consumable = false;
		}

		public override bool CanRightClick()	{	return true;	}

		public override void AddRecipes()
        {
			CreateRecipe(1)
            .AddRecipeGroup("Wood", 5)
            .Register();
        }
	}
	public class Composter : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Composter");
		}
        public override string Texture => "Independence/Content/Items/Special/Composter";
		
		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 1;
			Item.consumable = false;
			Item.rare = 1;
			Item.value = 100;
		}
		
		/*public override bool ConsumeItem(Player Player) //Prevents the item from vanishing upon stowing items.
		{
			return false;
		}
		
		public override bool CanRightClick() //Allows the bundle's main features to function.
		{
			return true;
		}
		
		public override void RightClick(Player Player)
		{
			var source = Player.GetItemSource_Misc(1);
			if (Player.whoAmI == Main.myPlayer)
			{
				if (!Main.mouseItem.IsAir) //If an item is in hand.
				{
					if (Main.mouseItem.type == ItemID.Waterleaf)
					{
						Player.QuickSpawnItem(source, ItemID.Apple, 1);
						Main.mouseItem.TurnToAir();
						return;
					}
				}
			}
		}*/
	}
	public class CrudeBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crude Bag");
			// Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}
        public override string Texture => "Independence/Content/Items/Special/CrudeBag";

		public override void SetDefaults()
		{
			Item.maxStack = 999;
			Item.consumable = true;
			Item.width = 24;
			Item.height = 24;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player Player)
		{
			var source = Player.GetSource_OpenItem(Type);
			
			if (IndependenceConfig.Instance.giveWoodenStake)
			{
				Player.QuickSpawnItem(source, ModContent.ItemType<WoodenStake>(), 1);
			}
			if (IndependenceConfig.Instance.giveWoodenClub)
			{
				Player.QuickSpawnItem(source, ModContent.ItemType<WoodenClub>(), 1);
			}
			if (IndependenceConfig.Instance.giveStoneAxe)
			{
				Player.QuickSpawnItem(source, ModContent.ItemType<StoneAxe>(), 1);
			}
			if (IndependenceConfig.Instance.giveStonePickaxe)
			{
				Player.QuickSpawnItem(source, ModContent.ItemType<StonePickaxe>(), 1);
			}
			if (IndependenceConfig.Instance.giveWeedWrap > 0)
			{
				Player.QuickSpawnItem(source, ModContent.ItemType<WeedWrap>(), IndependenceConfig.Instance.giveWeedWrap);
			}
			if (IndependenceConfig.Instance.giveHerbalWeedWrap > 0)
			{
				Player.QuickSpawnItem(source, ModContent.ItemType<HerbalWeedWrap>(), IndependenceConfig.Instance.giveHerbalWeedWrap);
			}
		}
	}
	public class GrindingKit : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Grinding Kit");
			// Tooltip.SetDefault("Right Click to strike these rocks together for Stone Shards.");
		}
        public override string Texture => "Independence/Content/Items/Special/GrindingKit";

		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 18;
			Item.maxStack = 30;
			Item.rare = 0;
			Item.value = 10;
		}

		/*public override void AddRecipes()
        {
			CreateRecipe(1)
            .AddIngredient(ItemID.StoneBlock, 3)
            .Register();
        }*/
	}
	public class Hammerstone : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 18;
			Item.maxStack = 30;
			Item.rare = 0;
			Item.value = 10;
		}
        public override string Texture => "Independence/Content/Items/Special/Hammerstone";

		/*public override void AddRecipes()
        {
			CreateRecipe(1)
            .AddIngredient(ItemID.StoneBlock, 3)
            .Register();
        }*/
	}
}