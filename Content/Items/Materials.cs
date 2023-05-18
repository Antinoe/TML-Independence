using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Items
{
	public class StoneShards : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stone Shards");
			// Tooltip.SetDefault("A small pile of stone shards.");
		}
        public override string Texture => "Independence/Content/Items/Materials/StoneShards";

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