using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class HuntressGlaivePROJ : ModProjectile
	{
		public override string Texture => "ZenekAdd/Items/Weapons/HuntressGlaive";
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Laser Glaive");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 38;
			projectile.height = 38;
			projectile.aiStyle = 3;
			aiType = 113;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.maxPenetrate = -1;
			projectile.ranged = true;
			projectile.tileCollide = true;
			projectile.timeLeft = 1600;
			projectile.ignoreWater = true;
		}
	}
}	