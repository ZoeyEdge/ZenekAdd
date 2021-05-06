using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenekAdd.Projectiles.Minions;
using static Terraria.ModLoader.ModContent;

namespace ZenekAdd.Buffs
{
	public class FriendlyProbeBuff : ModBuff
	{
		public override void SetDefaults() 
		{
			DisplayName.SetDefault("Friendly Probe");
			Description.SetDefault("A hacked probe will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) 
		{
			if (player.ownedProjectileCounts[ModContent.ProjectileType<FriendlyProbe>()] > 0) 
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