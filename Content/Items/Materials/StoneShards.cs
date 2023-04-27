using System;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace Independence.Content.Items.Materials
{
	public class StoneShards : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stone Shards");
			Tooltip.SetDefault("A small pile of stone shards.");
		}

		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 18;
			Item.maxStack = 30;
			Item.rare = 0;
			Item.value = 10;
		}
	}
}
