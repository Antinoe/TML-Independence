using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Independence.Content.Items
{
	public class WoodenClub : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Wooden Club");
		}
        public override string Texture => "Independence/Content/Items/Weapons/WoodenClub";

		public override void SetDefaults() 
		{
			Item.damage = IndependenceConfig.Instance.weaponsWoodenClubDamage;
			Item.width = 36;
			Item.height = 34;
			Item.scale = 1f;
			Item.useTime = IndependenceConfig.Instance.weaponsWoodenClubUseTime;
			Item.useAnimation = IndependenceConfig.Instance.weaponsWoodenClubUseTime;
			Item.useStyle = 1;
			Item.knockBack = IndependenceConfig.Instance.weaponsWoodenClubKnockback;
			Item.value = 200;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.DamageType = DamageClass.Melee; //This is what allows Reforging to work on this item.
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddRecipeGroup(RecipeGroupID.Wood, 11)
            .Register();
		}
	}
	public class WoodenStake : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Wooden Stake");
		}
        public override string Texture => "Independence/Content/Items/Weapons/WoodenStake";
		
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
			Item.shoot = ModContent.ProjectileType<Content.Projectiles.WoodenStakeProjectile>(); //The projectile itself is what makes a shortsword work.
			Item.shootSpeed = 2.1f; // This value bleeds into the behavior of the projectile as velocity. Keep that in mind when tweaking values.
		}
		
		public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddRecipeGroup(RecipeGroupID.Wood, 2)
            .Register();
		}
	}
	public class WoodenStakeTEST : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Wooden Stake Test");
			// Tooltip.SetDefault("Right click for a slash that confuses enemies and heals you.");
		}
        public override string Texture => "Independence/Content/Items/Weapons/WoodenStakeTEST";

		public override void SetDefaults() 
		{
			Item.damage = 4;
			Item.width = 16;
			Item.height = 16;
			Item.scale = 1f;
			Item.useTime = 11;
			Item.useAnimation = 11;
			//Item.useStyle = ItemUseStyleID.Rapier; //Use this, not useStyle 3.
			Item.useStyle = 3;
			Item.knockBack = 4;
			Item.value = 100;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.DamageType = DamageClass.Melee; //This is what allows Reforging to work on this Item.
			//Item.noUseGraphic = true; //The Item is not visible when used, as it spawns a Projectile instead.
			//Item.noMelee = true; //The projectile will do the damage, not the Item itself.
			//Item.shoot = ModContent.ProjectileType<WoodenStakeProjectile>();
		}
		
		public override bool AltFunctionUse(Player Player) => true;
		
		public override bool CanUseItem(Player Player)
		{
			if (Player.altFunctionUse == 2)
			{
				Item.useTime = 11;
			    Item.useStyle = 8;
				if (Player.itemTime == 0)
				{
					return (true);
				}
				else
				{
					return (false);
				}
			}
			else
			{
				Item.useTime = 13;
				Item.useStyle = 3;
				return (true);
			}
		}
		
		/*public override bool UseItem(Player Player)
		{
			if(Player.altFunctionUse == 2)
			{
				return (true);
			}
			return base.UseItem(Player);
		}*/
		
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Item.useStyle == 8)
			{
				// 60 frames = 1 second
				//Target.AddBuff(BuffID.Weak, 300);
				//Target.AddBuff(BuffID.Bleeding, 300);
				target.AddBuff(BuffID.Confused, 300);
				player.AddBuff(BuffID.HeartyMeal, 150);
				player.AddBuff(BuffID.Panic, 75);
				//Player.AddBuff(BuffID.Darkness, 150);
				//Player.AddBuff(BuffID.Blackout, 150);
				//Player.AddBuff(BuffID.Obstructed, 150);
			}
		}
		
		public override void OnHitPvp(Player player, Player target, Player.HurtInfo hurtInfo)
		{
			if (Item.useStyle == 8)
			{
				// 60 frames = 1 second
				//Target.AddBuff(BuffID.Weak, 300);
				//Target.AddBuff(BuffID.Bleeding, 300);
				target.AddBuff(BuffID.Confused, 300);
				player.AddBuff(BuffID.HeartyMeal, 150);
				player.AddBuff(BuffID.Panic, 75);
				//Player.AddBuff(BuffID.Darkness, 150);
				//Player.AddBuff(BuffID.Blackout, 150);
				//Player.AddBuff(BuffID.Obstructed, 150);
			}
		}
		
		/*public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddRecipeGroup(RecipeGroupID.Wood, 2)
            .Register();
		}*/
	}
}