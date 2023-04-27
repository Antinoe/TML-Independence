using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Independence.Content.Projectiles;

namespace Independence.Content.Items.Weapons
{
	public class WoodenStake : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Stake");
		}
		
		public override void SetDefaults()
		{
			Item.damage = IndependenceConfig.Instance.weaponsWoodenStakeDamage;
			Item.width = 16;
			Item.height = 16;
			Item.scale = 1f;
			Item.useTime = IndependenceConfig.Instance.weaponsWoodenStakeUseTime;
			Item.useAnimation = IndependenceConfig.Instance.weaponsWoodenStakeUseTime;
			Item.useStyle = ItemUseStyleID.Rapier;
			Item.knockBack = 5;
			Item.value = 100;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.DamageType = DamageClass.Melee; //This is what allows Reforging to work on this Item.
			
			//Projectile stuff.
			Item.noUseGraphic = true; //The item should not be visible upon use, as it is a Projectile.
			Item.noMelee = true; //The item will not deal damage. The projectile will.
			Item.shoot = ModContent.ProjectileType<WoodenStakeProjectile>(); //The projectile itself is what makes a shortsword work.
			Item.shootSpeed = 2.1f; // This value bleeds into the behavior of the projectile as velocity. Keep that in mind when tweaking values.
		}
		
		public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddRecipeGroup(RecipeGroupID.Wood, 2)
            .Register();
		}
	}
}