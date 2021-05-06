using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class IceSpike : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice Spike");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 6;
			projectile.height = 6;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.maxPenetrate = -1;
			projectile.magic = true;
			projectile.tileCollide = true;
		}

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(44, 120, false); //The debuff inflicted is the debuff Frostburn. 120 is the duration in frames: Terraria runs at 60 FPS, so that's 3 seconds (180/60=3). To change the modded debuff, change EtherealFlames to whatever the buff is called; to add a vanilla debuff, change mod.BuffType("EtherealFlames") to a number based on the terraria buff IDs. Some useful ones are 20 for poison, 24 for On Fire!, 39 for Cursed Flames, 69 for Ichor, and 70 for Venom.
        }
	}
}