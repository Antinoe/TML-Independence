using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Independence.Content.Items;
using Independence.Content.Items.Weapons;
using Independence.Content.Items.Tools;
using Independence.Content.Items.Consumables;

namespace Independence.Content.Items.Special
{
	public class CrudeBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crude Bag");
			// Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

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
}