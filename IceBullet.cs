using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenekAdd.Projectiles;

namespace ZenekAdd.Items
{
	public class IceBullet : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Frozen Bullet");
			Tooltip.SetDefault("Super-effective against flying grass dragons!");
		}

		public override void SetDefaults() 
		{
			item.damage = 2;
			item.ranged = true;
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.consumable = true; //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = Item.sellPrice(copper: 3);
			item.rare = ItemRarityID.Green;
			item.shoot = ModContent.ProjectileType<IceBulletPROJ>();  //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 16f;  //The speed of the projectile
			item.ammo = AmmoID.Bullet;  //The ammo class this ammo belongs to.
		}

		// Give each bullet consumed a 20% chance of granting the Wrath buff for 5 seconds
		//public override void OnConsumeAmmo(Player player) {
		//	if (Main.rand.NextBool(5)) {
		//		player.AddBuff(BuffID.Wrath, 300);
		//	}
		//}
		// This is cool but no thank you  ^

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 30);
			recipe.AddRecipe();
		}
	}
}