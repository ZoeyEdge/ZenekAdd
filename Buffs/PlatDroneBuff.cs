using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenekAdd.Projectiles.Minions;
using static Terraria.ModLoader.ModContent;

namespace ZenekAdd.Buffs
{
	public class PlatDroneBuff : ModBuff
	{
		public override void SetDefaults() 
		{
			DisplayName.SetDefault("Platinum Drone");
			Description.SetDefault("A crumbling Platinum Drone is defending you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) 
		{
			if (player.ownedProjectileCounts[ModContent.ProjectileType<PlatinumDrone>()] > 0) 
			{
				player.buffTime[buffIndex] = 18000;
			}
			else 
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
	}
}