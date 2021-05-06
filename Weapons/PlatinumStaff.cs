using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenekAdd.Buffs;
using ZenekAdd.Projectiles.Minions;
using static Terraria.ModLoader.ModContent;

namespace ZenekAdd.Items.Weapons
{
	public class PlatinumStaff : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Platinum Staff");
			Tooltip.SetDefault("Summons a Platinum Drone that desummons after a few hits"
			+ "\nDoesn't consume minion slots");
			ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true; 
			ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.damage = 13;
			item.knockBack = 3f;
			item.summon = true;
			item.width = 44;
			item.height = 44;
			item.useTime = 42;
			item.useAnimation = 42;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 0, 63, 0);
			item.rare = 1;
			item.mana = 9;
			item.UseSound = SoundID.Item44;
			item.noMelee = true;
			item.summon = true;
			item.buffType = ModContent.BuffType<PlatDroneBuff>();
			item.shoot = ModContent.ProjectileType<PlatinumDrone>();
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) 
		{
			player.AddBuff(item.buffType, 2);

			position = Main.MouseWorld;
			return true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 9);
			recipe.AddIngredient(ItemID.Ruby, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}