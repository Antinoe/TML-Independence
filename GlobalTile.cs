﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.Audio;

namespace Independence
{

/*
	List:
	-Firewood
	-Stones
	-Berries
	-Mushrooms
	-Insects
	-Wild Herbs
	-Wild Plants
	-Trash
	-Animals
	-Crops
	-Medicinal Plants
	-Fruits

	Focus 1:
	-Mushrooms
	-Wild Herbs
	-Wild Plants
	-Trash
	-Medicinal Plants

	Focus 2:
	-Firewood
	-Stones

	Focus 3:
	-Berries
	-Insects
	-Animals
	-Crops
	-Fruits
*/

    public class IndependenceGlobalTile : GlobalTile
	{
		//public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        public override void RightClick(int i, int j, int type)
		{
			var holdShift = Main.keyState.IsKeyDown(Keys.LeftShift);
			var holdControl = Main.keyState.IsKeyDown(Keys.LeftControl);
			var holdAlt = Main.keyState.IsKeyDown(Keys.LeftAlt);
			var forageFocus1 = holdShift;
			var forageFocus2 = holdControl;
			var forageFocus3 = holdAlt;
			var forageFocus4 = holdShift && holdControl;
			bool plantCommon = (type == TileID.Plants || type == TileID.Plants2 || type == TileID.JunglePlants || type == TileID.JunglePlants2 || type == TileID.MushroomPlants || type == TileID.CorruptPlants || type == TileID.CrimsonPlants || type == TileID.AshPlants);
			bool plantCommonDefault = (type == TileID.Plants || type == TileID.Plants2);
			bool plantCommonJungle = (type == TileID.JunglePlants || type == TileID.JunglePlants2);
			bool plantCommonMushroom = (type == TileID.MushroomPlants);
			bool plantCommonCorrupt = (type == TileID.CorruptPlants);
			bool plantCommonCrimson = (type == TileID.CrimsonPlants);
			bool plantCommonAsh = (type == TileID.AshPlants);
			bool plantUncommon = (type == TileID.SeaOats || type == TileID.Cattail || type == TileID.LilyPad);
			bool plantVine = (type == TileID.Vines || type == TileID.VineFlowers || type == TileID.JungleVines || type == TileID.MushroomVines || type == TileID.CrimsonVines);

			if (type == TileID.MatureHerbs)
			{
				WorldGen.KillTile(i, j);
			}
			if (IndependenceConfig.Instance.enableForaging)
			{
				if (IndependenceConfig.Instance.enableForagingFromCommonPlants)
				{
					if (plantCommon)
					{
						if (forageFocus1)
						{
							if (Main.rand.Next(IndependenceConfig.Instance.plantBreakChance) == 0) {	WorldGen.KillTile(i, j);	}
							if (IndependenceConfig.Instance.enableForagingHay && Main.rand.Next(4) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Hay, 1);
							}
							if (IndependenceConfig.Instance.enableForagingCobweb && Main.rand.Next(10) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Cobweb, 1);
							}
							if (IndependenceConfig.Instance.enableForagingAcorn && Main.rand.Next(20) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Acorn, 1);
							}
							if (IndependenceConfig.Instance.enableForagingVine && Main.rand.Next(80) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Vine, 1);
							}
							if (IndependenceConfig.Instance.enableForagingHerbBag && Main.rand.Next(160) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.HerbBag, 1);
							}
						}
						if (forageFocus2)
						{
							if (Main.rand.Next(IndependenceConfig.Instance.plantBreakChance) == 0) {	WorldGen.KillTile(i, j);	}
							if (IndependenceConfig.Instance.enableForagingWood && Main.rand.Next(20) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Wood, 1);
							}
							if (IndependenceConfig.Instance.enableForagingStone && Main.rand.Next(20) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.StoneBlock, 1);
							}
						}
						if (plantCommonDefault)
						{
							if (forageFocus1)
							{
								if (Main.rand.Next(IndependenceConfig.Instance.plantBreakChance) == 0) {	WorldGen.KillTile(i, j);	}
								if (IndependenceConfig.Instance.enableForagingMoss && Main.rand.Next(10) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.GreenMoss, 1);
								}
							}
							if (forageFocus3)
							{
								if (Main.rand.Next(IndependenceConfig.Instance.plantBreakChance) == 0) {	WorldGen.KillTile(i, j);	}
								if (IndependenceConfig.Instance.enableForagingForFruits)
								{
									if (Main.rand.Next(IndependenceConfig.Instance.forageChanceFruitsForest) == 0)
									{
										Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Apple, 1);
									}
									if (Main.rand.Next(IndependenceConfig.Instance.forageChanceFruitsForest) == 0)
									{
										Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Apricot, 1);
									}
									if (Main.rand.Next(IndependenceConfig.Instance.forageChanceFruitsForest) == 0)
									{
										Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Grapefruit, 1);
									}
									if (Main.rand.Next(IndependenceConfig.Instance.forageChanceFruitsForest) == 0)
									{
										Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Lemon, 1);
									}
									if (Main.rand.Next(IndependenceConfig.Instance.forageChanceFruitsForest) == 0)
									{
										Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Peach, 1);
									}
								}
							}
						}
						if (plantCommonJungle)
						{
							if (forageFocus1)
							{
								if (Main.rand.Next(IndependenceConfig.Instance.plantBreakChance) == 0) {	WorldGen.KillTile(i, j);	}
								if (IndependenceConfig.Instance.enableForagingMoss && Main.rand.Next(10) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.BrownMoss, 1);
								}
							}
							if (forageFocus3)
							{
								if (Main.rand.Next(IndependenceConfig.Instance.plantBreakChance) == 0) {	WorldGen.KillTile(i, j);	}
								if (IndependenceConfig.Instance.enableForagingForFruits)
								{
									if (Main.rand.Next(IndependenceConfig.Instance.forageChanceFruitsJungle) == 0)
									{
										Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Mango, 1);
									}
									if (Main.rand.Next(IndependenceConfig.Instance.forageChanceFruitsJungle) == 0)
									{
										Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Pineapple, 1);
									}
								}
							}
						}
						if (plantCommonMushroom)
						{
							if (forageFocus1)
							{
								if (Main.rand.Next(IndependenceConfig.Instance.plantBreakChance) == 0) {	WorldGen.KillTile(i, j);	}
								if (IndependenceConfig.Instance.enableForagingMoss && Main.rand.Next(10) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.BlueMoss, 1);
								}
							}
						}
						if (plantCommonCorrupt)
						{
							if (forageFocus1)
							{
								if (Main.rand.Next(IndependenceConfig.Instance.plantBreakChance) == 0) {	WorldGen.KillTile(i, j);	}
								if (IndependenceConfig.Instance.enableForagingMoss && Main.rand.Next(10) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.PurpleMoss, 1);
								}
							}
							if (forageFocus3)
							{
								if (Main.rand.Next(IndependenceConfig.Instance.plantBreakChance) == 0) {	WorldGen.KillTile(i, j);	}
								if (IndependenceConfig.Instance.enableForagingForFruits)
								{
									if (Main.rand.Next(IndependenceConfig.Instance.forageChanceFruitsCorruption) == 0)
									{
										Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.BlackCurrant, 1);
									}
									if (Main.rand.Next(IndependenceConfig.Instance.forageChanceFruitsCorruption) == 0)
									{
										Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Elderberry, 1);
									}
								}
							}
						}
						if (plantCommonCorrupt)
						{
							if (forageFocus1)
							{
								if (Main.rand.Next(IndependenceConfig.Instance.plantBreakChance) == 0) {	WorldGen.KillTile(i, j);	}
								if (IndependenceConfig.Instance.enableForagingMoss && Main.rand.Next(10) == 0)
								{
									Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.RedMoss, 1);
								}
							}
							if (forageFocus3)
							{
								if (Main.rand.Next(IndependenceConfig.Instance.plantBreakChance) == 0) {	WorldGen.KillTile(i, j);	}
								if (IndependenceConfig.Instance.enableForagingForFruits)
								{
									if (Main.rand.Next(IndependenceConfig.Instance.forageChanceFruitsCrimson) == 0)
									{
										Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.BloodOrange, 1);
									}
									if (Main.rand.Next(IndependenceConfig.Instance.forageChanceFruitsCrimson) == 0)
									{
										Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Rambutan, 1);
									}
								}
							}
						}
					}
				}
				if (IndependenceConfig.Instance.enableForagingFromUncommonPlants)
				{
					if (plantUncommon)
					{
						if (forageFocus1)
						{
							if (Main.rand.Next(IndependenceConfig.Instance.plantBreakChance) == 0) {	WorldGen.KillTile(i, j);	}
							if (IndependenceConfig.Instance.enableForagingHay && Main.rand.Next(2) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Hay, 1);
							}
							if (IndependenceConfig.Instance.enableForagingCobweb && Main.rand.Next(5) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Cobweb, 1);
							}
							if (IndependenceConfig.Instance.enableForagingAcorn && Main.rand.Next(10) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Acorn, 1);
							}
							if (IndependenceConfig.Instance.enableForagingVine && Main.rand.Next(40) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Vine, 1);
							}
							if (IndependenceConfig.Instance.enableForagingHerbBag && Main.rand.Next(80) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.HerbBag, 1);
							}
						}
						if (forageFocus3)
						{
							if (Main.rand.Next(IndependenceConfig.Instance.plantBreakChance) == 0) {	WorldGen.KillTile(i, j);	}
							if (type == TileID.SeaOats)
							{
								if (IndependenceConfig.Instance.enableForagingForFruits)
								{
									if (Main.rand.Next(IndependenceConfig.Instance.forageChanceFruitsPalm) == 0)
									{
										Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Banana, 1);
									}
									if (Main.rand.Next(IndependenceConfig.Instance.forageChanceFruitsPalm) == 0)
									{
										Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Coconut, 1);
									}
								}
							}
						}
					}
				}
				if (IndependenceConfig.Instance.enableForagingFromVines)
				{
					if (type == TileID.Vines || type == TileID.VineFlowers || type == TileID.JungleVines || type == TileID.MushroomVines || type == TileID.CrimsonVines)
					{
						WorldGen.KillTile(i, j);
						if (IndependenceConfig.Instance.enableForagingVine && Main.rand.Next(80) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Vine, 1);
						}
						if (IndependenceConfig.Instance.enableForagingHay && Main.rand.Next(4) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Hay, 1);
						}
						if (IndependenceConfig.Instance.enableForagingCobweb && Main.rand.Next(10) == 0)
						{
							Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.Cobweb, 1);
						}
						if (type == TileID.VineFlowers)
						{
							if (IndependenceConfig.Instance.enableForagingHerbBag && Main.rand.Next(80) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.HerbBag, 1);
							}
						}
						if (type == TileID.JungleVines)
						{
							if (IndependenceConfig.Instance.enableForagingMoss && Main.rand.Next(10) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.BrownMoss, 1);
							}
						}
						if (type == TileID.MushroomVines)
						{
							if (IndependenceConfig.Instance.enableForagingMoss && Main.rand.Next(10) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.BlueMoss, 1);
							}
						}
						if (type == TileID.CrimsonVines)
						{
							if (IndependenceConfig.Instance.enableForagingMoss && Main.rand.Next(10) == 0)
							{
								Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ItemID.RedMoss, 1);
							}
						}
					}
				}
			}
		}
		
		public override void MouseOver(int i, int j, int type)
		{
			Tile tile = Main.tile[i, j];
			Player Player = Main.LocalPlayer;

			var holdShift = Main.keyState.IsKeyDown(Keys.LeftShift);
			var holdControl = Main.keyState.IsKeyDown(Keys.LeftControl);
			var holdAlt = Main.keyState.IsKeyDown(Keys.LeftAlt);
			var forageFocus1 = holdShift;
			var forageFocus2 = holdControl;
			var forageFocus3 = holdShift && holdControl;
			var forageFocus4 = holdAlt;
			bool plantCommon = (type == TileID.Plants || type == TileID.Plants2 || type == TileID.JunglePlants || type == TileID.JunglePlants2 || type == TileID.MushroomPlants || type == TileID.CorruptPlants || type == TileID.CrimsonPlants || type == TileID.AshPlants);
			bool plantCommonDefault = (type == TileID.Plants || type == TileID.Plants2);
			bool plantCommonJungle = (type == TileID.JunglePlants || type == TileID.JunglePlants2);
			bool plantCommonMushroom = (type == TileID.MushroomPlants);
			bool plantCommonCorrupt = (type == TileID.CorruptPlants);
			bool plantCommonCrimson = (type == TileID.CrimsonPlants);
			bool plantCommonAsh = (type == TileID.AshPlants);
			bool plantUncommon = (type == TileID.SeaOats || type == TileID.Cattail || type == TileID.LilyPad);
			bool plantVine = (type == TileID.Vines || type == TileID.VineFlowers || type == TileID.JungleVines || type == TileID.MushroomVines || type == TileID.CrimsonVines);
			
			if (type == TileID.MatureHerbs)
			{
				Player.cursorItemIconEnabled = true;
				if (tile.TileFrameX >= 0)
				{
					Player.cursorItemIconID = ItemID.PowerGlove;
				}
			}
			if (IndependenceConfig.Instance.enableForaging)
			{
				if (IndependenceConfig.Instance.enableForagingFromCommonPlants)
				{
					if (plantCommon)
					{
						Player.cursorItemIconEnabled = true;
						if (forageFocus1 && tile.TileFrameX >= 0)
						{
							Player.cursorItemIconID = ItemID.Hay;
						}
						if (forageFocus2 && tile.TileFrameX >= 0)
						{
							Player.cursorItemIconID = ItemID.Wood;
						}
						if (forageFocus3 && tile.TileFrameX >= 0)
						{
							Player.cursorItemIconID = ItemID.Apple;
						}
					}
				}
				else if (IndependenceConfig.Instance.enableForagingFromUncommonPlants)
				{
					if (plantUncommon)
					{
						Player.cursorItemIconEnabled = true;
						if (tile.TileFrameX >= 0)
						{
							Player.cursorItemIconID = ItemID.PowerGlove;
						}
					}
				}
				else if (IndependenceConfig.Instance.enableForagingFromVines)
				{
					if (plantVine)
					{
						Player.cursorItemIconEnabled = true;
						if (tile.TileFrameX >= 0)
						{
							Player.cursorItemIconID = ItemID.PowerGlove;
						}
					}
				}
			}
		}
	}
}