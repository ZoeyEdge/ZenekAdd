using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class SlimeSpike : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slime Spike");
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

		// Additional hooks/methods here.
	}
}