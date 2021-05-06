using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class AntagoArrow : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Antago Fiery Bolt");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 20;
			projectile.height = 34;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.maxPenetrate = 1;
			projectile.ranged = true;
			projectile.tileCollide = true;
			projectile.timeLeft = 1600;
			projectile.ignoreWater = true;
		}
		
		public override void Kill(int timeLeft)
		{
		    Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, mod.ProjectileType("AntagoFire"), 6, 0, Main.myPlayer);
		}
	}
}