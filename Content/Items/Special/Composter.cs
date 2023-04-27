using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;


namespace Independence.Content.Items.Special
{
	public class Composter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Composter");
		}
		
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
}