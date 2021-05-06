using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class AntagoFire : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Antago Fire Spirit");
		}

		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 24;
			projectile.friendly = true;
			projectile.penetrate = 3;
			projectile.maxPenetrate = 4;
			projectile.magic = true;
			projectile.tileCollide = false;
		}
	}
}