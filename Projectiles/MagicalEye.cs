using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class MagicalEye : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magical Eye");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 22;
			projectile.height = 36;
			projectile.aiStyle = 29;
			projectile.friendly = true;
			projectile.maxPenetrate = 4;
			projectile.magic = true;
			projectile.tileCollide = true;
			projectile.timeLeft = 175;
		}
		
		public override void AI()
		{
			int dust = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 105, projectile.velocity.X * 1.2f, projectile.velocity.Y * 1.2f, 130, default(Color), 3.75f);
			Main.dust[dust].noGravity = true;
			
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
            projectile.alpha = (int)projectile.localAI[0] * 2;
		}
	}
}