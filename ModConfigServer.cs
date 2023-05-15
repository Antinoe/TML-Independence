using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace Independence
{
    [Label("Server Config")]
    public class IndependenceConfig : ModConfig
    {
        //This is here for the Config to work at all.
        public override ConfigScope Mode => ConfigScope.ServerSide;
		
        public static IndependenceConfig Instance;
		
	[Header("Foraging")]
		
        [Label("Enable Foraging")]
        [Tooltip("If false, Players cannot Right-Click certain tiles for resources.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableForaging {get; set;}
		
        [Label("Forage from Common Plants")]
        [Tooltip("If false, Players cannot Forage from Common Plants, such as Grass and Mushrooms.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableForagingFromCommonPlants {get; set;}
		
        [Label("Forage from Uncommon Plants")]
        [Tooltip("If false, Players cannot Forage from Uncommon Plants, such as Cattails, Lily Pads and Sea Oats.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableForagingFromUncommonPlants {get; set;}
		
        [Label("[i:Hay] Forage Hay")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableForagingHay {get; set;}
		
        [Label("[i:Cobweb] Forage Cobwebs")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableForagingCobweb {get; set;}
		
        [Label("[i:Acorn] Forage Acorns")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableForagingAcorn {get; set;}
		
        [Label("[i:Wood] Forage Wood")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableForagingWood {get; set;}
		
        [Label("[i:StoneBlock] Forage Stone")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableForagingStone {get; set;}
		
        [Label("[i:GreenMoss] Forage Moss")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableForagingMoss {get; set;}
		
        [Label("[i:Vine] Forage Vines")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableForagingVine {get; set;}
		
        [Label("[i:HerbBag] Forage Herb Bags")]
        [Tooltip("[Default: On]")]
        [DefaultValue(true)]
        public bool enableForagingHerbBag {get; set;}
		
		/*
        [Label("Forage from Common Plants")]
        [Tooltip("If false, Players cannot Forage from Common Plants, such as Grass and Mushrooms.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableForagingFromCommonPlants {get; set;}
		
        [Label("Forage from Uncommon Plants")]
        [Tooltip("If false, Players cannot Forage from Uncommon Plants, such as Cattails, Lily Pads and Sea Oats.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableForagingFromUncommonPlants {get; set;}
		
        [Label("[i:Hay] Hay Forage Chance")]
        [Tooltip("[Default: 4]")]
        [Slider]
        [DefaultValue(4)]
        [Range(1, 30)]
        [Increment(1)]
        public int forageChanceCommonPlantsHay {get; set;}
		
        [Label("[i:Cobweb] Cobweb Forage Chance")]
        [Tooltip("[Default: 10]")]
        [Slider]
        [DefaultValue(10)]
        [Range(1, 30)]
        [Increment(1)]
        public int forageChanceCommonPlantsCobweb {get; set;}
		
        [Label("[i:Acorn] Acorn Forage Chance")]
        [Tooltip("[Default: 20]")]
        [Slider]
        [DefaultValue(20)]
        [Range(1, 30)]
        [Increment(1)]
        public int forageChanceCommonPlantsAcorn {get; set;}
		
        [Label("[i:GreenMoss] Moss Forage Chance")]
        [Tooltip("[Default: 10]")]
        [Slider]
        [DefaultValue(10)]
        [Range(20, 200)]
        [Increment(20)]
        public int forageChanceCommonPlantsMoss {get; set;}
		
        [Label("[i:Vine] Vine Forage Chance")]
        [Tooltip("[Default: 80]")]
        [Slider]
        [DefaultValue(80)]
        [Range(20, 200)]
        [Increment(20)]
        public int forageChanceCommonPlantsVine {get; set;}
		
        [Label("[i:HerbBag] Herb Bag Forage Chance")]
        [Tooltip("[Default: 80]")]
        [Slider]
        [DefaultValue(160)]
        [Range(20, 200)]
        [Increment(20)]
        public int forageChanceCommonPlantsHerbBag {get; set;}
		*/
		
        [Label("Forage from Vines")]
        [Tooltip("[Default: Off]")]
        [DefaultValue(false)]
        public bool enableForagingFromVines {get; set;}
		
        [Label("Forage for Fruits")]
        [Tooltip("If false, Players cannot Forage for Fruits from Common Plants.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableForagingForFruits {get; set;}
		
        [Label("[i:Apple] Forest Fruit Forage Chance")]
        [Tooltip("Chance for Common Plants to drop fruit.\n[Default: 200]")]
        [Slider]
        [DefaultValue(200)]
        [Range(20, 300)]
        [Increment(20)]
        public int forageChanceFruitsForest {get; set;}
		
        [Label("[i:Mango] Jungle Fruit Forage Chance")]
        [Tooltip("Chance for Common Plants to drop fruit.\n[Default: 100]")]
        [Slider]
        [DefaultValue(100)]
        [Range(20, 300)]
        [Increment(20)]
        public int forageChanceFruitsJungle {get; set;}
		
        [Label("[i:Coconut] Palm Fruit Forage Chance")]
        [Tooltip("Chance for Common Plants to drop fruit.\n[Default: 100]")]
        [Slider]
        [DefaultValue(100)]
        [Range(20, 300)]
        [Increment(20)]
        public int forageChanceFruitsPalm {get; set;}
		
        [Label("[i:Elderberry] Corruption Fruit Forage Chance")]
        [Tooltip("Chance for Common Plants to drop fruit.\n[Default: 100]")]
        [Slider]
        [DefaultValue(100)]
        [Range(20, 300)]
        [Increment(20)]
        public int forageChanceFruitsCorruption {get; set;}
		
        [Label("[i:Rambutan] Crimson Fruit Forage Chance")]
        [Tooltip("Chance for Common Plants to drop fruit.\n[Default: 100]")]
        [Slider]
        [DefaultValue(100)]
        [Range(20, 300)]
        [Increment(20)]
        public int forageChanceFruitsCrimson {get; set;}
		
	[Header("Recipes")]
		
        [Label("[i:BottledWater] Enable Liquid Recipes")]
        [Tooltip("If true, the custom recipes of Liquids (Snow, Water, Lava and Honey) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableLiquids {get; set;}
		
        [Label("[i:SiltBlock] Enable Earthen Recipes")]
        [Tooltip("If true, the custom recipes of Earthen Materials (Ash, Silt, Sand, Stone, etc.) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableEarthen {get; set;}
		
        [Label("[i:Silk] Enable Fabric Recipes")]
        [Tooltip("If true, the custom recipes of Fabrics (Cobwebs, Tattered Cloth, Silk, Leather, etc.) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableFabrics {get; set;}
		
        [Label("[i:Apple] Enable Fruit Recipes")]
        [Tooltip("If true, the custom recipes of Fruits (Apples, Cherries, Mangos, Bananas, etc.) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableFruits {get; set;}
		
        [Label("[i:TinCan] Enable Recycle Recipes")]
        [Tooltip("If true, the custom recipes of Recycleables (Old Shoe, Tin Can, Seaweed) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableRecycle {get; set;}
		
        [Label("[i:WormTooth] Enable Organic Recipes")]
        [Tooltip("If true, the custom recipes of Organics (Worm Teeth) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableOrganics {get; set;}
		
        [Label("[i:BugNet] Enable Tool Recipes")]
        [Tooltip("If true, the custom recipes of Tools (Sickle, Bug Net) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableTools {get; set;}
		
        [Label("[i:BambooBlock] Enable Plant Recipes")]
        [Tooltip("If true, the custom recipes of Plants (Bamboo, Cacti) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enablePlants {get; set;}
		
        [Label("[i:GrassSeeds] Enable Seed Recipes")]
        [Tooltip("If true, the custom recipes of various Seeds (Grass, Jungle Grass, Mushroom Grass, Corrupt, Crimson) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableSeeds {get; set;}
		
        [Label("[i:Waterleaf] Enable Herbal Flower Recipes")]
        [Tooltip("If true, the custom recipes of Herbal Flowers (Daybloom, Waterleaf, Blinkroot, etc.) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableHerbsFlowers {get; set;}
		
        [Label("[i:Mushroom] Enable Herbal Mushroom Recipes")]
        [Tooltip("If true, the custom recipes of Herbal Mushrooms (Mushroom, Vile Mushroom, Vicious Mushroom) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableHerbsMushrooms {get; set;}
		
        [Label("[i:Bomb] Enable Weapon Recipes")]
        [Tooltip("If true, the custom recipes of Weapons (Explosive Powder, Grenades, Bombs) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableWeapons {get; set;}
		
        [Label("[i:Extractinator] Enable Workstation Recipes")]
        [Tooltip("If true, the custom recipes of Workstations (Living Loom, Extractinator, Tinkerer's Workshop, Ice Machine) are enabled.\n(REQUIRES MOD RELOAD.)\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableWorkstations {get; set;}

    [Header("Starting")]
        
        [Label("Give Copper Starter Set")]
        [Tooltip("If true, Players will still be granted Copper Tools upon spawning.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool giveCopperSet {get; set;}
        
    [Header("Crude Bag")]
        
        [Label("Give Wooden Stake")]
        [Tooltip("If false, Players will not receive a Wooden Stake.\n[Default: On]")]
        [DefaultValue(true)]
        public bool giveWoodenStake {get; set;}
        
        [Label("Give Wooden Club")]
        [Tooltip("If false, Players will not receive a Wooden Club.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool giveWoodenClub {get; set;}
        
        [Label("Give Stone Axe")]
        [Tooltip("If false, Players will not receive a Stone Axe.\n[Default: On]")]
        [DefaultValue(true)]
        public bool giveStoneAxe {get; set;}
        
        [Label("Give Stone Pickaxe")]
        [Tooltip("If false, Players will not receive a Stone Pickaxe.\n[Default: On]")]
        [DefaultValue(true)]
        public bool giveStonePickaxe {get; set;}
        
        [Label("Give Weed Wraps")]
        [Tooltip("How many Weed Wraps to give.\n[Default: 2]")]
        [Slider]
        [DefaultValue(2)]
        [Range(0, 10)]
        [Increment(1)]
        public int giveWeedWrap {get; set;}
        
        [Label("Give Herbal Weed Wraps")]
        [Tooltip("How many Herbal Weed Wraps to give.\n[Default: 0]")]
        [Slider]
        [DefaultValue(0)]
        [Range(0, 10)]
        [Increment(1)]
        public int giveHerbalWeedWrap {get; set;}
        
    [Header("Weapons")]
        
        [Label("Wooden Club Damage")]
        [Tooltip("How much damage the Wooden Club deals.\n[Default: 9]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(9)]
        [Range(6, 20)]
        [Increment(1)]
        public int weaponsWoodenClubDamage {get; set;}
        
        [Label("Wooden Club Swing Speed")]
        [Tooltip("How slowly the Wooden Club swings.\n[Default: 29]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(29)]
        [Range(20, 40)]
        [Increment(1)]
        public int weaponsWoodenClubUseTime {get; set;}
        
        [Label("Wooden Club Knockback")]
        [Tooltip("The Knockback value for the Wooden Club.\n[Default: 8]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(8)]
        [Range(1, 10)]
        [Increment(1)]
        public int weaponsWoodenClubKnockback {get; set;}
        
        [Label("Wooden Stake Damage")]
        [Tooltip("How much damage the Wooden Stake deals.\n[Default: 4]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(4)]
        [Range(1, 6)]
        [Increment(1)]
        public int weaponsWoodenStakeDamage {get; set;}
        
        [Label("Wooden Stake Swing Speed")]
        [Tooltip("How slowly the Wooden Stake swings.\n[Default: 13]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(13)]
        [Range(1, 15)]
        [Increment(1)]
        public int weaponsWoodenStakeUseTime {get; set;}
        
    [Header("Tools")]
        
        [Label("Stone Axe Damage")]
        [Tooltip("How much damage the Stone Axe deals.\n[Default: 2]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(2)]
        [Range(1, 4)]
        [Increment(1)]
        public int toolsStoneAxeDamage {get; set;}
        
        [Label("Stone Axe Swing Speed")]
        [Tooltip("How slowly the Stone Axe swings.\n[Default: 32]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(32)]
        [Range(20, 40)]
        [Increment(1)]
        public int toolsStoneAxeUseTime {get; set;}
        
        [Label("Stone Axe Mine Speed")]
        [Tooltip("How quickly the Stone Axe chops trees.\n[Default: 5]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(5)]
        [Range(1, 10)]
        [Increment(1)]
        public int toolsStoneAxeMineSpeed {get; set;}
        
        [Label("Stone Pickaxe Damage")]
        [Tooltip("How much damage the Stone Pickaxe deals.\n[Default: 3]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(3)]
        [Range(1, 5)]
        [Increment(1)]
        public int toolsStonePickaxeDamage {get; set;}
        
        [Label("Stone Pickaxe Swing Speed")]
        [Tooltip("How slowly the Stone Pickaxe swings.\n[Default: 30]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(30)]
        [Range(20, 40)]
        [Increment(1)]
        public int toolsStonePickaxeUseTime {get; set;}
        
        [Label("Stone Pickaxe Mine Speed")]
        [Tooltip("How quickly the Stone Pickaxe breaks blocks.\n[Default: 25]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(25)]
        [Range(1, 25)]
        [Increment(1)]
        public int toolsStonePickaxeMineSpeed {get; set;}
        
    [Header("Consumables")]
        
        [Label("Weed Wrap Heal Amount")]
        [Tooltip("How much Life the Weed Wrap will heal upon consumption.\n[Default: 5]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(5)]
        [Range(0, 10)]
        [Increment(1)]
        public int consumablesWeedWrapHealAmount {get; set;}
        
        [Label("Weed Wrap Heal Duration")]
        [Tooltip("How long the Weed Wrap's buff will last.\n[Default: 600]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(600)]
        [Range(0, 2400)]
        [Increment(100)]
        public int consumablesWeedWrapHealDuration {get; set;}
        
        [Label("Weed Wraps Craft Cost")]
        [Tooltip("How much Hay is required to craft a single Weed Wrap.\n[Default: 10]\n(REQUIRES MOD RELOAD)")]
        [Slider]
        [DefaultValue(10)]
        [Range(1, 50)]
        [Increment(1)]
        public int consumablesWeedWrapCraftCost {get; set;}
        
        [Label("Herbal Weed Wrap Heal Amount")]
        [Tooltip("How much Life the Herbal Weed Wrap will heal upon consumption.\n[Default: 10]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(10)]
        [Range(0, 10)]
        [Increment(1)]
        public int consumablesHerbalWeedWrapHealAmount {get; set;}
        
        [Label("Herbal Weed Wrap Heal Duration")]
        [Tooltip("How long the Herbal Weed Wrap's buff will last.\n[Default: 1200]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(1200)]
        [Range(0, 2400)]
        [Increment(100)]
        public int consumablesHerbalWeedWrapHealDuration {get; set;}
        
        [Label("Herbal Weed Wraps Craft Cost")]
        [Tooltip("How much Hay is required to craft a single Herbal Weed Wrap.\n[Default: 15]\n(REQUIRES MOD RELOAD)")]
        [Slider]
        [DefaultValue(15)]
        [Range(1, 50)]
        [Increment(1)]
        public int consumablesHerbalWeedWrapCraftCost {get; set;}
    }
}