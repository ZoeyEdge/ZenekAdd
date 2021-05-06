using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class Fireball : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fireball");
		}

		public override void SetDefaults()
		{
			projectile.aiStyle = 1;
			projectile.width = 32;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.maxPenetrate = -1;
			projectile.magic = true;
			projectile.tileCollide = false;
			projectile.timeLeft = 250;
			projectile.ignoreWater = true;
		}

		public override void Kill(int timeLeft)
		{
		    Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, 296, (int) (5 * 1), projectile.knockBack, Main.myPlayer);
		}
		
		public override void AI()
		{
		    int dust = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 105, projectile.velocity.X * 1.2f, projectile.velocity.Y * 1.2f, 130, default(Color), 3.75f);
			    Main.dust[dust].noGravity = true;
		}
	}
}