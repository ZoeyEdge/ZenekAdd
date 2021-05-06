using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenekAdd.Projectiles;

namespace ZenekAdd.Items.Weapons
{
	public class AntagoCrossbow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Antago Crossbow");
			Tooltip.SetDefault("Turns regular arrows into fiery bolts"
			+ "\nFiery bolts leave a fire spirit that damages enemies");
		}

		public override void SetDefaults() 
		{
			item.damage = 27;
			item.ranged = true;
			item.width = 52;
			item.height = 22;
			item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 5;
			item.knockBack = 4;
			Item.buyPrice(0, 10, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("AntagoArrow");
			item.useAmmo = AmmoID.Arrow; // uses arrows as ammo
			item.shootSpeed = 13f;
		}
        
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.WoodenArrowFriendly) // if I shoot regular arrows:
			{
				type = ModContent.ProjectileType<AntagoArrow>(); // change them into Antago Fiery bolts!
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}
	}
}