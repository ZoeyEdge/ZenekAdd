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
	public class GraniteMachinery : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Granite Machinery");
			Tooltip.SetDefault("Commands a granite drone to protect you");
			ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true; 
			ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.damage = 23;
			item.knockBack = 1.5f;
			item.summon = true;
			item.width = 34;
			item.height = 32;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 4;
			item.value = Item.buyPrice(0, 0, 90, 0);
			item.rare = 2;
			item.mana = 10;
			item.UseSound = SoundID.Item44;
			
			item.noMelee = true;
			item.summon = true;
			item.buffType = ModContent.BuffType<GraniteDroneBuff>();
			item.shoot = ModContent.ProjectileType<GraniteDrone>();
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
			recipe.AddIngredient(ItemID.Granite, 50);
			recipe.AddIngredient(mod.GetItem("GranitePowerCell"), 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe(); 
		}
	}
}