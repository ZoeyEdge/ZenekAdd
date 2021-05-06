using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenekAdd.Projectiles.Minions;
using static Terraria.ModLoader.ModContent;

namespace ZenekAdd.Buffs
{
	public class LeafSpiritBuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Leaf Spirit");
			Description.SetDefault("A spirit of nature will protect you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			if (player.ownedProjectileCounts[ModContent.ProjectileType<LeafSpirit>()] > 0) {
				player.buffTime[buffIndex] = 18000;
			}
			else {
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
	}
}