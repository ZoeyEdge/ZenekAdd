using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class Bubble : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bubble");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 8;
			projectile.friendly = true;
			projectile.maxPenetrate = 10;
			projectile.melee = true;
			projectile.tileCollide = true;
			projectile.timeLeft = 1600;
			projectile.ignoreWater = true;
		}
	}
}