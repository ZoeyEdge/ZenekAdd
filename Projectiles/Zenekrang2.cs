using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class Zenekrang2 : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zenekrang2");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 22;
			projectile.height = 22;
			projectile.aiStyle = 3;
			projectile.friendly = true;
			projectile.penetrate = 2;
			projectile.melee = true;
			projectile.tileCollide = true;
			projectile.timeLeft = 1200;
			projectile.ignoreWater = true;
		}
	}
}	