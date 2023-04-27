using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence
{
	public class IndependencePlayer : ModPlayer
	{
		//Remove Vanilla's starting Items.
		public override void ModifyStartingInventory(IReadOnlyDictionary<string, List<Item>> ItemsByMod, bool mediumCoreDeath)
		{
			if (!IndependenceConfig.Instance.giveCopperSet)
			{
				ItemsByMod["Terraria"].RemoveAll((Item Item) => Item.type == 3506);
				ItemsByMod["Terraria"].RemoveAll((Item Item) => Item.type == 3509);
				ItemsByMod["Terraria"].RemoveAll((Item Item) => Item.type == 3507);
			}
		}
		//Add Crude Bag.
		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
		{
			return new Item[]
			{
				new Item(ModContent.ItemType<Content.Items.Special.CrudeBag>(), 1, 0)
			};
		}
	}
}