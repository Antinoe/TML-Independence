using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using System.IO;
using Terraria;
using Terraria.Audio;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Independence.Content.Items;

namespace Independence
{
	/*public class RightClickTest : GlobalItem
	{
		public override bool CanRightClick(Item item)
		{
			if (item.type == ItemID.Hay)
			{
				return true;
			}
			return false;
		}
		public override void RightClick(Item item, Player player)
		{
			if (item.type == ItemID.Hay)
			{
				Main.NewText("RightClick");
				SoundEngine.PlaySound(SoundID.MenuTick, player.position);
			}
		}
	}*/
    public class IndependenceGlobalItem : GlobalItem
	{
        public override void SetDefaults(Item Item)
		{
			if (IndependenceConfig.Instance.enableTools)
			{
				if (Item.type == ItemID.Sickle)
				{
						Item.damage = 5;
						Item.value = 500;
				}
			}
			if (IndependenceConfig.Instance.enableWorkstations)
			{
				if (Item.type == ItemID.IceMachine)
				{
						Item.value = 1000;
				}
			}
			if (IndependenceConfig.Instance.enableEarthen)
			{
				if (Item.type == ItemID.Coal)
				{
						Item.maxStack = 99;
				}
			}
			if (IndependenceConfig.Instance.enableOrganics)
			{
				if (Item.type == ItemID.LivingLoom)
				{
						Item.value = 500;
				}
			}
		}
	}
	public class IndependenceRightClick : GlobalItem
	{
		public override void RightClick(Item item, Player player)
		{
			var source = player.GetSource_Misc("PlayerDropItemCheck");
			var heldItem = Main.mouseItem;
			bool isFlower = (heldItem.type == ItemID.Blinkroot || heldItem.type == ItemID.Daybloom || heldItem.type == ItemID.Deathweed || heldItem.type == ItemID.Fireblossom || heldItem.type == ItemID.Moonglow || heldItem.type == ItemID.Shiverthorn || heldItem.type == ItemID.Waterleaf);
			bool isVine = (heldItem.type == ItemID.Vine);
			bool isSapling = (heldItem.type == ItemID.Acorn);
			bool isHay = (heldItem.type == ItemID.Hay);
			bool isGrindable = (isFlower || isVine || isSapling || isHay);
			//	TODO: Make methods for Grinding and Sifting. May include details of input and output within parameter.

			//	Mortar and Pestle
			if (item.type == ModContent.ItemType<MortarPestle>())
			{
				item.stack++;
				if (isGrindable)
				{
					SoundEngine.PlaySound(SoundID.Dig with {Pitch = +2f, Volume = 1f}, player.position);
					heldItem.stack--;
					if (isHay)	{player.QuickSpawnItem(source, ItemID.Cobweb, Main.rand.Next(1,3));}
					if (isSapling)	{player.QuickSpawnItem(source, ItemID.Cobweb, Main.rand.Next(2,6));}
					if (isFlower)	{player.QuickSpawnItem(source, ItemID.Cobweb, Main.rand.Next(5,10));}
					if (isVine)	{player.QuickSpawnItem(source, ItemID.Cobweb, Main.rand.Next(10,20));}
				}
			}
			//	Sieve
			/*if (item.type == ModContent.ItemType<Content.Items.Sieve>())
			{
				if (heldItem == ItemID.GroundDaybloom)
				{
					//SoundEngine.PlaySound(SoundID.SieveSift);
					//heldItem = ItemID.DaybloomPowder;
				}
			}*/
		}
	}
}