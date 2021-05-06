using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class MarisaPROJ1 : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Youkai Heart");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 30;
			projectile.height = 30;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.maxPenetrate = -1;
			projectile.magic = true;
			projectile.tileCollide = true;
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(20, 160, false);  
        }
	}
}