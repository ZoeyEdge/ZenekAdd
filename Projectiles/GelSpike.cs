using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class GelSpike : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Spike");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 30;
			projectile.height = 26;
			projectile.aiStyle = 29;
			projectile.friendly = true;
			projectile.maxPenetrate = -1;
			projectile.melee = true;
			projectile.tileCollide = true;
			projectile.timeLeft = 165;
		}
		
		public override void AI()
		{
			int dust = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 103, projectile.velocity.X * 1.2f, projectile.velocity.Y * 1.2f, 130, default(Color), 3.75f);
			Main.dust[dust].noGravity = true;
			
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
            projectile.alpha = (int)projectile.localAI[0] * 2;
		}
	}
}