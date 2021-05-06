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
	public class ProbeCaller : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Probe Caller");
			Tooltip.SetDefault("The newest anti-terrarian technology!");
			ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true; 
			ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.damage = 37;
			item.knockBack = 1.6f;
			item.summon = true;
			item.width = 32;
			item.height = 40;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 4;
			item.value = Item.buyPrice(0, 12, 20, 0);
			item.value = Item.sellPrice (0, 10, 15, 0);
			item.rare = 5;
			item.mana = 12;
			item.UseSound = SoundID.Item44;
			
			item.noMelee = true;
			item.summon = true;
			item.buffType = ModContent.BuffType<FriendlyProbeBuff>();
			item.shoot = ModContent.ProjectileType<FriendlyProbe>();
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) 
		{
			player.AddBuff(item.buffType, 2);

			position = Main.MouseWorld;
			return true;
		}
	}
}